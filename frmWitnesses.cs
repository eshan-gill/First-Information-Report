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
    public partial class frmWitnesses : Form
    {
        int frno;
        int witnessno;
        public frmWitnesses()
        {
            InitializeComponent();
        }
        public void StartWitnesses(int value)
        {
            frno = value;
            RefreshData();
            this.ShowDialog();
        }
        private void RefreshData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText="select Witnesses.WitnessNo,Witnesses.WitnessName,Witnesses.DOB,Witnesses.Gender,Witnesses.FatherName,Witnesses.ContactNo,Witnesses.Address,Witnesses.City,FIR.FIRNo from Witnesses,FIR where Witnesses.FIRNo=FIR.FIRNo and Witnesses.FIRNo="+ frno.ToString ();
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd;
            DataTable tb1 = new DataTable();
            adp1.Fill(tb1);
            dataGridView1.DataSource = tb1;
        }
        private void frmWitnesses_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = ValidateData();
            if (check == true)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.con;
                cmd.CommandText = "Insert into Witnesses values(@wtno,@wtnm,@dob,@gen,@fnm,@cntno,@add,@ct,@frno)";
                witnessno = CommonFunctions.GetNextValue(4);
                cmd.Parameters.AddWithValue("@wtno", witnessno);
                cmd.Parameters.AddWithValue("@wtnm", textBox1.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                if (radioButton1.Checked = true)
                {
                    cmd.Parameters.AddWithValue("@gen", "Male");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gen", "Female");
                }
                cmd.Parameters.AddWithValue("@fnm", textBox2.Text);
                cmd.Parameters.AddWithValue("@cntno", textBox3.Text);
                cmd.Parameters.AddWithValue("@add", textBox4.Text);
                cmd.Parameters.AddWithValue("@ct", textBox5.Text);
                cmd.Parameters.AddWithValue("@frno", frno);
                cmd.ExecuteNonQuery();

                RefreshData();
            }

        }
        private bool ValidateData()
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Name is empty!");
                return false;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Father Name is empty!");
                return false;
            }


            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Address is empty!");
                return false;
            }
            if (textBox4.Text.Length == 0)
            {
                MessageBox.Show(" City is empty!");
                return false;
            }
            
            if (textBox5.Text.Length == 0)
            {
                MessageBox.Show(" ContactNo is empty!");
                return false;
            }

            return true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to delete the staements for this witness?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Program.con;
                    cmd.CommandText = "Delete From Statements Where WitnessNo=" + a.ToString();
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "delete from Witnesses where WitnessNo=@wtno";
                    cmd.Parameters.AddWithValue("@wtno", a);
                    cmd.ExecuteNonQuery();
                    RefreshData();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            frmStatements obj = new frmStatements();
            obj.StartStatement(a);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void contactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int asc = ch;
            if (asc != 8 && ch !='-')
            {
                if (asc < 48 || asc > 57)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
