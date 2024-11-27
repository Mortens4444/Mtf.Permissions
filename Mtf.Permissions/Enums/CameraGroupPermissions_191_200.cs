using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_191_200 : long
    {
        None = 0,
        Camera_191 = 0x1,
        Camera_192 = 0x2,
        Camera_193 = 0x4,
        Camera_194 = 0x8,
        Camera_195 = 0x10,
        Camera_196 = 0x20,
        Camera_197 = 0x40,
        Camera_198 = 0x80,
        Camera_199 = 0x100,
        Camera_200 = 0x200,
        FullControl = Camera_191 | Camera_192 | Camera_193 | Camera_194 | Camera_195 | Camera_196 | Camera_197 | Camera_198 | Camera_199 | Camera_200
    }
}
