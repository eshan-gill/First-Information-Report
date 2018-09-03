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
    public partial class frmActs : Form
    {
        int localmode;
        int actno;
        public frmActs()
        {
            InitializeComponent();
        }
        public void StartActs(int mode, int value)
        {
            localmode = mode;
            actno = value;

            if (localmode == 2)
            {
                string query= "select *from Acts where Acts.ActNo=" + actno.ToString();

                SqlDataAdapter adp = new SqlDataAdapter(query,Program.con);
                DataTable tb = new DataTable();
                adp.Fill(tb);

                textBox1.Text = tb.Rows[0][0].ToString();
                textBox2.Text = tb.Rows[0][1].ToString();
                textBox3.Text = tb.Rows[0][2].ToString();
            }
            this.ShowDialog();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = ValidateData();
            if (check == true)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                if (localmode == 1)
                {
                    cmd.CommandText = "Insert into Acts values(@actno,@actnm,@desp)";
                    actno = CommonFunctions.GetNextValue(9);
                    
                }
                else
                {
                    cmd.CommandText = "update Acts Set ActNo=@actno,ActName=@actnm,Description=@desp where ActNo=" + actno.ToString();
                }
                cmd.Parameters.AddWithValue("@actno", actno);
                cmd.Parameters.AddWithValue("@actnm", textBox2.Text);
                cmd.Parameters.AddWithValue("@desp", textBox3.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record saved successfully....");
                
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            
            
        }
        private bool ValidateData()
        {
            
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Act Name is empty!");
                return false;
            }
           
          

            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void actno_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void Actname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
