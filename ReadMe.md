# Mtf.Permissions Library Documentation

## Overview

The `Mtf.Permissions` library provides functionality for managing user permissions in applications. It includes tools for defining, checking, and applying permissions on methods and UI controls. This document explains installation, main classes, attributes, and usage examples to integrate permissions management into your .NET applications.

## Installation

To use `Mtf.Permissions`, add the package to your project:

1. **Add Package**:  
   Run the following command in your project directory:
   ```bash
   dotnet add package Mtf.Permissions
   ```

2. **Include the Namespace**:  
   Add the following namespace at the beginning of your code:
   ```csharp
   using Mtf.Permissions;
   ```

---

## Key Components

### Class: `PermissionManager`

The `PermissionManager` class provides methods for applying permissions to UI controls and verifying user access to specific methods.

#### Properties

| Property           | Type   | Description                                        |
|--------------------|--------|----------------------------------------------------|
| `currentUser`      | `User` | Represents the current user and their permissions. |

#### Methods

| Method                                          | Description                                                                                             |
|-------------------------------------------------|---------------------------------------------------------------------------------------------------------|
| `SetUser(Control container, User currentUser)`  | Sets the current user and applies their permissions to all controls in the specified container.         |
| `ApplyPermissionsOnControls(Control container)` | Iterates through the container's controls and enables or disables them based on the user's permissions. |
| `EnsurePermissions()`                           | Ensures the current user has permission to execute the calling method. Throws an exception if permission is denied. |

#### Example Usage
```csharp
var permissionManager = new PermissionManager();
permissionManager.SetUser(mainForm, currentUser);
permissionManager.ApplyPermissionsOnControls(mainForm);
```

---

### Attribute: `RequirePermissionAttribute`

The `RequirePermissionAttribute` is used to annotate methods that require specific permissions.

#### Properties

| Property          | Type                | Description                         |
|-------------------|---------------------|-------------------------------------|
| `PermissionType`  | `PermissionType`    | The type of permission required.    |

#### Example Usage
```csharp
[RequirePermission(PermissionType.Admin)]
private void PerformAdminAction()
{
    // Method logic here
}
```

---

### Class: `User`

The `User` class represents a system user and their permissions.

#### Properties

| Property               | Type               | Description                                                              |
|------------------------|--------------------|--------------------------------------------------------------------------|
| `Username`             | `string`           | The username of the user.                                                |
| `IndividualPermissions`| `List<Permission>` | A list of permissions assigned directly to the user.                     |
| `Groups`               | `List<Group>`      | A list of groups the user belongs to, each group containing permissions. |

---

### Class: `Permission`

The `Permission` class defines a specific type of permission.

#### Properties

| Property          | Type                | Description                         |
|-------------------|---------------------|-------------------------------------|
| `PermissionType`  | `PermissionType`    | The type of permission.             |

---

### Enum: `PermissionType`

Defines various permission types used in the application.

---

## Example Application

### Scenario
A Windows Forms application where users (Guest, Member, Admin) have different levels of access to UI controls and functionality.

#### MainForm Code Example
```csharp
public partial class MainForm : Form
{
    private PermissionManager permissionManager;
    private User currentUser;

    public MainForm()
    {
        InitializeComponent();
        permissionManager = new PermissionManager();

        // Define users and their permissions
        var guest = new User { Username = "Guest", IndividualPermissions = new() };
		var member = new User { Username = "Group member", Groups = [ new Group { Permissions = [new Permission { PermissionType = PermissionType.Admin }] } ] };
        var admin = new User { Username = "Admin", IndividualPermissions = new() { new Permission { PermissionType = PermissionType.Admin } } };

        // Assign control tags for permissions
        someButton.Tag = "PerformAdminAction";

        // Apply permissions based on current user
        permissionManager.SetUser(this, admin);
    }

    [RequirePermission(PermissionType.Admin)]
    private void PerformAdminAction()
    {
        // Admin-only action
        MessageBox.Show("Admin action performed.");
    }
}
```

#### Example Flow
1. Assign user permissions during initialization.
2. Attach the `Tag` property of controls to the relevant method names.
3. Use the `RequirePermission` attribute to restrict access to specific methods.
4. Dynamically enable/disable controls and validate permissions using `PermissionManager`.

---

## Notes

- **Error Handling**: Ensure to handle exceptions like `UnauthorizedAccessException` or `InvalidOperationException` for better user feedback.
- **Flexibility**: Extend `PermissionType` and `Permission` classes as needed to support custom permission logic.
- **Optimization**: For large UI forms, consider caching the permission results to improve performance.

--- 

For additional questions or contributions, refer to the package repository.