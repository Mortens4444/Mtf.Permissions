using Mtf.Permissions.Attributes;
using System;
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

        public object Tag { get; set; }

        public bool HasPermissions(RequirePermissionAttribute requirePermissionAttribute)
        {
            if (requirePermissionAttribute == null)
            {
                throw new ArgumentNullException(nameof(requirePermissionAttribute));
            }

            var requiredPermissionValue = requirePermissionAttribute.PermissionValue;

            var groupPermissions = Permissions
                .Where(p => p.IsAllowed && p.PermissionGroup == requirePermissionAttribute.PermissionGroup)
                .Select(p => p.PermissionValue)
                .Aggregate(0L, (current, permission) => current | permission);

            return (groupPermissions & requiredPermissionValue) == requiredPermissionValue;
        }

        public long GetAllowedPermissions(Type permissionGroup)
        {
            return Permissions
                .Where(p => p.IsAllowed && p.PermissionGroup == permissionGroup)
                .Select(p => p.PermissionValue)
                .Aggregate(0L, (current, permission) => current | permission);
        }
    }
}
