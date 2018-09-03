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
    public partial class frmComplaintList : Form
    {
        public frmComplaintList()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select Complaints.SerialNo,Complaints.OfficeNo,Complaints.ComplaintBy,Complaints.Gender,Complaints.Guardian,Complaints.Address,Complaints.ContactNo,Complaints.Description,Complaints.ComplaintDate,Staff.Name From Complaints,Staff where Complaints.StaffNo=Staff.StaffNo and Complaints.SerialNo NOT IN ( Select SerialNo From FIR  )";

            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            DataTable tb = new DataTable();
            adp.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                frmComplaints obj = new frmComplaints();
                obj.StartComplaints(2, a);
                RefreshData();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "delete from Complaints where SerialNo=@sno";
                cmd.Parameters.AddWithValue("@sno", a);
                cmd.ExecuteNonQuery();
                RefreshData();

            }

        }

        private void frmComplaintList_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFIR obj = new frmFIR();
           

            int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            
            obj.StartFIR(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
