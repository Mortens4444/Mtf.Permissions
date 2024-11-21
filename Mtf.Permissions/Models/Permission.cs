using Mtf.Permissions.Enums;
using System;

namespace Mtf.Permissions.Models
{
    public class Permission
    {
        public int Id { get; set; }

        public PermissionType PermissionType { get; set; }

        public string Name { get; set; } = String.Empty;

        public bool IsAllowed { get; set; } = true;
    }
}
