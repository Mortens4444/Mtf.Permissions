using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_021_030 : long
    {
        None = 0,
        Camera_021 = 0x1,
        Camera_022 = 0x2,
        Camera_023 = 0x4,
        Camera_024 = 0x8,
        Camera_025 = 0x10,
        Camera_026 = 0x20,
        Camera_027 = 0x40,
        Camera_028 = 0x80,
        Camera_029 = 0x100,
        Camera_030 = 0x200,
        FullControl = Camera_021 | Camera_022 | Camera_023 | Camera_024 | Camera_025 | Camera_026 | Camera_027 | Camera_028 | Camera_029 | Camera_030
    }
}
