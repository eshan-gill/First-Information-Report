namespace FirstInformationReport
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.authenticationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDevelopersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authenticationToolStripMenuItem,
            this.actsToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.complaintsToolStripMenuItem,
            this.fIRToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.staffDetailsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // authenticationToolStripMenuItem
            // 
            this.authenticationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.authenticationToolStripMenuItem.Name = "authenticationToolStripMenuItem";
            this.authenticationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.authenticationToolStripMenuItem.Text = "Authentication";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Enabled = false;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actsToolStripMenuItem
            // 
            this.actsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.listToolStripMenuItem});
            this.actsToolStripMenuItem.Name = "actsToolStripMenuItem";
            this.actsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.actsToolStripMenuItem.Text = "Acts";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Enabled = false;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Enabled = false;
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.listToolStripMenuItem1});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Enabled = false;
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // listToolStripMenuItem1
            // 
            this.listToolStripMenuItem1.Enabled = false;
            this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            this.listToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.listToolStripMenuItem1.Text = "List";
            this.listToolStripMenuItem1.Click += new System.EventHandler(this.listToolStripMenuItem1_Click);
            // 
            // complaintsToolStripMenuItem
            // 
            this.complaintsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.listToolStripMenuItem2});
            this.complaintsToolStripMenuItem.Name = "complaintsToolStripMenuItem";
            this.complaintsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.complaintsToolStripMenuItem.Text = "Complaints";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Enabled = false;
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // listToolStripMenuItem2
            // 
            this.listToolStripMenuItem2.Enabled = false;
            this.listToolStripMenuItem2.Name = "listToolStripMenuItem2";
            this.listToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.listToolStripMenuItem2.Text = "List";
            this.listToolStripMenuItem2.Click += new System.EventHandler(this.listToolStripMenuItem2_Click);
            // 
            // fIRToolStripMenuItem
            // 
            this.fIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem3});
            this.fIRToolStripMenuItem.Name = "fIRToolStripMenuItem";
            this.fIRToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fIRToolStripMenuItem.Text = "FIR";
            // 
            // listToolStripMenuItem3
            // 
            this.listToolStripMenuItem3.Enabled = false;
            this.listToolStripMenuItem3.Name = "listToolStripMenuItem3";
            this.listToolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
            this.listToolStripMenuItem3.Text = "List";
            this.listToolStripMenuItem3.Click += new System.EventHandler(this.listToolStripMenuItem3_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // staffDetailsToolStripMenuItem
            // 
            this.staffDetailsToolStripMenuItem.Name = "staffDetailsToolStripMenuItem";
            this.staffDetailsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.staffDetailsToolStripMenuItem.Text = "Staff details";
            this.staffDetailsToolStripMenuItem.Click += new System.EventHandler(this.staffDetailsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDevelopersToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutDevelopersToolStripMenuItem
            // 
            this.aboutDevelopersToolStripMenuItem.Name = "aboutDevelopersToolStripMenuItem";
            this.aboutDevelopersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutDevelopersToolStripMenuItem.Text = "About Developers";
            this.aboutDevelopersToolStripMenuItem.Click += new System.EventHandler(this.aboutDevelopersToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel1.Text = "......";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Police Station Record";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem complaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem authenticationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem fIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDevelopersToolStripMenuItem;
    }
}

