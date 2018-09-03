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
    public partial class frmComplaints : Form
    {
        int localmode;
        int serialno;

        public frmComplaints()
        {
            InitializeComponent();
        }
        public  void StartComplaints (int mode,int value)
        {
            localmode = mode;
            serialno = value;

            SqlDataAdapter adp = new SqlDataAdapter("select * from Staff", Program.con);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "StaffNo";
            comboBox1.DataSource = tb;

            if (localmode == 2)
            {
                string query = "select Complaints.SerialNo,Complaints.OfficeNo,Complaints.ComplaintBy,Complaints.Gender,Complaints.Guardian,Complaints.Address,Complaints.ContactNo,Complaints.Description,Complaints.ComplaintDate,Staff.Name From Complaints,Staff where Complaints.StaffNo=Staff.StaffNo and Complaints.serialno=" + serialno.ToString();

                SqlDataAdapter adp1 = new SqlDataAdapter(query, Program.con);
                DataTable tb1 = new DataTable();
                adp1.Fill(tb1);

                textBox1.Text = tb1.Rows[0][1].ToString();
                textBox2.Text = tb1.Rows[0][2].ToString();
                textBox3.Text = tb1.Rows[0][4].ToString();
                textBox4.Text = tb1.Rows[0][5].ToString();
                txtContactNo.Text = tb1.Rows[0][6].ToString();
                textBox6.Text = tb1.Rows[0][7].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(tb1.Rows[0][8]);
                comboBox1.Text = tb1.Rows[0][9].ToString();
            }
            this.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmComplaints_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool check = ValidateData();
            if (check == true)
            
           
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                if (localmode == 1)
                {
                    cmd.CommandText = "Insert Into Complaints values(@sno,@offno,@compby,@gen,@guard,@add,@contctno,@desp,@dt,@stfno)";
                    serialno = CommonFunctions.GetNextValue(2);
                }

                else
                {
                    cmd.CommandText = "update Complaints Set SerialNo=@sno,OfficeNo=@offno,ComplaintBy=@compby,Gender=@gen,Guardian=@guard,Address=@add,ContactNo=@contctno,Description=@desp,Date=@dt,StaffNo=@stfno where SerailNo=" + serialno.ToString();

                }
                cmd.Parameters.AddWithValue("@sno", serialno);
                cmd.Parameters.AddWithValue("@offno", textBox1.Text);
                cmd.Parameters.AddWithValue("@compby", textBox2.Text);
                if (radioButton1.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@gen", "Male");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gen", "Female");
                }
                cmd.Parameters.AddWithValue("@guard", textBox3.Text);
                cmd.Parameters.AddWithValue("@add", textBox4.Text);
                cmd.Parameters.AddWithValue("@contctno", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@desp", textBox6.Text);
                cmd.Parameters.AddWithValue("@dt", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@stfno", comboBox1.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("record saved successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                txtContactNo.Clear();
                textBox6.Clear();
            }

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            txtContactNo.Clear();
            textBox6.Clear();
        }
        private bool ValidateData()
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("OfficeNo is empty!");
                return false;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("ComplaintBy is empty!");
                return false;
            }
         

            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Guardian is empty!");
                return false;
            }
            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show(" Address is empty!");
                return false;
            }
            if (txtContactNo.Text.Length == 0)
            {
                MessageBox.Show(" ContactNo is empty!");
                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           

        }

        private void officeno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void contactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int asc = ch;
            if (asc != 8 && ch != '-')
            {
                if (asc < 48 || asc > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void complaintby_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guardian_KeyPress(object sender, KeyPressEventArgs e)
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
