﻿using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum ApplicationManagementPermissions : long
    {
        None = 0,
        Start = 0x1,
        Restart = 0x2,
        Exit = 0x4,
        FullControl = Start | Restart | Exit
    }
}