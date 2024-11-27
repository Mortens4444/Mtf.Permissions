using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_161_170 : long
    {
        None = 0,
        Camera_161 = 0x1,
        Camera_162 = 0x2,
        Camera_163 = 0x4,
        Camera_164 = 0x8,
        Camera_165 = 0x10,
        Camera_166 = 0x20,
        Camera_167 = 0x40,
        Camera_168 = 0x80,
        Camera_169 = 0x100,
        Camera_170 = 0x200,
        FullControl = Camera_161 | Camera_162 | Camera_163 | Camera_164 | Camera_165 | Camera_166 | Camera_167 | Camera_168 | Camera_169 | Camera_170
    }
}
