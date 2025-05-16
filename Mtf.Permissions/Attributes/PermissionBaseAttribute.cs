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

        public PermissionBaseAttribute(CameraGroupPermissions_001_060 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_001_060);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_061_120 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_061_120);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_121_180 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_121_180);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_181_240 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_181_240);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_241_300 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_241_300);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_301_360 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_301_360);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_361_420 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_361_420);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_421_480 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_421_480);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_481_540 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_481_540);
        }

        public PermissionBaseAttribute(CameraGroupPermissions_541_600 permission)
        {
            PermissionValue = (long)permission;
            PermissionGroup = typeof(CameraGroupPermissions_541_600);
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
