using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum LogManagementPermissions : long
    {
        None = 0,
        Select = 0x1,
        Delete = 0x2,
        FullControl = Select | Delete
    }
}
