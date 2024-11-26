# **Mtf.Permissions Library Documentation**

## **Overview**

The `Mtf.Permissions` library simplifies permission management in .NET applications by providing tools to define, enforce, and apply permissions to UI controls and methods. It ensures secure access control based on user roles and permissions.

---

## **Installation**

1. **Add the Package**:  
   Install the library using the following command:
   ```bash
   dotnet add package Mtf.Permissions
   ```

2. **Include the Namespace**:  
   Add the necessary namespace:
   ```csharp
   using Mtf.Permissions;
   ```

---

## **Core Components**

### **1. Class: `PermissionManager`**

The `PermissionManager` class provides methods to manage permissions dynamically and validate user access to specific methods or UI components.

#### **Properties**
| Property         | Type    | Description                                      |
|------------------|---------|--------------------------------------------------|
| `currentUser`    | `User`  | Represents the currently logged-in user.         |

#### **Methods**
| Method                                          | Description                                                                                             |
|-------------------------------------------------|---------------------------------------------------------------------------------------------------------|
| `SetUser(Form form, User currentUser)`          | Assigns the current user and applies permissions to the specified form and its controls.                |
| `ApplyPermissionsOnControls(Form form)`         | Iterates through all controls in the form to enable or disable them based on the user's permissions.    |
| `EnsurePermissions()`                           | Verifies if the current user has the required permissions for the calling method, throwing an exception if not. |
| `SetEnabledProperty(Form form, Control control)`| Dynamically enables or disables controls based on permissions tied to the `Tag` property.               |

#### **Example Usage**
```csharp
var permissionManager = new PermissionManager();
permissionManager.SetUser(mainForm, currentUser);
permissionManager.ApplyPermissionsOnControls(mainForm);
```

---

### **2. Attribute: `RequirePermissionAttribute`**

Annotates methods that require specific permissions.

The `RequirePermission` attribute can be instantiated with one of the following enum values:
`ApplicationManagementPermissions`, `CameraManagementPermissions`, `DisplayManagementPermissions`, `EventManagementPermissions`, `GeneralPermissions`,
`GridManagementPermissions`, `GroupManagementPermissions`, `IODeviceManagementPermissions`, `LanguageManagementPermissions`, `LogManagementPermissions`,
`MapManagementPermissions`, `PermissionManagementPermissions`, `SequenceManagementPermissions`, `SerialDeviceManagementPermissions`,
`ServerManagementPermissions`, `SettingsManagementPermissions`, `TemplateManagementPermissions`, `UserManagementPermissions`, `WindowManagementPermissions`

#### **Properties**
| Property          | Type   | Description                                                    |
|-------------------|--------|----------------------------------------------------------------|
| `PermissionValue` | `long` | Defines the value of permission required to access the method. |
| `PermissionGroup` | `Type` | Defines the type of permission required to access the method.  |

#### **Example Usage**
```csharp
[RequirePermission(ApplicationManagementPermissions.Exit)]
private void ExitApplication()
{
    Environment.Exit(0);
}
```

---

### **3. Class: `User`**

Represents a system user and their associated permissions.

#### **Properties**
| Property               | Type                | Description                              |
|------------------------|---------------------|------------------------------------------|
| `Username`             | `string`           | The username of the user.                |
| `IndividualPermissions`| `List<Permission>` | List of permissions directly assigned to the user. |
| `Groups`               | `List<Group>`      | Groups the user belongs to, inheriting their permissions. |

---

### **4. Class: `Permission`**

Defines a specific permission that can be assigned to users or groups.

#### **Properties**
| Property         | Type             | Description                              |
|------------------|------------------|------------------------------------------|
| `PermissionType` | `PermissionType` | The specific type of permission.         |

---

### **5. Enum: `PermissionType`**

An enumeration defining various permission types for your application. Extend this enum to add custom permission types.

---

## **Example Application**

### **Scenario**
A Windows Forms application with three user roles: *Guest*, *Member*, and *Admin*, each having varying levels of access to UI controls and functionality.

#### **Code Example: MainForm**
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
        var guest = new User() { Username = "Guest", IndividualPermissions = [] };
        var member = new User() { Username = "Group member", Groups = [new Group { Permissions = [new Permission { PermissionGroup = typeof(GeneralPermissions), PermissionValue = (long)GeneralPermissions.View}] }] };
        var admin = new User()
        {
            Username = "Admin",
            IndividualPermissions =
            [
                new Permission { PermissionGroup = typeof(GeneralPermissions), PermissionValue = (long)GeneralPermissions.View },
                new Permission { PermissionGroup = typeof(GeneralPermissions), PermissionValue = (long)GeneralPermissions.Edit }
            ]
        };
		
        // Assign current user
        currentUser = admin;

        // Assign permissions to controls via the Tag property
        editButton.Tag = nameof(EditAction);
        viewButton.Tag = nameof(ViewAction);

        // Apply permissions
        permissionManager.SetUser(this, currentUser);
    }

    [RequirePermission(GeneralPermissions.Edit)]
    private void EditAction()
    {
        permissionManager.EnsurePermissions();
        MessageBox.Show("Edit action executed.");
    }

    [RequirePermission(GeneralPermissions.View)]
    private void ViewAction()
    {
        permissionManager.EnsurePermissions();
        MessageBox.Show("View action executed.");
    }
}
```

---

## **Dynamic Permissions for UI Components**

1. **Controls (`Control.Tag`)**  
   Assign method names to the `Tag` property of controls. These methods must be decorated with `[RequirePermission]`.

2. **Menu Items**  
   Use `ToolStripItem.Tag` for menu items. The library dynamically enables or disables them based on the user's permissions.

3. **Example: Dynamic ToolStrip Menu**
```csharp
fileMenuItem.Tag = nameof(OpenFile);
settingsMenuItem.Tag = nameof(ConfigureSettings);

[RequirePermission(PermissionType.View)]
private void OpenFile() { /* Logic */ }

[RequirePermission(PermissionType.Admin)]
private void ConfigureSettings() { /* Logic */ }
```

---

## **Error Handling**

- **Permission Validation**:  
  Use `EnsurePermissions()` to validate user permissions for critical operations. If the user lacks the necessary permissions, an `UnauthorizedAccessException` is thrown.
  
  ```csharp
  permissionManager.EnsurePermissions();
  ```

- **Null Checks**:  
  Ensure all methods handle null inputs gracefully (e.g., `ArgumentNullException`).

---

## **Best Practices**

1. **Use `RequirePermissionAttribute`**:  
   Clearly define required permissions for all restricted methods.

2. **Leverage Groups**:  
   Organize permissions hierarchically using groups for better scalability.

3. **Control Tags**:  
   Ensure all UI controls have meaningful `Tag` values pointing to their associated methods.

4. **Caching**:  
   Cache user permissions for large applications to optimize performance.
