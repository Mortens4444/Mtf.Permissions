using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_201_210 : long
    {
        None = 0,
        Camera_201 = 0x1,
        Camera_202 = 0x2,
        Camera_203 = 0x4,
        Camera_204 = 0x8,
        Camera_205 = 0x10,
        Camera_206 = 0x20,
        Camera_207 = 0x40,
        Camera_208 = 0x80,
        Camera_209 = 0x100,
        Camera_210 = 0x200,
        FullControl = Camera_201 | Camera_202 | Camera_203 | Camera_204 | Camera_205 | Camera_206 | Camera_207 | Camera_208 | Camera_209 | Camera_210
    }
}
