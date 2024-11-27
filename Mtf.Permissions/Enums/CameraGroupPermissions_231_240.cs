using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_231_240 : long
    {
        None = 0,
        Camera_231 = 0x1,
        Camera_232 = 0x2,
        Camera_233 = 0x4,
        Camera_234 = 0x8,
        Camera_235 = 0x10,
        Camera_236 = 0x20,
        Camera_237 = 0x40,
        Camera_238 = 0x80,
        Camera_239 = 0x100,
        Camera_240 = 0x200,
        FullControl = Camera_231 | Camera_232 | Camera_233 | Camera_234 | Camera_235 | Camera_236 | Camera_237 | Camera_238 | Camera_239 | Camera_240
    }
}
