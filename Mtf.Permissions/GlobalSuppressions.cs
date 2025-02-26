﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "CA1002:Do not expose generic lists")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only")]
[assembly: SuppressMessage("Design", "CA1000:Do not declare static members on generic types")]
[assembly: SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "<Pending>", Scope = "type", Target = "~T:Mtf.Permissions.Models.Permission")]
[assembly: SuppressMessage("Maintainability", "CA1510:Use ArgumentNullException throw helper")]
[assembly: SuppressMessage("Design", "CA1019:Define accessors for attribute arguments", Justification = "<Pending>", Scope = "member", Target = "~M:Mtf.Permissions.Attributes.RequirePermissionAttribute.#ctor(Mtf.Permissions.Enums.ApplicationManagementPermissions)")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores")]
