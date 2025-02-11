using Mtf.Permissions.Attributes;
using Mtf.Permissions.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Mtf.Permissions.Services
{
    public class PermissionManager<T>
    {
        public User<T> CurrentUser { get; private set; }

        public void SetUser(Form form, User<T> currentUser)
        {
            CurrentUser = currentUser;
            ApplyPermissionsOnControls(form);
        }

        public void Logout(Form form)
        {
            SetUser(form, null);
        }

        /// <summary>
        /// Ensures that the user has the necessary permission to execute the method.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if the caller method not found.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown if the user does not have permission for the method.</exception>
        public void EnsurePermissions()
        {
            var stackTrace = new StackTrace();
            var frame = stackTrace.GetFrame(1);
            var method = frame?.GetMethod() ?? throw new InvalidOperationException("Caller method not found");

            if (method.DeclaringType == null)
            {
                throw new InvalidOperationException("Declaring type not found for method");
            }

            var attributes = method.GetCustomAttributes<RequirePermissionAttribute>();
            foreach (var attribute in attributes)
            {
                if (!CurrentUser.HasPermission(attribute))
                {
                    throw new UnauthorizedAccessException($"No permission for this operation: {method.Name}. {attribute}");
                }
            }

            var hasPermission = false;
            var anyAttributes = method.GetCustomAttributes<RequireAnyPermissionAttribute>();
            foreach (var attribute in anyAttributes)
            {
                if (CurrentUser.HasPermission(attribute))
                {
                    hasPermission = true;
                    break;
                }
            }
            if (anyAttributes.Any() && !hasPermission)
            {
                throw new UnauthorizedAccessException($"No permission for any of these operations: {method.Name}. {anyAttributes}");
            }
        }

        /// <summary>
        /// Processes controls that have the Tag property set to a function name.
        /// </summary>
        /// <param name="form">The container form.</param>
        /// <exception cref="ArgumentNullException">Thrown when the form is null.</exception>
        public void ApplyPermissionsOnControls(Form form)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form));
            }

            SetEnabledProperty(form, form);
            ApplyPermissionsOnControls(form, form.Controls);
        }

        public void ApplyPermissionsOnControls(Form form, UserControl userControl)
        {
            if (userControl == null)
            {
                throw new ArgumentNullException(nameof(userControl));
            }

            SetEnabledProperty(form, userControl);
            ApplyPermissionsOnControls(form, userControl.Controls);
        }

        public void ApplyPermissionsOnControls(Form form, Control.ControlCollection controls)
        {
            if (controls == null)
            {
                throw new ArgumentNullException(nameof(controls));
            }

            foreach (var control in controls)
            {
                if (control is WebBrowser)
                {
                    continue;
                }

                if (control is Control controlWithTagProperty)
                {
                    SetEnabledProperty(form, controlWithTagProperty);
                    ApplyPermissionsOnControls(form, controlWithTagProperty.Controls);
                    if (controlWithTagProperty.ContextMenuStrip != null)
                    {
                        ApplyPermissionsOnControls(form, controlWithTagProperty.ContextMenuStrip.Items);
                    }
                }

                if (control is MenuStrip menuStrip)
                {
                    ApplyPermissionsOnControls(form, menuStrip.Items);
                }
                else if (control is StatusStrip statusStrip)
                {
                    ApplyPermissionsOnControls(form, statusStrip.Items);
                }
                else if (control is ContextMenuStrip contextMenuStrip)
                {
                    ApplyPermissionsOnControls(form, contextMenuStrip.Items);
                }
#if NET481
                else if (control is ContextMenu contextMenu)
                {
                    ApplyPermissionsOnControls(form, contextMenu.MenuItems);
                }
            }
        }

        private void ApplyPermissionsOnControls(Form form, Menu.MenuItemCollection items)
        {
            if (items != null)
            {
                foreach (MenuItem item in items)
                {
                    SetEnabledProperty(form, item);
                    ApplyPermissionsOnControls(form, item.MenuItems);
                }
            }
        }

        public void SetEnabledProperty(Form form, MenuItem menuItem)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form));
            }
            if (menuItem == null)
            {
                throw new ArgumentNullException(nameof(menuItem));
            }

            var eventClickField = typeof(MenuItem).GetField("s_clickEvent", BindingFlags.NonPublic | BindingFlags.Static)
                                ?? typeof(MenuItem).GetField("EventClick", BindingFlags.NonPublic | BindingFlags.Static)
                                ?? typeof(MenuItem).GetField("s_eventClick", BindingFlags.NonPublic | BindingFlags.Static);

            if (eventClickField != null)
            {
                var eventClickKey = eventClickField.GetValue(null);
                var eventsProperty = typeof(MenuItem).GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);

                if (eventsProperty?.GetValue(menuItem) is EventHandlerList eventHandlers && eventClickKey != null)
                {
                    if (eventHandlers[eventClickKey] is MulticastDelegate eventDelegate)
                    {
                        foreach (var method in eventDelegate.GetInvocationList().Select(d => d.Method))
                        {
                            if (method.DeclaringType != null)
                            {
                                var attributes = method.GetCustomAttributes<RequirePermissionAttribute>().ToList();
                                if (attributes.Count > 0)
                                {
                                    menuItem.Enabled = attributes.All(attr => CurrentUser?.HasPermission(attr) ?? false);
                                    return;
                                }
                                else
                                {
                                    var anyAttributes = method.GetCustomAttributes<RequireAnyPermissionAttribute>().ToList();
                                    if (anyAttributes.Count > 0)
                                    {
                                        menuItem.Enabled = anyAttributes.Any(attr => CurrentUser?.HasPermission(attr) ?? false);
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (menuItem.Tag is string methodName)
            {
                var attributes = GetRequiredPermissionAttributes(form, methodName);
                if (attributes.Count > 0)
                {
                    menuItem.Enabled = attributes.All(attr => CurrentUser?.HasPermission(attr) ?? false);
                }
            }
        }

#else
            }
        }
#endif

        public void ApplyPermissionsOnControls(Form form, ToolStripItemCollection toolStripItems)
        {
            if (toolStripItems == null)
            {
                throw new ArgumentNullException(nameof(toolStripItems));
            }

            foreach (ToolStripItem toolStripItem in toolStripItems)
            {
                SetEnabledProperty(form, toolStripItem);
                if (toolStripItem is ToolStripMenuItem toolStripMenuItem)
                {
                    ApplyPermissionsOnControls(form, toolStripMenuItem.DropDownItems);
                }
                else if (toolStripItem is ToolStripDropDownButton toolStripDropDownButton)
                {
                    ApplyPermissionsOnControls(form, toolStripDropDownButton.DropDownItems);
                }
            }
        }

        public void SetEnabledProperty(Form form, Control control)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form));
            }
            if (control == null)
            {
                throw new ArgumentNullException(nameof(control));
            }

            var controlType = typeof(Control);
            var eventClickField = controlType.GetField("s_clickEvent", BindingFlags.NonPublic | BindingFlags.Static)
                                ?? controlType.GetField("EventClick", BindingFlags.NonPublic | BindingFlags.Static)
                                ?? controlType.GetField("s_eventClick", BindingFlags.NonPublic | BindingFlags.Static);

            var eventMouseClickField = controlType.GetField("s_mouseClickEvent", BindingFlags.NonPublic | BindingFlags.Static)
                    ?? controlType.GetField("EventMouseClick", BindingFlags.NonPublic | BindingFlags.Static)
                    ?? controlType.GetField("s_eventMouseClick", BindingFlags.NonPublic | BindingFlags.Static);

            var eventMouseDownField = controlType.GetField("s_mouseDownEvent", BindingFlags.NonPublic | BindingFlags.Static)
                                ?? controlType.GetField("EventMouseDown", BindingFlags.NonPublic | BindingFlags.Static)
                                ?? controlType.GetField("s_eventMouseDown", BindingFlags.NonPublic | BindingFlags.Static);

            var eventsProperty = controlType.GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
            if (eventClickField != null)
            {
                var eventClickKey = eventClickField.GetValue(null);
                if (eventsProperty?.GetValue(control) is EventHandlerList eventHandlers && eventClickKey != null)
                {
                    if (eventHandlers[eventClickKey] is MulticastDelegate eventDelegate)
                    {
                        if (EnableControlByDelegates(control, eventDelegate))
                        {
                            return;
                        }
                    }
                }
            }
            if (eventMouseClickField != null)
            {
                var eventMouseClickKey = eventMouseClickField.GetValue(null);
                if (eventsProperty?.GetValue(control) is EventHandlerList eventHandlers && eventMouseClickKey != null)
                {
                    if (eventHandlers[eventMouseClickKey] is MulticastDelegate eventDelegate)
                    {
                        if (EnableControlByDelegates(control, eventDelegate))
                        {
                            return;
                        }
                    }
                }
            }
            if (eventMouseDownField != null)
            {
                var eventMouseDownKey = eventMouseDownField.GetValue(null);
                if (eventsProperty?.GetValue(control) is EventHandlerList eventHandlers && eventMouseDownKey != null)
                {
                    if (eventHandlers[eventMouseDownKey] is MulticastDelegate eventDelegate)
                    {
                        if (EnableControlByDelegates(control, eventDelegate))
                        {
                            return;
                        }
                    }
                }
            }
            if (control.Tag is string methodName)
            {
                var attributes = GetRequiredPermissionAttributes(form, methodName);
                if (attributes.Count > 0)
                {
                    control.Enabled = attributes.All(attr => CurrentUser?.HasPermission(attr) ?? false);
                    return;
                }
            }

            control.Enabled = true;
        }

        private bool EnableControlByDelegates(Control control, MulticastDelegate eventDelegate)
        {
            foreach (var method in eventDelegate.GetInvocationList().Select(d => d.Method))
            {
                if (method.DeclaringType != null)
                {
                    var attributes = method.GetCustomAttributes<RequirePermissionAttribute>().ToList();
                    if (attributes.Count > 0)
                    {
                        control.Enabled = attributes.All(attr => CurrentUser?.HasPermission(attr) ?? false);
                        return true;
                    }
                    else
                    {
                        var anyAttributes = method.GetCustomAttributes<RequireAnyPermissionAttribute>().ToList();
                        if (anyAttributes.Count > 0)
                        {
                            control.Enabled = anyAttributes.Any(attr => CurrentUser?.HasPermission(attr) ?? false);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void SetEnabledProperty(Form form, ToolStripItem toolStripItem)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form));
            }
            if (toolStripItem == null)
            {
                throw new ArgumentNullException(nameof(toolStripItem));
            }

            var toolStripItemType = typeof(ToolStripItem);
            var eventClickField = toolStripItemType.GetField("s_clickEvent", BindingFlags.NonPublic | BindingFlags.Static)
                                ?? toolStripItemType.GetField("EventClick", BindingFlags.NonPublic | BindingFlags.Static)
                                ?? toolStripItemType.GetField("s_eventClick", BindingFlags.NonPublic | BindingFlags.Static);

            var eventMouseClickField = toolStripItemType.GetField("s_mouseClickEvent", BindingFlags.NonPublic | BindingFlags.Static)
                    ?? toolStripItemType.GetField("EventMouseClick", BindingFlags.NonPublic | BindingFlags.Static)
                    ?? toolStripItemType.GetField("s_eventMouseClick", BindingFlags.NonPublic | BindingFlags.Static);

            var eventMouseDownField = toolStripItemType.GetField("s_mouseDownEvent", BindingFlags.NonPublic | BindingFlags.Static)
                                ?? toolStripItemType.GetField("EventMouseDown", BindingFlags.NonPublic | BindingFlags.Static)
                                ?? toolStripItemType.GetField("s_eventMouseDown", BindingFlags.NonPublic | BindingFlags.Static);

            var eventsProperty = typeof(ToolStripItem).GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);
            if (eventClickField != null)
            {
                var eventClickKey = eventClickField.GetValue(null);
                if (eventsProperty?.GetValue(toolStripItem) is EventHandlerList eventHandlers && eventClickKey != null)
                {
                    if (eventHandlers[eventClickKey] is MulticastDelegate eventDelegate)
                    {
                        if (EnableToolStripItemByDelegates(toolStripItem, eventDelegate))
                        {
                            return;
                        }
                    }
                }
            }
            if (eventMouseClickField != null)
            {
                var eventMouseClickKey = eventMouseClickField.GetValue(null);
                if (eventsProperty?.GetValue(toolStripItem) is EventHandlerList eventHandlers && eventMouseClickKey != null)
                {
                    if (eventHandlers[eventMouseClickKey] is MulticastDelegate eventDelegate)
                    {
                        if (EnableToolStripItemByDelegates(toolStripItem, eventDelegate))
                        {
                            return;
                        }
                    }
                }
            }
            if (eventMouseDownField != null)
            {
                var eventMouseDownKey = eventMouseDownField.GetValue(null);
                if (eventsProperty?.GetValue(toolStripItem) is EventHandlerList eventHandlers && eventMouseDownKey != null)
                {
                    if (eventHandlers[eventMouseDownKey] is MulticastDelegate eventDelegate)
                    {
                        if (EnableToolStripItemByDelegates(toolStripItem, eventDelegate))
                        {
                            return;
                        }
                    }
                }
            }
            if (toolStripItem.Tag is string methodName)
            {
                var attributes = GetRequiredPermissionAttributes(form, methodName);
                if (attributes.Count > 0)
                {
                    toolStripItem.Enabled = attributes.All(attr => CurrentUser?.HasPermission(attr) ?? false);
                }
            }
        }

        private bool EnableToolStripItemByDelegates(ToolStripItem toolStripItem, MulticastDelegate eventDelegate)
        {
            foreach (var method in eventDelegate.GetInvocationList().Select(d => d.Method))
            {
                if (method.DeclaringType != null)
                {
                    var attributes = method.GetCustomAttributes<RequirePermissionAttribute>().ToList();
                    if (attributes.Count > 0)
                    {
                        toolStripItem.Enabled = attributes.All(attr => CurrentUser?.HasPermission(attr) ?? false);
                        return true;
                    }
                    else
                    {
                        var anyAttributes = method.GetCustomAttributes<RequireAnyPermissionAttribute>().ToList();
                        if (anyAttributes.Count > 0)
                        {
                            toolStripItem.Enabled = anyAttributes.Any(attr => CurrentUser?.HasPermission(attr) ?? false);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private static List<RequirePermissionAttribute> GetRequiredPermissionAttributes(Form form, string methodName)
        {
            var method = FindMethodWithAttribute(form.GetType(), methodName);
            return method != null ? method.GetCustomAttributes<RequirePermissionAttribute>().ToList() : new List<RequirePermissionAttribute>();
        }

        private static MethodInfo FindMethodWithAttribute(Type type, string methodName)
        {
            return type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                .FirstOrDefault(method => method.Name == methodName && method.GetCustomAttributes<RequirePermissionAttribute>().Any());
        }
    }
}
