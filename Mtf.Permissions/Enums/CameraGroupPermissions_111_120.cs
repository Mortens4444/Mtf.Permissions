using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_111_120 : long
    {
        None = 0,
        Camera_111 = 0x1,
        Camera_112 = 0x2,
        Camera_113 = 0x4,
        Camera_114 = 0x8,
        Camera_115 = 0x10,
        Camera_116 = 0x20,
        Camera_117 = 0x40,
        Camera_118 = 0x80,
        Camera_119 = 0x100,
        Camera_120 = 0x200,
        FullControl = Camera_111 | Camera_112 | Camera_113 | Camera_114 | Camera_115 | Camera_116 | Camera_117 | Camera_118 | Camera_119 | Camera_120
    }
}
