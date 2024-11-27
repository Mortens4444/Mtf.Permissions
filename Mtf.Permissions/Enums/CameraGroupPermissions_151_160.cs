using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_151_160 : long
    {
        None = 0,
        Camera_151 = 0x1,
        Camera_152 = 0x2,
        Camera_153 = 0x4,
        Camera_154 = 0x8,
        Camera_155 = 0x10,
        Camera_156 = 0x20,
        Camera_157 = 0x40,
        Camera_158 = 0x80,
        Camera_159 = 0x100,
        Camera_160 = 0x200,
        FullControl = Camera_151 | Camera_152 | Camera_153 | Camera_154 | Camera_155 | Camera_156 | Camera_157 | Camera_158 | Camera_159 | Camera_160
    }
}
