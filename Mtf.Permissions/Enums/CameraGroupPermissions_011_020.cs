using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_011_020 : long
    {
        None = 0,
        Camera_011 = 0x1,
        Camera_012 = 0x2,
        Camera_013 = 0x4,
        Camera_014 = 0x8,
        Camera_015 = 0x10,
        Camera_016 = 0x20,
        Camera_017 = 0x40,
        Camera_018 = 0x80,
        Camera_019 = 0x100,
        Camera_020 = 0x200,
        FullControl = Camera_011 | Camera_012 | Camera_013 | Camera_014 | Camera_015 | Camera_016 | Camera_017 | Camera_018 | Camera_019 | Camera_020
    }
}
