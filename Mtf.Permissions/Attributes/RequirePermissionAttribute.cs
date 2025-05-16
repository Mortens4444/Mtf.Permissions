using Mtf.Permissions.Enums;
using System;

namespace Mtf.Permissions.Attributes
{
    public sealed class RequirePermissionAttribute : PermissionBaseAttribute
    {
        public RequirePermissionAttribute(ApplicationManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_001_060 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_061_120 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_121_180 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_181_240 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_241_300 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_301_360 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_361_420 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_421_480 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_481_540 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_541_600 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(DatabaseServerManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(DisplayManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(EventManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(GeneralPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(GridManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(GroupManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(HardwareManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(IODeviceManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(JoystickManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(LanguageManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(LogManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(MapManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(NetworkManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(PasswordManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(PermissionManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(SequenceManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(SerialDeviceManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(ServerManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(SettingsManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(TemplateManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(UserManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(WindowManagementPermissions permission) : base(permission) { }

        public override string ToString()
        {
            var permissionNames = GetPermissionNames();
            return $"Required permission: {PermissionGroup.Name} ({String.Join(", ", permissionNames)})";
        }
    }
}
