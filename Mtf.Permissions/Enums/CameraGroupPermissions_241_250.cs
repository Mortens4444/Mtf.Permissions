using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_241_250 : long
    {
        None = 0,
        Camera_241 = 0x1,
        Camera_242 = 0x2,
        Camera_243 = 0x4,
        Camera_244 = 0x8,
        Camera_245 = 0x10,
        Camera_246 = 0x20,
        Camera_247 = 0x40,
        Camera_248 = 0x80,
        Camera_249 = 0x100,
        Camera_250 = 0x200,
        FullControl = Camera_241 | Camera_242 | Camera_243 | Camera_244 | Camera_245 | Camera_246 | Camera_247 | Camera_248 | Camera_249 | Camera_250
    }
}
