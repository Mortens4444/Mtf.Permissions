using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraGroupPermissions_171_180 : long
    {
        None = 0,
        Camera_171 = 0x1,
        Camera_172 = 0x2,
        Camera_173 = 0x4,
        Camera_174 = 0x8,
        Camera_175 = 0x10,
        Camera_176 = 0x20,
        Camera_177 = 0x40,
        Camera_178 = 0x80,
        Camera_179 = 0x100,
        Camera_180 = 0x200,
        FullControl = Camera_171 | Camera_172 | Camera_173 | Camera_174 | Camera_175 | Camera_176 | Camera_177 | Camera_178 | Camera_179 | Camera_180
    }
}
