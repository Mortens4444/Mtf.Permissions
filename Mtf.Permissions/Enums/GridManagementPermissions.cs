using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum GridManagementPermissions : long
    {
        None = 0,
        Select = 0x1,
        Create = 0x2,
        Update = 0x4,
        Delete = 0x8,
        Navigate = 0x10,
        Rearrange = 0x20,
        FullControl = Select | Create | Update | Delete | Navigate | Rearrange
    }
}
