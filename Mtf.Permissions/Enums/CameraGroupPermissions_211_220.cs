using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_211_220 : long
    {
        None = 0,
        Camera_211 = 0x1,
        Camera_212 = 0x2,
        Camera_213 = 0x4,
        Camera_214 = 0x8,
        Camera_215 = 0x10,
        Camera_216 = 0x20,
        Camera_217 = 0x40,
        Camera_218 = 0x80,
        Camera_219 = 0x100,
        Camera_220 = 0x200,
        FullControl = Camera_211 | Camera_212 | Camera_213 | Camera_214 | Camera_215 | Camera_216 | Camera_217 | Camera_218 | Camera_219 | Camera_220
    }
}
