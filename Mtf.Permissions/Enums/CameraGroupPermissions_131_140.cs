using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_131_140 : long
    {
        None = 0,
        Camera_131 = 0x1,
        Camera_132 = 0x2,
        Camera_133 = 0x4,
        Camera_134 = 0x8,
        Camera_135 = 0x10,
        Camera_136 = 0x20,
        Camera_137 = 0x40,
        Camera_138 = 0x80,
        Camera_139 = 0x100,
        Camera_140 = 0x200,
        FullControl = Camera_131 | Camera_132 | Camera_133 | Camera_134 | Camera_135 | Camera_136 | Camera_137 | Camera_138 | Camera_139 | Camera_140
    }
}
