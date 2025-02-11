using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum UserManagementPermissions : long
    {
        None = 0,
        Select = 0x1,
        Create = 0x2,
        Update = 0x4,
        Delete = 0x8,
        Login = 0x10,
        Logout = 0x20,
        AutoLogin = 0x40,
        FullControl = Select | Create | Update | Delete | Login | Logout | AutoLogin
    }
}
