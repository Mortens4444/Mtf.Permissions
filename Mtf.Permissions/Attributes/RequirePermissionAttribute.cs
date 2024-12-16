using Mtf.Permissions.Enums;
using System;
using System.Linq;

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

        public RequirePermissionAttribute(CameraGroupPermissions_001_010 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_001_010);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_011_020 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_011_020);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_021_030 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_021_030);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_031_040 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_031_040);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_041_050 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_041_050);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_051_060 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_051_060);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_061_070 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_061_070);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_071_080 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_071_080);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_081_090 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_081_090);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_091_100 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_091_100);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_101_110 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_101_110);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_111_120 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_111_120);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_121_130 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_121_130);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_131_140 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_131_140);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_141_150 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_141_150);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_151_160 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_151_160);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_161_170 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_161_170);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_171_180 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_171_180);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_181_190 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_181_190);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_191_200 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_191_200);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_201_210 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_201_210);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_211_220 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_211_220);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_221_230 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_221_230);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_231_240 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_231_240);
        }

        public RequirePermissionAttribute(CameraGroupPermissions_241_250 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_241_250);
        }

        public RequirePermissionAttribute(CameraManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraManagementPermissions);
        }

        public RequirePermissionAttribute(DatabaseServerManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(DatabaseServerManagementPermissions);
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

        public RequirePermissionAttribute(HardwareManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(HardwareManagementPermissions);
        }

        public RequirePermissionAttribute(IODeviceManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(IODeviceManagementPermissions);
        }

        public RequirePermissionAttribute(JoystickManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(JoystickManagementPermissions);
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

        public RequirePermissionAttribute(NetworkManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(NetworkManagementPermissions);
        }

        public RequirePermissionAttribute(PasswordManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(PasswordManagementPermissions);
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
            var permissionNames = Enum.GetValues(PermissionGroup)
                .Cast<Enum>()
                .Where(value => (PermissionValue & Convert.ToInt64(value)) != 0)
                .Select(value => value.ToString());
            return $"Required permission: {PermissionGroup.Name} ({String.Join(", ", permissionNames)})";
        }
    }
}
