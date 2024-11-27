using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_041_050 : long
    {
        None = 0,
        Camera_041 = 0x1,
        Camera_042 = 0x2,
        Camera_043 = 0x4,
        Camera_044 = 0x8,
        Camera_045 = 0x10,
        Camera_046 = 0x20,
        Camera_047 = 0x40,
        Camera_048 = 0x80,
        Camera_049 = 0x100,
        Camera_050 = 0x200,
        FullControl = Camera_041 | Camera_042 | Camera_043 | Camera_044 | Camera_045 | Camera_046 | Camera_047 | Camera_048 | Camera_049 | Camera_050
    }
}
