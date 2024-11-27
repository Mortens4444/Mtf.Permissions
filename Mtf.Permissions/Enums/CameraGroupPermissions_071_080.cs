using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_071_080 : long
    {
        None = 0,
        Camera_071 = 0x1,
        Camera_072 = 0x2,
        Camera_073 = 0x4,
        Camera_074 = 0x8,
        Camera_075 = 0x10,
        Camera_076 = 0x20,
        Camera_077 = 0x40,
        Camera_078 = 0x80,
        Camera_079 = 0x100,
        Camera_080 = 0x200,
        FullControl = Camera_071 | Camera_072 | Camera_073 | Camera_074 | Camera_075 | Camera_076 | Camera_077 | Camera_078 | Camera_079 | Camera_080
    }
}
