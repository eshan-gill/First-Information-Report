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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }


        int localmode;
        int staffno;
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        
        
        public void StartStaff(int mode,int value)
        {
            localmode = mode;
            staffno = value;

            if (localmode == 2)
            {
                string q = "Select *from Staff where StaffNo=" + staffno.ToString();
                SqlDataAdapter adp = new SqlDataAdapter(q, Program.con);
                DataTable tb = new DataTable();
                adp.Fill(tb);

                
                textBox2.Text = tb.Rows[0][1].ToString();
                textBox3.Text = tb.Rows[0][4].ToString();
                textBox4.Text = tb.Rows[0][5].ToString();
                textBox5.Text = tb.Rows[0][6].ToString();
                textBox6.Text = tb.Rows[0][7].ToString();
                textBox7.Text = tb.Rows[0][8].ToString();
                comboBox1.Text=tb.Rows[0][9].ToString();
                textBox8.Text = tb.Rows[0][10].ToString();
                textBox9.Text = tb.Rows[0][11].ToString();
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
                    cmd.CommandText = "insert into Staff Values(@sno,@nm,@gen,@dob,@fnm,@add,@ct,@pcode,@phnno,@bgp,@desg,@transfrm,@jdt)";
                    staffno = CommonFunctions.GetNextValue(1);
                }
                else
                {
                    cmd.CommandText = "update Staff Set StaffNo=@sno,Name=@nm,Gender=@gen,DOB=@dob,FatherName=@fnm,Address=@add,City=@ct,Pincode=@pcode,PhoneNo=@phnno,BloodGroup=@bgp,Designation=@desg,TransferredFrom=@transfrm,JoinDate=@jdt where StaffNo=" + staffno.ToString();

                }
                cmd.Parameters.AddWithValue("@sno", staffno);
                cmd.Parameters.AddWithValue("@nm", textBox2.Text);
                if (radioButton1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@gen", "Male");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gen", "Female");
                }
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@fnm", textBox3.Text);
                cmd.Parameters.AddWithValue("@add", textBox4.Text);
                cmd.Parameters.AddWithValue("@ct", textBox5.Text);
                cmd.Parameters.AddWithValue("@pcode", textBox6.Text);
                cmd.Parameters.AddWithValue("@phnno", textBox7.Text);
                cmd.Parameters.AddWithValue("@bgp", comboBox1.Text);
                cmd.Parameters.AddWithValue("@desg", textBox8.Text);
                cmd.Parameters.AddWithValue("@transfrm", textBox9.Text);
                cmd.Parameters.AddWithValue("@jdt", dateTimePicker2.Value);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved successfully.....");

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
            }
            
        }

        private bool ValidateData()
        {
           
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Name is empty!");
                return false;
            }
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Father's Name is empty!");
                return false;
            }
            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show("Address is empty!");
                return false;
            }
            if (textBox5.Text.Length == 0)
            {
                MessageBox.Show(" City is empty!");
                return false;
            }
            if (textBox6.Text.Length == 0)
            {
                MessageBox.Show(" Pincode is empty!");
                return false;
            }
            if (textBox7.Text.Length == 0)
            {
                MessageBox.Show(" PhoneNo is empty!");
                return false;
            }
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show(" Blood group is empty!");
                return false;
            }
            if (textBox8.Text.Length == 0)
            {
                MessageBox.Show(" Designation is empty!");
                return false;
            }
            if (textBox9.Text.Length == 0)
            {
                MessageBox.Show("Transferred from is empty!");
                return false;
            }

            return true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void fathername_KeyPress(object sender, KeyPressEventArgs e)
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

        private void city_KeyPress(object sender, KeyPressEventArgs e)
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

        private void transferredfrom_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int asc = ch;
            if (asc != 8)
            {
                if (asc < 48 || asc > 57)
                {
                    e.Handled = true;
                }
            }
            
            
        }

        private void phoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int asc = ch;
            if (asc != 8 && ch != '-')
            {
                if (asc < 48 || asc > 57 )
                {
                    e.Handled = true;
                }
            }
        }
    }
}