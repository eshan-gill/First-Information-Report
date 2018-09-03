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
    public partial class frmActList : Form
    {
        public frmActList()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RefreshData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select * from Acts ";
            
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
                int a  = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                frmActs obj = new frmActs();
                obj.StartActs(2, a);
                RefreshData();
            }
        }

        private void frmActList_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to delete the related records with this act?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.con;
                    cmd.CommandText = "delete from Acts where ActNo=@actno";
                    cmd.Parameters.AddWithValue("@actno", a);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        RefreshData();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("You cannot delete a act record because it has related records in other tables!");

                    }
                }
            }
        }
    }
}
