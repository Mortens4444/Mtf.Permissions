using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_101_110 : long
    {
        None = 0,
        Camera_101 = 0x1,
        Camera_102 = 0x2,
        Camera_103 = 0x4,
        Camera_104 = 0x8,
        Camera_105 = 0x10,
        Camera_106 = 0x20,
        Camera_107 = 0x40,
        Camera_108 = 0x80,
        Camera_109 = 0x100,
        Camera_110 = 0x200,
        FullControl = Camera_101 | Camera_102 | Camera_103 | Camera_104 | Camera_105 | Camera_106 | Camera_107 | Camera_108 | Camera_109 | Camera_110
    }
}
