using MessageBoxes;
using Mtf.Permissions.Attributes;
using Mtf.Permissions.Enums;
using Mtf.Permissions.Models;
using Mtf.Permissions.Services;
using Mtf.Permissions.Test.Dto;

namespace Mtf.Permissions.Test
{
    public partial class MainForm : Form
    {
        private readonly PermissionManager<UserDto> permissionManager;

        private int serverIndex = 3;

        private readonly User<UserDto> guest = new()
        {
            Username = "Guest",
            IndividualPermissions = []
        };

        private readonly User<UserDto> member = new()
        {
            Username = "Group member",
            IndividualPermissions = [
                new Permission { PermissionGroup = typeof(ServerManagementPermissions), PermissionValue = (long)ServerManagementPermissions.Update, IsAllowed = false },
            ],
            Groups =
            [
                new Group
                {
                    Permissions =
                    [
                        new Permission { PermissionGroup = typeof(ServerManagementPermissions), PermissionValue = (long)ServerManagementPermissions.FullControl},
                        new Permission { PermissionGroup = typeof(WindowManagementPermissions), PermissionValue = (long)WindowManagementPermissions.Close}
                    ]
                }
            ]
        };

        private readonly User<UserDto> admin = new()
        {
            Username = "Admin",
            IndividualPermissions =
            [
                new Permission { PermissionGroup = typeof(ServerManagementPermissions), PermissionValue = (long)ServerManagementPermissions.FullControl },
                new Permission { PermissionGroup = typeof(WindowManagementPermissions), PermissionValue = (long)WindowManagementPermissions.FullControl}
            ]
        };

        public MainForm()
        {
            InitializeComponent();
            permissionManager = new PermissionManager<UserDto>();

            cbUser.Items.AddRange([guest, member, admin]);
            cbUser.SelectedIndex = 2;
        }

        [RequirePermission(ServerManagementPermissions.Select)]
        private void LoadServers()
        {
            try
            {
                listView1.Items.Clear();
                permissionManager.EnsurePermissions();
                listView1.Items.Add(new ListViewItem(["Server 1", "192.168.0.1"]));
                listView1.Items.Add(new ListViewItem(["Server 2", "192.168.0.2"]));
            }
            catch (Exception ex)
            {
                ErrorBox.Show(ex);
            }
        }

        [RequirePermission(ServerManagementPermissions.Create)]
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                permissionManager.EnsurePermissions();
                listView1.Items.Add(new ListViewItem([$"Server {serverIndex}", $"192.168.0.{serverIndex}"]));
                serverIndex++;
            }
            catch (Exception ex)
            {
                ErrorBox.Show(ex);
            }
        }

        private void CbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            permissionManager.SetUser(this, (User<UserDto>)cbUser.SelectedItem!);
            LoadServers();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int WM_SYSCOMMAND = 0x0112;
            const int WM_CLOSE = 0x0010;
            const int HTCAPTION = 0x02;
            const int SC_SIZE = 0xF000;
            const int SC_MOVE = 0xF010;

            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
            {
                if (!permissionManager.CurrentUser.HasPermission(WindowManagementPermissions.Move))
                {
                    return;
                }
            }

            if (m.Msg == WM_SYSCOMMAND)
            {
                var command = m.WParam.ToInt32() & 0xFFF0;
                if (command == SC_SIZE)
                {
                    if (!permissionManager.CurrentUser.HasPermission(WindowManagementPermissions.Resize))
                    {
                        return;
                    }
                }
                else if (command == SC_MOVE)
                {
                    if (!permissionManager.CurrentUser.HasPermission(WindowManagementPermissions.Move))
                    {
                        return;
                    }
                }
            }

            if (m.Msg == WM_CLOSE)
            {
                if (!permissionManager.CurrentUser.HasPermission(WindowManagementPermissions.Close))
                {
                    return;
                }
            }

            base.WndProc(ref m);
        }

        [RequirePermission(ServerManagementPermissions.Update)]
        private void BtnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                permissionManager.EnsurePermissions();
                InfoBox.Show("Information", "Update implementation goes here.");
            }
            catch (Exception ex)
            {
                ErrorBox.Show(ex);
            }
        }

        [RequirePermission(ServerManagementPermissions.Delete)]
        private void BtnRemove_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                permissionManager.EnsurePermissions();
                InfoBox.Show("Information", "Delete implementation goes here.");
            }
            catch (Exception ex)
            {
                ErrorBox.Show(ex);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            permissionManager.Logout(this);
        }
    }
}
