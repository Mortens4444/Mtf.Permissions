using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_031_040 : long
    {
        None = 0,
        Camera_031 = 0x1,
        Camera_032 = 0x2,
        Camera_033 = 0x4,
        Camera_034 = 0x8,
        Camera_035 = 0x10,
        Camera_036 = 0x20,
        Camera_037 = 0x40,
        Camera_038 = 0x80,
        Camera_039 = 0x100,
        Camera_040 = 0x200,
        FullControl = Camera_031 | Camera_032 | Camera_033 | Camera_034 | Camera_035 | Camera_036 | Camera_037 | Camera_038 | Camera_039 | Camera_040
    }
}
