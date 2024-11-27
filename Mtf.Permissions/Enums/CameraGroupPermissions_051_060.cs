using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_051_060 : long
    {
        None = 0,
        Camera_051 = 0x1,
        Camera_052 = 0x2,
        Camera_053 = 0x4,
        Camera_054 = 0x8,
        Camera_055 = 0x10,
        Camera_056 = 0x20,
        Camera_057 = 0x40,
        Camera_058 = 0x80,
        Camera_059 = 0x100,
        Camera_060 = 0x200,
        FullControl = Camera_051 | Camera_052 | Camera_053 | Camera_054 | Camera_055 | Camera_056 | Camera_057 | Camera_058 | Camera_059 | Camera_060
    }
}
