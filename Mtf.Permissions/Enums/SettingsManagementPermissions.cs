using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum SettingsManagementPermissions : long
    {
        None = 0,
        SelectPersonal = 0x1,
        CreatePersonal = 0x2,
        UpdatePersonal = 0x4,
        DeletePersonal = 0x8,
        PersonalSettingsManagement = SelectPersonal | CreatePersonal | UpdatePersonal | DeletePersonal,

        SelectStatic = 0x10,
        CreateStatic = 0x20,
        UpdateStatic = 0x40,
        DeleteStatic = 0x80,
        StaticSettingsManagement = SelectStatic | CreateStatic | UpdateStatic | DeleteStatic,

        FullControl = PersonalSettingsManagement | StaticSettingsManagement
    }
}
