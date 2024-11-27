using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_121_130 : long
    {
        None = 0,
        Camera_121 = 0x1,
        Camera_122 = 0x2,
        Camera_123 = 0x4,
        Camera_124 = 0x8,
        Camera_125 = 0x10,
        Camera_126 = 0x20,
        Camera_127 = 0x40,
        Camera_128 = 0x80,
        Camera_129 = 0x100,
        Camera_130 = 0x200,
        FullControl = Camera_121 | Camera_122 | Camera_123 | Camera_124 | Camera_125 | Camera_126 | Camera_127 | Camera_128 | Camera_129 | Camera_130
    }
}
