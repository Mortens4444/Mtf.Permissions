using Mtf.Permissions.Enums;
using System;

namespace Mtf.Permissions.Attributes
{
    public sealed class RequireAnyPermissionAttribute : PermissionBaseAttribute
    {
        public RequireAnyPermissionAttribute(ApplicationManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_001_060 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_061_120 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_121_180 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_181_240 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_241_300 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_301_360 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_361_420 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_421_480 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_481_540 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_541_600 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(DatabaseServerManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(DisplayManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(EventManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(GeneralPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(GridManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(GroupManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(HardwareManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(IODeviceManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(JoystickManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(LanguageManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(LogManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(MapManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(NetworkManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(PasswordManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(PermissionManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(SequenceManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(SerialDeviceManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(ServerManagementPermissions permission) : base(permission) { }
        
        public RequireAnyPermissionAttribute(SettingsManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(TemplateManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(UserManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(WindowManagementPermissions permission) : base(permission) { }

        public override string ToString()
        {
            var permissionNames = GetPermissionNames();
            return $"Require one of the following permissions: {PermissionGroup.Name} ({String.Join(", ", permissionNames)})";
        }
    }
}
