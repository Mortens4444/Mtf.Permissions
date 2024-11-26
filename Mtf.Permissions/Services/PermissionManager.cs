﻿using Mtf.Permissions.Attributes;
using Mtf.Permissions.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Mtf.Permissions.Services
{
    public class PermissionManager
    {
        private User currentUser;

        public void SetUser(Form form, User currentUser)
        {
            this.currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            ApplyPermissionsOnControls(form);
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
                if (!currentUser.HasPermission(attribute))
                {
                    throw new UnauthorizedAccessException($"No permission for this operation: {method.Name}");
                }
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
            if (menuItem.Tag is string methodName)
            {
                var method = FindMethodWithAttribute(form.GetType(), methodName);
                if (method != null)
                {
                    var attributes = method.GetCustomAttributes<RequirePermissionAttribute>().ToList();
                    menuItem.Enabled = attributes.All(attr => currentUser?.HasPermission(attr) ?? false);
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
            if (control.Tag is string methodName)
            {
                var method = FindMethodWithAttribute(form.GetType(), methodName);
                if (method != null)
                {
                    var attributes = method.GetCustomAttributes<RequirePermissionAttribute>().ToList();
                    control.Enabled = attributes.All(attr => currentUser?.HasPermission(attr) ?? false);
                }
            }
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

            if (toolStripItem.Tag is string methodName)
            {
                var method = FindMethodWithAttribute(form.GetType(), methodName);
                if (method != null)
                {
                    var attributes = method.GetCustomAttributes<RequirePermissionAttribute>().ToList();
                    toolStripItem.Enabled = attributes.All(attr => currentUser?.HasPermission(attr) ?? false);
                }
            }
        }

        private static MethodInfo FindMethodWithAttribute(Type type, string methodName)
        {
            return type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                .FirstOrDefault(method => method.Name == methodName && method.GetCustomAttributes<RequirePermissionAttribute>().Any());
        }
    }
}
