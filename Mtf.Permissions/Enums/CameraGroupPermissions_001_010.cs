using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_001_010 : long
    {
        None = 0,
        Camera_001 = 0x1,
        Camera_002 = 0x2,
        Camera_003 = 0x4,
        Camera_004 = 0x8,
        Camera_005 = 0x10,
        Camera_006 = 0x20,
        Camera_007 = 0x40,
        Camera_008 = 0x80,
        Camera_009 = 0x100,
        Camera_010 = 0x200,
        FullControl = Camera_001 | Camera_002 | Camera_003 | Camera_004 | Camera_005 | Camera_006 | Camera_007 | Camera_008 | Camera_009 | Camera_010
    }
}
