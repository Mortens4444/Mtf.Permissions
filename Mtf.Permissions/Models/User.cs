using Mtf.Permissions.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Mtf.Permissions.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; } = String.Empty;

        public Name BornName { get; set; }

        public Name FullName { get; set; }

        public DateTime BirthDate { get; set; } = DateTime.MinValue;

        public DateTime LastLogon { get; set; } = DateTime.MinValue;

        public List<Group> Groups { get; set; } = new List<Group>();

        public List<Image> Images { get; set; } = new List<Image>();

        public List<Permission> IndividualPermissions { get; set; } = new List<Permission>();

        public List<Permission> RevokedPermissions => IndividualPermissions.Where(permission => !permission.IsAllowed).ToList();

        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public bool HasPermission(PermissionType requiredPermissions)
        {
            var revokedPermissions = IndividualPermissions
                .Where(p => !p.IsAllowed)
                .Select(p => p.PermissionType)
                .Aggregate(PermissionType.None, (current, permission) => current | permission);

            if ((revokedPermissions & requiredPermissions) != PermissionType.None)
            {
                return false;
            }

            var allowedPermissions = IndividualPermissions
                .Where(p => p.IsAllowed)
                .Select(p => p.PermissionType)
                .Aggregate(PermissionType.None, (current, permission) => current | permission);

            foreach (var group in Groups)
            {
                allowedPermissions |= group.GetAllowedPermissions();
            }

            return (allowedPermissions & requiredPermissions) == requiredPermissions;
        }

        public override string ToString()
        {
            return Username;
        }
    }
}
