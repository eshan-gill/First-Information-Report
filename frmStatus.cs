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
    public partial class frmStatus : Form
    {

        public frmStatus()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            for (int i = 2000; i < 2014; i++)
            {
                cboYear.Items.Add(i);
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select Mark.Date As[Marking Date],FIR.FIRNo,Complaints.SerialNo,Complaints.ComplaintBy,Complaints.Gender,Complaints.Address from FIR,Complaints , Mark where FIR.SerialNo=Complaints.SerialNo and Mark.FIRNo=FIR.FIRNo and datepart(year,Mark.Date)=@y and datepart(month,Mark.Date)=@m and Mark.Status=@status";
            cmd.Parameters.AddWithValue("@status", cboStatus.Text);
            cmd.Parameters.AddWithValue("@y", cboYear.Text);
            cmd.Parameters.AddWithValue("@m", cboMonth.SelectedIndex + 1);

            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd;
            DataTable tb1 = new DataTable();
            adp1.Fill(tb1);
            dataGridView1.DataSource = tb1;

            
            
        }
        private bool ValidateData()
        {
            if (cboStatus.Text.Length == 0)
            {
                MessageBox.Show("Status is empty!");
                return false;
            }
            if (cboYear.Text.Length == 0)
            {
                MessageBox.Show("Year is empty!");
                return false;
            }
            if (cboMonth.Text.Length == 0)
            {
                MessageBox.Show("Month is empty!");
                return false;
            }


          

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                

            
                
        }
    }
}
