using Mtf.Permissions.Enums;
using System;

namespace Mtf.Permissions.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class RequirePermissionAttribute : Attribute
    {
        public long PermissionValue { get; }

        public Type PermissionGroup { get; }

        public RequirePermissionAttribute(ApplicationManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(ApplicationManagementPermissions);
        }

        public RequirePermissionAttribute(CameraManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraManagementPermissions);
        }

        public RequirePermissionAttribute(DisplayManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(DisplayManagementPermissions);
        }

        public RequirePermissionAttribute(EventManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(EventManagementPermissions);
        }

        public RequirePermissionAttribute(GeneralPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(GeneralPermissions);
        }

        public RequirePermissionAttribute(GridManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(GridManagementPermissions);
        }

        public RequirePermissionAttribute(GroupManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(GroupManagementPermissions);
        }

        public RequirePermissionAttribute(IODeviceManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(IODeviceManagementPermissions);
        }

        public RequirePermissionAttribute(LanguageManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(LanguageManagementPermissions);
        }

        public RequirePermissionAttribute(LogManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(LogManagementPermissions);
        }

        public RequirePermissionAttribute(MapManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(MapManagementPermissions);
        }

        public RequirePermissionAttribute(PermissionManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(PermissionManagementPermissions);
        }

        public RequirePermissionAttribute(SequenceManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(SequenceManagementPermissions);
        }

        public RequirePermissionAttribute(SerialDeviceManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(SerialDeviceManagementPermissions);
        }

        public RequirePermissionAttribute(ServerManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(ServerManagementPermissions);
        }

        public RequirePermissionAttribute(SettingsManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(SettingsManagementPermissions);
        }

        public RequirePermissionAttribute(TemplateManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(TemplateManagementPermissions);
        }

        public RequirePermissionAttribute(UserManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(UserManagementPermissions);
        }

        public RequirePermissionAttribute(WindowManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(WindowManagementPermissions);
        }

        public override string ToString()
        {
            return $"Required permission: {PermissionGroup.Name} ({PermissionValue})";
        }
    }
}
