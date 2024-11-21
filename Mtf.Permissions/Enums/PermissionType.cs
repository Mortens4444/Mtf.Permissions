using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum PermissionType : long
    {
        None = 0,

        // User Management
        SelectUser = 0x01,
        CreateUser = 0x02,
        UpdateUser = 0x04,
        DeleteUser = 0x08,
        UserManagement = SelectUser | CreateUser | UpdateUser | DeleteUser,

        // Group Management
        SelectGroup = 0x10,
        CreateGroup = 0x20,
        UpdateGroup = 0x40,
        DeleteGroup = 0x80,
        GroupManagement = SelectGroup | CreateGroup | UpdateGroup | DeleteGroup,

        UserAndGroupManagement = UserManagement | GroupManagement,

        // Server Management
        SelectServer = 0x100,
        CreateServer = 0x200,
        UpdateServer = 0x400,
        DeleteServer = 0x800,
        ServerManagement = SelectServer | CreateServer | UpdateServer | DeleteServer,

        // Camera Management
        SelectCamera = 0x1000,
        CreateCamera = 0x2000,
        UpdateCamera = 0x4000,
        DeleteCamera = 0x8000,
        CameraManagement = SelectCamera | CreateCamera | UpdateCamera | DeleteCamera,

        ServerAndCameraManagement = ServerManagement | CameraManagement,

        // Serial Device Management
        SelectSerialDevice = 0x10000,
        CreateSerialDevice = 0x20000,
        UpdateSerialDevice = 0x40000,
        DeleteSerialDevice = 0x80000,
        SerialDeviceManagement = SelectSerialDevice | CreateSerialDevice | UpdateSerialDevice | DeleteSerialDevice,

        // Grid Management
        SelectGrid = 0x100000,
        CreateGrid = 0x200000,
        UpdateGrid = 0x400000,
        DeleteGrid = 0x800000,
        GridManagement = SelectGrid | CreateGrid | UpdateGrid | DeleteGrid,

        // Sequence Management
        SelectSequence = 0x1000000,
        CreateSequence = 0x2000000,
        UpdateSequence = 0x4000000,
        DeleteSequence = 0x8000000,
        SequenceManagement = SelectSequence | CreateSequence | UpdateSequence | DeleteSequence,

        // Display Management
        SelectDisplay = 0x10000000,
        CreateDisplay = 0x20000000,
        UpdateDisplay = 0x40000000,
        DeleteDisplay = 0x80000000,
        DisplayManagement = SelectDisplay | CreateDisplay | UpdateDisplay | DeleteDisplay,

        // Event Management
        SelectEvent = 0x100000000,
        CreateEvent = 0x200000000,
        UpdateEvent = 0x400000000,
        DeleteEvent = 0x800000000,
        EventManagement = SelectEvent | CreateEvent | UpdateEvent | DeleteEvent,

        // IO Device Management
        SelectIODevice = 0x1000000000,
        CreateIODevice = 0x2000000000,
        UpdateIODevice = 0x4000000000,
        DeleteIODevice = 0x8000000000,
        IODeviceManagement = SelectIODevice | CreateIODevice | UpdateIODevice | DeleteIODevice,

        // Sample Management
        SelectSample = 0x10000000000,
        CreateSample = 0x20000000000,
        UpdateSample = 0x40000000000,
        DeleteSample = 0x80000000000,
        SampleManagement = SelectSample | CreateSample | UpdateSample | DeleteSample,

        // Log Management
        SelectLog = 0x100000000000,
        DeleteLog = 0x800000000000,
        LogManagement = SelectLog | DeleteLog,

        // Settings Management
        SelectSettings = 0x1000000000000,
        CreateSettings = 0x2000000000000,
        UpdateSettings = 0x4000000000000,
        DeleteSettings = 0x8000000000000,
        SettingsManagement = SelectSettings | CreateSettings | UpdateSettings | DeleteSettings,

        // Permission Management
        SelectPermission = 0x10000000000000,
        CreatePermission = 0x20000000000000,
        UpdatePermission = 0x40000000000000,
        DeletePermission = 0x80000000000000,
        PermissionManagement = SelectPermission | CreatePermission | UpdatePermission | DeletePermission,

        // Miscellaneous
        General = 0x200000000000,
        Other = 0x400000000000,
        NavigateOnGrid = 0x100000000000000,
        MoveOrSizeWindows = 0x200000000000000,
        SendCameraToFullScreenDisplay = 0x400000000000000,
        ExitApplication = 0x800000000000000,

        // Admin
        Admin = UserAndGroupManagement | ServerAndCameraManagement | SerialDeviceManagement | GridManagement |
                SequenceManagement | DisplayManagement | EventManagement | IODeviceManagement | SampleManagement |
                LogManagement | SettingsManagement | PermissionManagement | General | Other | NavigateOnGrid | MoveOrSizeWindows |
                SendCameraToFullScreenDisplay | ExitApplication
    }
}
