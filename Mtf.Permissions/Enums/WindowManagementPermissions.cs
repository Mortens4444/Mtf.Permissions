using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum WindowManagementPermissions : long
    {
        None = 0,
        Select = 0x1,
        Create = 0x2,
        Update = 0x4,
        Delete = 0x8,
        Open = 0x10,
        Close = 0x20,
        Move = 0x40,
        Resize = 0x80,
        Minimize = 0x100,
        Maximize = 0x200,
        FullControl = Select | Create | Update | Delete | Open | Close | Move | Resize | Minimize | Maximize
    }
}
