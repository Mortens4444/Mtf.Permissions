using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_141_150 : long
    {
        None = 0,
        Camera_141 = 0x1,
        Camera_142 = 0x2,
        Camera_143 = 0x4,
        Camera_144 = 0x8,
        Camera_145 = 0x10,
        Camera_146 = 0x20,
        Camera_147 = 0x40,
        Camera_148 = 0x80,
        Camera_149 = 0x100,
        Camera_150 = 0x200,
        FullControl = Camera_141 | Camera_142 | Camera_143 | Camera_144 | Camera_145 | Camera_146 | Camera_147 | Camera_148 | Camera_149 | Camera_150
    }
}
