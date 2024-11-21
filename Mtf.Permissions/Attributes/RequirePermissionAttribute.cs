using Mtf.Permissions.Enums;
using System;

namespace Mtf.Permissions.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class RequirePermissionAttribute : Attribute
    {
        public PermissionType PermissionType { get; }

        public RequirePermissionAttribute(PermissionType permissionType)
        {
            PermissionType = permissionType;
        }

        public override string ToString()
        {
            return $"Required permission: {PermissionType}";
        }
    }
}
