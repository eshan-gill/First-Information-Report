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
    public partial class frmStatements : Form
    {
        int wtno;
        int stno;
        public frmStatements()
        {
            InitializeComponent();
        }
        public void StartStatement(int value)
        {
            wtno = value;
            this.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select * From Statements where WitnessNo="+wtno.ToString();
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
            cmd.CommandText = "Insert into Statements values(@stno,@dt,@st,@wtno)";
            stno = CommonFunctions.GetNextValue(8);
            cmd.Parameters.AddWithValue("@stno", stno);
            cmd.Parameters.AddWithValue("@dt", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@st",textBox1.Text);
            cmd.Parameters.AddWithValue("@wtno", wtno);
            cmd.ExecuteNonQuery();
            RefreshData();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "delete from Statements where StatementNo=@stno";
                cmd.Parameters.AddWithValue("@stno", a);
                cmd.ExecuteNonQuery();
                RefreshData();

            }
        }
    }
}
