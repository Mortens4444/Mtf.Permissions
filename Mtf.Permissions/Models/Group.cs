using Mtf.Permissions.Enums;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Mtf.Permissions.Models
{
    public class Group
    {
        public int Id { get; set; }

        public int ParentGroupId { get; set; }

        public string Name { get; set; }

        public List<Permission> Permissions { get; set; } = new List<Permission>();

        public List<Image> Images { get; set; } = new List<Image>();

        public bool HasPermissions(PermissionType requiredPermissions)
        {
            var groupPermissions = Permissions
                .Where(p => p.IsAllowed)
                .Select(p => p.PermissionType)
                .Aggregate(PermissionType.None, (current, permission) => current | permission);

            return (groupPermissions & requiredPermissions) == requiredPermissions;
        }

        public PermissionType GetAllowedPermissions()
        {
            return Permissions
                .Where(p => p.IsAllowed)
                .Select(p => p.PermissionType)
                .Aggregate(PermissionType.None, (current, permission) => current | permission);
        }
    }
}
