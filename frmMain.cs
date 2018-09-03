using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstInformationReport
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "New Act can be added";
            frmActs obj = new frmActs();
            obj.StartActs(1, 0);
            toolStripStatusLabel1.Text = "New Act is added";
           

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You can Edit the Acts ";
            frmActList obj = new frmActList();
            obj.ShowDialog();
            toolStripStatusLabel1.Text ="Act is edited ";
            
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "New Staff can be added";
            frmStaff obj = new frmStaff();
            obj.StartStaff(1, 0);
            toolStripStatusLabel1.Text = "New Staff is added";
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You can Edit the Staff";
            frmStafflist obj = new frmStafflist();
            obj.ShowDialog();
            toolStripStatusLabel1.Text = "Staff is edited";
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "New Complaints can be added";
            frmComplaints obj = new frmComplaints();
            obj.StartComplaints(1, 0);
            toolStripStatusLabel1.Text = "New Complaints are added";
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You can Edit Complaints";
            frmComplaintList obj = new frmComplaintList();
            obj.ShowDialog();
            toolStripStatusLabel1.Text = "Complaints are edited";
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            bool a = obj.StartLogin();
            if (a == true)
            {
                loginToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = true;
                addToolStripMenuItem.Enabled = true;
                listToolStripMenuItem.Enabled = true;
                addToolStripMenuItem1.Enabled = true;
                listToolStripMenuItem1.Enabled = true;
                addToolStripMenuItem2.Enabled = true;
                listToolStripMenuItem2.Enabled = true;
                listToolStripMenuItem3.Enabled = true;

                toolStripStatusLabel1.Text = "logged in successful";
               
 
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            addToolStripMenuItem.Enabled = false;
            listToolStripMenuItem.Enabled = false;
            addToolStripMenuItem1.Enabled = false;
            listToolStripMenuItem1.Enabled = false;
            addToolStripMenuItem2.Enabled = false;
            listToolStripMenuItem2.Enabled = false;
            listToolStripMenuItem3.Enabled = false;

            toolStripStatusLabel1.Text = "logged out successful";

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmFIRList obj = new frmFIRList();
            obj.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatus obj = new frmStatus();
            obj.ShowDialog();
        }

        private void staffDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaffDetails obj = new frmStaffDetails();
            obj.ShowDialog();
        }

        private void aboutDevelopersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutDevelopers obj = new frmAboutDevelopers();
            obj.ShowDialog();
        }
    }
}
