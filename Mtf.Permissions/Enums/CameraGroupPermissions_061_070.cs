using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_061_070 : long
    {
        None = 0,
        Camera_061 = 0x1,
        Camera_062 = 0x2,
        Camera_063 = 0x4,
        Camera_064 = 0x8,
        Camera_065 = 0x10,
        Camera_066 = 0x20,
        Camera_067 = 0x40,
        Camera_068 = 0x80,
        Camera_069 = 0x100,
        Camera_070 = 0x200,
        FullControl = Camera_061 | Camera_062 | Camera_063 | Camera_064 | Camera_065 | Camera_066 | Camera_067 | Camera_068 | Camera_069 | Camera_070
    }
}
