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
                        new Permission { PermissionGroup = typeof(ServerManagementPermissions), PermissionValue = (long)ServerManagementPermissions.Select}
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
                new Permission { PermissionGroup = typeof(ServerManagementPermissions), PermissionValue = (long)ServerManagementPermissions.Select }
            ]
        };

        public MainForm()
        {
            InitializeComponent();
            permissionManager = new PermissionManager();

            listView1.Tag = nameof(LoadServers);
            btnAdd.Tag = nameof(Add);
            tsmiAdd.Tag = nameof(Add);
            addToolStripMenuItem1.Tag = nameof(Add);
            toolStripDropDownButton1.DropDownItems[nameof(addToolStripMenuItem)]!.Tag = nameof(Add);

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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        [RequirePermission(ServerManagementPermissions.Create)]
        private void Add()
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

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void TsmiAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
