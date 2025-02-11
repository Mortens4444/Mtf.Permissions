using Mtf.Permissions.Enums;
using System;

namespace Mtf.Permissions.Attributes
{
    public sealed class RequirePermissionAttribute : PermissionBaseAttribute
    {
        public RequirePermissionAttribute(ApplicationManagementPermissions permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_001_010 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_011_020 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_021_030 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_031_040 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_041_050 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_051_060 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_061_070 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_071_080 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_081_090 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_091_100 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_101_110 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_111_120 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_121_130 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_131_140 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_141_150 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_151_160 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_161_170 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_171_180 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_181_190 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_191_200 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_201_210 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_211_220 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_221_230 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_231_240 permission) : base(permission) { }

        public RequirePermissionAttribute(CameraGroupPermissions_241_250 permission) : base(permission) { }

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
