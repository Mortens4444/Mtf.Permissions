using MessageBoxes;
using Mtf.Permissions.Attributes;
using Mtf.Permissions.Enums;
using Mtf.Permissions.Models;
using Mtf.Permissions.Services;

namespace Mtf.Permissions.Test
{
    public partial class MainForm : Form
    {
        private PermissionManager permissionManager;

        private int serverIndex = 3;
        private User guest = new User() { Username = "Guest", IndividualPermissions = [] };
        private User member = new User() { Username = "Group member", Groups = [new Group { Permissions = [new Permission { PermissionType = PermissionType.SelectServer }] }] };
        private User admin = new User() { Username = "Admin", IndividualPermissions = [new Permission { PermissionType = PermissionType.Admin }] };

        public MainForm()
        {
            InitializeComponent();
            permissionManager = new PermissionManager();

            listView1.Tag = "LoadServers";
            btnAdd.Tag = "Add";
            tsmiAdd.Tag = "Add";
            toolStripDropDownButton1.DropDownItems["addToolStripMenuItem"].Tag = "Add";

            comboBox1.Items.AddRange([guest, member, admin]);
            comboBox1.SelectedIndex = 0;
        }

        [RequirePermission(PermissionType.SelectServer)]
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

        [RequirePermission(PermissionType.CreateServer)]
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
            permissionManager.SetUser(this, (User)comboBox1.SelectedItem);
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
