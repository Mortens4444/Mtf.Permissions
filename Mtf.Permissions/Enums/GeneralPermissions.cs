using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum GeneralPermissions : long
    {
        None = 0,
        Create = 0x1,
        Select = 0x2,
        Update = 0x4,
        Delete = 0x8,
        Read = 0x10,
        View = 0x20,
        Edit = 0x40,
        Cut = 0x80,
        Copy = 0x100,
        Paste = 0x200,
        Exit = 0x400
    }
}
