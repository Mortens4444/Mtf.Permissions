using MessageBoxes;
using Mtf.Permissions.Attributes;
using Mtf.Permissions.Enums;
using Mtf.Permissions.Models;
using Mtf.Permissions.Services;

namespace Mtf.Permissions.Test
{
    public partial class MainForm : Form
    {
        private readonly PermissionManager permissionManager;

        private int serverIndex = 3;
        
        private readonly User guest = new()
        {
            Username = "Guest",
            IndividualPermissions = []
        };
        
        private readonly User member = new()
        {
            Username = "Group member",
            Groups =
            [
                new Group
                {
                    Permissions =
                    [
                        new Permission { PermissionGroup = typeof(ServerManagementPermissions), PermissionValue = (long)ServerManagementPermissions.Select},
                        new Permission { PermissionGroup = typeof(WindowManagementPermissions), PermissionValue = (long)WindowManagementPermissions.Close}
                    ]
                }
            ]
        };

        private readonly User admin = new()
        {
            Username = "Admin",
            IndividualPermissions =
            [
                new Permission { PermissionGroup = typeof(ServerManagementPermissions), PermissionValue = (long)ServerManagementPermissions.Create },
                new Permission { PermissionGroup = typeof(ServerManagementPermissions), PermissionValue = (long)ServerManagementPermissions.Select },
                new Permission { PermissionGroup = typeof(WindowManagementPermissions), PermissionValue = (long)WindowManagementPermissions.FullControl}
            ]
        };

        public MainForm()
        {
            InitializeComponent();
            permissionManager = new PermissionManager();

            comboBox1.Items.AddRange([guest, member, admin]);
            comboBox1.SelectedIndex = 0;
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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            permissionManager.SetUser(this, (User)comboBox1.SelectedItem!);
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
    }
}
