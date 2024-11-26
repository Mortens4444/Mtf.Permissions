using System;

namespace Mtf.Permissions.Models
{
    public class Permission
    {
        public int Id { get; set; }

        public Type PermissionGroup { get; set; }

        public long PermissionValue { get; set; }

        public string Name { get; set; } = String.Empty;

        public bool IsAllowed { get; set; } = true;
    }
}
