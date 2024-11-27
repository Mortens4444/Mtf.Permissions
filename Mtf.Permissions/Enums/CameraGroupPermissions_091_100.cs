using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_091_100 : long
    {
        None = 0,
        Camera_091 = 0x1,
        Camera_092 = 0x2,
        Camera_093 = 0x4,
        Camera_094 = 0x8,
        Camera_095 = 0x10,
        Camera_096 = 0x20,
        Camera_097 = 0x40,
        Camera_098 = 0x80,
        Camera_099 = 0x100,
        Camera_100 = 0x200,
        FullControl = Camera_091 | Camera_092 | Camera_093 | Camera_094 | Camera_095 | Camera_096 | Camera_097 | Camera_098 | Camera_099 | Camera_100
    }
}
