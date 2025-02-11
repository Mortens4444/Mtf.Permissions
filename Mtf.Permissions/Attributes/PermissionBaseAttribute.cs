using Mtf.Permissions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mtf.Permissions.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class PermissionBaseAttribute : Attribute
    {
        public long PermissionValue { get; }

        public Type PermissionGroup { get; }

        public PermissionBaseAttribute(ApplicationManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(ApplicationManagementPermissions);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_001_010 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_001_010);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_011_020 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_011_020);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_021_030 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_021_030);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_031_040 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_031_040);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_041_050 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_041_050);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_051_060 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_051_060);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_061_070 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_061_070);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_071_080 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_071_080);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_081_090 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_081_090);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_091_100 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_091_100);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_101_110 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_101_110);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_111_120 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_111_120);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_121_130 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_121_130);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_131_140 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_131_140);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_141_150 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_141_150);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_151_160 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_151_160);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_161_170 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_161_170);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_171_180 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_171_180);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_181_190 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_181_190);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_191_200 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_191_200);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_201_210 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_201_210);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_211_220 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_211_220);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_221_230 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_221_230);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_231_240 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_231_240);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_241_250 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_241_250);
        }

        public PermissionBaseAttribute(CameraManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraManagementPermissions);
        }

        public PermissionBaseAttribute(DatabaseServerManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(DatabaseServerManagementPermissions);
        }

        public PermissionBaseAttribute(DisplayManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(DisplayManagementPermissions);
        }

        public PermissionBaseAttribute(EventManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(EventManagementPermissions);
        }

        public PermissionBaseAttribute(GeneralPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(GeneralPermissions);
        }

        public PermissionBaseAttribute(GridManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(GridManagementPermissions);
        }

        public PermissionBaseAttribute(GroupManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(GroupManagementPermissions);
        }

        public PermissionBaseAttribute(HardwareManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(HardwareManagementPermissions);
        }

        public PermissionBaseAttribute(IODeviceManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(IODeviceManagementPermissions);
        }

        public PermissionBaseAttribute(JoystickManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(JoystickManagementPermissions);
        }

        public PermissionBaseAttribute(LanguageManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(LanguageManagementPermissions);
        }

        public PermissionBaseAttribute(LogManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(LogManagementPermissions);
        }

        public PermissionBaseAttribute(MapManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(MapManagementPermissions);
        }

        public PermissionBaseAttribute(NetworkManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(NetworkManagementPermissions);
        }

        public PermissionBaseAttribute(PasswordManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(PasswordManagementPermissions);
        }

        public PermissionBaseAttribute(PermissionManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(PermissionManagementPermissions);
        }

        public PermissionBaseAttribute(SequenceManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(SequenceManagementPermissions);
        }

        public PermissionBaseAttribute(SerialDeviceManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(SerialDeviceManagementPermissions);
        }

        public PermissionBaseAttribute(ServerManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(ServerManagementPermissions);
        }

        public PermissionBaseAttribute(SettingsManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(SettingsManagementPermissions);
        }

        public PermissionBaseAttribute(TemplateManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(TemplateManagementPermissions);
        }

        public PermissionBaseAttribute(UserManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(UserManagementPermissions);
        }

        public PermissionBaseAttribute(WindowManagementPermissions permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(WindowManagementPermissions);
        }

        protected IEnumerable<string> GetPermissionNames()
        {
            return Enum.GetValues(PermissionGroup)
                .Cast<Enum>()
                .Where(value => (PermissionValue & Convert.ToInt64(value)) != 0)
                .Select(value => value.ToString());
        }
    }
}
