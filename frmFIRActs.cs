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
    public partial class frmFIRActs : Form
    {
        int firact;
        int frno;
        public frmFIRActs()
        {
            InitializeComponent();
        }
        public void StartFIRActs(int value)
        {
            frno = value;
            SqlDataAdapter adp = new SqlDataAdapter("select *from Acts",Program.con);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            comboBox1.DisplayMember = "ActNo";
            comboBox1.ValueMember = "ActName";
            comboBox1.DataSource = tb;
            this.ShowDialog();
        }
        private void RefreshData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "Select FIRActs.FIRActno,FIR.FIRNo,Acts.ActNo,Acts.Description from FIRActs,Acts,FIR where FIRActs.ActNo=Acts.ActNo";
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd;
            DataTable tb1 = new DataTable();
            adp1.Fill(tb1);
            dataGridView1.DataSource = tb1;

        }

        private void frmFIRActs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "Insert into FIRActs values(@fract,@frno,@actno)";
            firact = CommonFunctions.GetNextValue(3);
            cmd.Parameters.AddWithValue("@fract", firact);
            cmd.Parameters.AddWithValue("@frno", frno);
            cmd.Parameters.AddWithValue("actno", comboBox1.Text);
            cmd.ExecuteNonQuery();

            RefreshData();
        }
    }
}
