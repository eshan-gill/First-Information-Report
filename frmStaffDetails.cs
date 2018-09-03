using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FirstInformationReport
{
    public partial class frmStaffDetails : Form
    {
        public frmStaffDetails()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select  Complaints.ComplaintDate,Staff.StaffNo,Staff.Name,Staff.Gender,Staff.Designation,FIR.FIRNo,Complaints.SerialNo,Complaints.ComplaintBy from FIR,Complaints,Staff where FIR.SerialNo=Complaints.SerialNo and datepart(year,Complaints.ComplaintDate)=@y and datepart(month,Complaints.ComplaintDate)=@m and Staff.StaffNo=@stfno";
            cmd.Parameters.AddWithValue("@stfno",comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@y", comboBox2.Text);
            cmd.Parameters.AddWithValue("@m", comboBox3.SelectedIndex + 1);

            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd;
            DataTable tb1 = new DataTable();
            adp1.Fill(tb1);
            dataGridView1.DataSource = tb1;
            

        }

        private void frmStaffDetails_Load(object sender, EventArgs e)
        {
            for (int i = 2000; i < 2014; i++)
            {
                comboBox2.Items.Add(i);
            }

            SqlDataAdapter adp = new SqlDataAdapter("select * from Staff", Program.con);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "StaffNo";
            comboBox1.DataSource = tb;
        }
    }
}
