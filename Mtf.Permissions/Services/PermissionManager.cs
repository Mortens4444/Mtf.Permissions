using Mtf.Permissions.Attributes;
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

        public void SetUser(Control container, User currentUser)
        {
            this.currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            ApplyPermissionsOnControls(container);
        }

        /// <summary>
        /// Processes controls that have the Tag property set to a function name.
        /// </summary>
        /// <param name="container">The container control, such as the Form itself.</param>
        /// <exception cref="ArgumentNullException">Thrown when the container is null.</exception>
        public void ApplyPermissionsOnControls(Control container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            foreach (var control in container.Controls.OfType<Control>())
            {
                if (control.Tag is string methodName)
                {
                    var method = FindMethodWithAttribute(container.GetType(), methodName);
                    if (method != null)
                    {
                        var attributes = method.GetCustomAttributes<RequirePermissionAttribute>().ToList();
                        control.Enabled = attributes.All(attr => currentUser?.HasPermission(attr.PermissionType) ?? false);
                    }
                }

                if (!control.Enabled)
                {
                    DisableChildren(control);
                }
                else if (control.HasChildren)
                {
                    ApplyPermissionsOnControls(control);
                }
            }
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
                if (!currentUser.HasPermission(attribute.PermissionType))
                {
                    throw new UnauthorizedAccessException($"No permission for this operation: {method.Name}");
                }
            }
        }

        private static MethodInfo FindMethodWithAttribute(Type type, string methodName)
        {
            return type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                .FirstOrDefault(method => method.Name == methodName && method.GetCustomAttributes<RequirePermissionAttribute>().Any());
        }

        private static void DisableChildren(Control parent)
        {
            foreach (var child in parent.Controls.OfType<Control>())
            {
                child.Enabled = false;
                if (child.HasChildren)
                {
                    DisableChildren(child);
                }
            }
        }
    }
}
