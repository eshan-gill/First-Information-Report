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
    public partial class frmReports : Form
    {
        int frno;
        int rno;
        public frmReports()
        {
            InitializeComponent();
        }

        public void StartReports(int value)
        {
            frno = value;
            this.ShowDialog();
        }
        private void frmReports_Load(object sender, EventArgs e)
        {

        }
        private void RefreshData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select Reports.ReportId,Reports.ReportName,Reports.ProvenBy,Reports.Status,Reports.Description,FIR.FIRNo from Reports,FIR where Reports.FIRNo=FIR.FIRNo";
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd;
            DataTable tb1 = new DataTable();
            adp1.Fill(tb1);
            dataGridView1.DataSource = tb1;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "Insert into Reports values(@rno,@rnm,@proby,@status,@descp,@frno)";
            rno = CommonFunctions.GetNextValue(6);
            cmd.Parameters.AddWithValue("@rno",rno);
            cmd.Parameters.AddWithValue("@rnm", textBox1.Text);
            cmd.Parameters.AddWithValue("@proby", textBox2.Text);
            cmd.Parameters.AddWithValue("@status", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@descp", textBox2.Text);
            cmd.Parameters.AddWithValue("@frno", frno);

            cmd.ExecuteNonQuery();
            RefreshData();
        }
        private bool ValidateData()
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Report Name is empty!");
                return false;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Proven By is empty!");
                return false;
            }
            

            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show(" Status is empty!");
                return false;
            }

            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int asc = ch;
            if (asc != 8)
            {
                if (asc < 65 || asc > 122)
                {
                    e.Handled = true;
                }
            }
        }

        private void provenby_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int asc = ch;
            if (asc != 8)
            {
                if (asc < 65 || asc > 122)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
