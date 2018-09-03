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
    public partial class frmFIRList : Form
    {
        public frmFIRList()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select *from FIR Where FIRNo not in (Select FIRNo from Mark ) ";
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
                frmFIRActs obj = new frmFIRActs();
                obj.StartFIRActs(a);
            }
            else 
            {
                MessageBox.Show("you have not selected anything");
            }
        }

        private void frmFIRList_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                frmWitnesses obj = new frmWitnesses();
                obj.StartWitnesses(a);
            }
            else
            {
                MessageBox.Show("you have not selected anything");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                frmComplaintAgainst obj = new frmComplaintAgainst();

                obj.StartComplaintsAgainst(a);
            }
            else
            {
                MessageBox.Show("you have not selected anything");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                frmReports obj = new frmReports();
                obj.StartReports(a);
            }
            else
            {
                MessageBox.Show("you have not selected anything");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Do you want to mark this FIR?", "Confirm Mark", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    frmMarking obj = new frmMarking();
                    obj.StartMark(a);
                }
            }
            else
            {
                MessageBox.Show("you have not selected anything");
            }
           

        }
    }
}
