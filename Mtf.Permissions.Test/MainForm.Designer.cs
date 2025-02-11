namespace Mtf.Permissions.Test
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnAdd = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addToolStripMenuItem1 = new ToolStripMenuItem();
            cbUser = new ComboBox();
            menuStrip1 = new MenuStrip();
            tsmiAdd = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            addToolStripMenuItem = new ToolStripMenuItem();
            btnRemove = new Button();
            btnUpdate = new Button();
            btnLogout = new Button();
            btnAddOrModify = new Button();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Location = new Point(33, 78);
            listView1.Name = "listView1";
            listView1.Size = new Size(235, 210);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "IP Address";
            columnHeader2.Width = 100;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(97, 26);
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(96, 22);
            addToolStripMenuItem1.Text = "Add";
            addToolStripMenuItem1.Click += BtnAdd_Click;
            // 
            // cbUser
            // 
            cbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(33, 48);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(235, 23);
            cbUser.TabIndex = 2;
            cbUser.SelectedIndexChanged += CbUser_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiAdd });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(415, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAdd
            // 
            tsmiAdd.Name = "tsmiAdd";
            tsmiAdd.Size = new Size(41, 20);
            tsmiAdd.Text = "Add";
            tsmiAdd.Click += BtnAdd_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            statusStrip1.Location = new Point(0, 357);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(415, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(96, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += BtnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(193, 294);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.MouseDown += BtnRemove_MouseDown;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(112, 294);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Modify";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.MouseClick += BtnUpdate_MouseClick;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(274, 78);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += BtnLogout_Click;
            // 
            // btnAddOrModify
            // 
            btnAddOrModify.Location = new Point(33, 323);
            btnAddOrModify.Name = "btnAddOrModify";
            btnAddOrModify.Size = new Size(154, 23);
            btnAddOrModify.TabIndex = 8;
            btnAddOrModify.Text = "Add/Modify";
            btnAddOrModify.UseVisualStyleBackColor = true;
            btnAddOrModify.Click += BtnAddOrModify_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 379);
            Controls.Add(btnAddOrModify);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(statusStrip1);
            Controls.Add(cbUser);
            Controls.Add(listView1);
            Controls.Add(btnAdd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ComboBox cbUser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiAdd;
        private StatusStrip statusStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addToolStripMenuItem1;
        private Button btnRemove;
        private Button btnUpdate;
        private Button btnLogout;
        private Button btnAddOrModify;
    }
}
