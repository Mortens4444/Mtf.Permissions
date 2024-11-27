using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum NetworkManagementPermissions : long
    {
        None = 0,
        Select = 0x1,
        Create = 0x2,
        Update = 0x4,
        Delete = 0x8,
        WakeOnLAN = 0x10,
        FullControl = Select | Create | Update | Delete | WakeOnLAN
    }
}
