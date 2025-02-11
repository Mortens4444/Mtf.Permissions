using Mtf.Permissions.Enums;
using System;

namespace Mtf.Permissions.Attributes
{
    public sealed class RequireAnyPermissionAttribute : PermissionBaseAttribute
    {
        public RequireAnyPermissionAttribute(ApplicationManagementPermissions permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_001_010 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_011_020 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_021_030 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_031_040 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_041_050 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_051_060 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_061_070 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_071_080 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_081_090 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_091_100 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_101_110 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_111_120 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_121_130 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_131_140 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_141_150 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_151_160 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_161_170 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_171_180 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_181_190 permission) : base(permission) { }
        
        public RequireAnyPermissionAttribute(CameraGroupPermissions_191_200 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_201_210 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_211_220 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_221_230 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_231_240 permission) : base(permission) { }

        public RequireAnyPermissionAttribute(CameraGroupPermissions_241_250 permission) : base(permission) { }

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
