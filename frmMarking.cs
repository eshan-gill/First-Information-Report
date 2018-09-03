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
   
    public partial class frmMarking : Form
    {
        int frno;
        int mid;

        public frmMarking()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        public void StartMark(int value)
        {
            frno=value;
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "Insert into Mark values(@mid,@dt,@status,@descp,@frno)";
            mid = CommonFunctions.GetNextValue(7);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@dt", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@status", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@descp", textBox1.Text);
            cmd.Parameters.AddWithValue("@frno", frno);

            cmd.ExecuteNonQuery();
            MessageBox.Show("record saved sucessfully..");
            textBox1.Clear();
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
