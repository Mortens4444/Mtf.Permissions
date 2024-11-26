using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum EventManagementPermissions : long
    {
        None = 0,
        Select = 0x1,
        Create = 0x2,
        Update = 0x4,
        Delete = 0x8,
        FullControl = Select | Create | Update | Delete
    }
}
