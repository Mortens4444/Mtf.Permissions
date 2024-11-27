using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_181_190 : long
    {
        None = 0,
        Camera_181 = 0x1,
        Camera_182 = 0x2,
        Camera_183 = 0x4,
        Camera_184 = 0x8,
        Camera_185 = 0x10,
        Camera_186 = 0x20,
        Camera_187 = 0x40,
        Camera_188 = 0x80,
        Camera_189 = 0x100,
        Camera_190 = 0x200,
        FullControl = Camera_181 | Camera_182 | Camera_183 | Camera_184 | Camera_185 | Camera_186 | Camera_187 | Camera_188 | Camera_189 | Camera_190
    }
}
