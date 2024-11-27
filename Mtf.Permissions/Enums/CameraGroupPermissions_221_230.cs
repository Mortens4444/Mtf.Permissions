using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_221_230 : long
    {
        None = 0,
        Camera_221 = 0x1,
        Camera_222 = 0x2,
        Camera_223 = 0x4,
        Camera_224 = 0x8,
        Camera_225 = 0x10,
        Camera_226 = 0x20,
        Camera_227 = 0x40,
        Camera_228 = 0x80,
        Camera_229 = 0x100,
        Camera_230 = 0x200,
        FullControl = Camera_221 | Camera_222 | Camera_223 | Camera_224 | Camera_225 | Camera_226 | Camera_227 | Camera_228 | Camera_229 | Camera_230
    }
}
