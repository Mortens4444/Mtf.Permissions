using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum JoystickManagementPermissions : long
    {
        None = 0,
        Select = 0x1,
        Create = 0x2,
        Update = 0x4,
        Delete = 0x8,
        Calibrate = 0x10,
        FullControl = Select | Create | Update | Delete | Calibrate
    }
}
