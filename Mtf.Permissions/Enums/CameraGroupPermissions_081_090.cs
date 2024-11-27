using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_081_090 : long
    {
        None = 0,
        Camera_081 = 0x1,
        Camera_082 = 0x2,
        Camera_083 = 0x4,
        Camera_084 = 0x8,
        Camera_085 = 0x10,
        Camera_086 = 0x20,
        Camera_087 = 0x40,
        Camera_088 = 0x80,
        Camera_089 = 0x100,
        Camera_090 = 0x200,
        FullControl = Camera_081 | Camera_082 | Camera_083 | Camera_084 | Camera_085 | Camera_086 | Camera_087 | Camera_088 | Camera_089 | Camera_090
    }
}
