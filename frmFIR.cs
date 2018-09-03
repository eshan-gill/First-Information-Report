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
    public partial class frmFIR : Form
    {
        int xyz;
        public frmFIR()
        {
            InitializeComponent();
        }

        public void StartFIR( int a)
        {
            xyz = a;
            this.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           bool check = ValidateData();
           if (check == true)
           {
               SqlCommand cmd = new SqlCommand();
               cmd.Connection = Program.con;
               cmd.CommandText = "Insert Into FIR values(@firno,@dt,@descp,@sno)";
               cmd.Parameters.AddWithValue("@firno", textBox1.Text);
               cmd.Parameters.AddWithValue("@dt", dateTimePicker1.Value);
               cmd.Parameters.AddWithValue("@descp", textBox2.Text);
               cmd.Parameters.AddWithValue("@sno", xyz);

               

               cmd.ExecuteNonQuery();
               MessageBox.Show("record saved successfully");
               textBox1.Clear();
               textBox2.Clear();
           }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            
        }
        private bool ValidateData()
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("FIR No is empty!");
                return false;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("FIR Date is empty!");
                return false;
            }
            
            return true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
