using System;

namespace Mtf.Permissions.Enums
{
    [Flags]
    public enum CameraManagementPermissions : long
    {
        None = 0,
        Select = 0x1,
        Create = 0x2,
        Update = 0x4,
        Delete = 0x8,
        OpenFullScreen = 0x10,
        CloseFullScreen = 0x20,
        OpenMotionPopup = 0x40,
        MotionPopupSettings = 0x80,

        ZoomIn = 0x100,
        ZoomOut = 0x200,
        Zoom = ZoomIn | ZoomOut,

        Pan = 0x400,
        Tilt = 0x800,
        PanTilt = Pan | Tilt,
        PTZ = PanTilt | Zoom,

        Preset = 0x1000,
        Pattern = 0x2000,

        ChangeNoSignalImage = 0x4000,
        ExportCameraList = 0x8000,

        FullControl = Select | Create | Update | Delete | OpenFullScreen | CloseFullScreen | OpenMotionPopup | MotionPopupSettings | PTZ | Preset | Pattern | ChangeNoSignalImage | ExportCameraList
    }
}
