﻿using System;
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
    public partial class frmComplaintAgainst : Form
    {
        int frno;
        int sno;
        public frmComplaintAgainst()
        {
            InitializeComponent();
        }
        public void StartComplaintsAgainst(int value)
        {
            frno = value;
            this.ShowDialog();

        }
        private void RefreshData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select ComplaintAgainst.SNo,ComplaintAgainst.ComplaintAgainstName,ComplaintAgainst.DOB,Complaintagainst.Gender,ComplaintAgainst.FatherName,ComplaintAgainst.ContactNo,ComplaintAgainst.Address,ComplaintAgainst.City,FIR.FIRNo from ComplaintAgainst,FIR where ComplaintAgainst.FIRNo=FIR.FIRNo";
            SqlDataAdapter adp1 = new SqlDataAdapter();
            adp1.SelectCommand = cmd;
            DataTable tb1 = new DataTable();
            adp1.Fill(tb1);
            dataGridView1.DataSource = tb1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             bool check = ValidateData();
             if (check == true)
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = Program.con;
                 cmd.CommandText = "Insert into ComplaintAgainst values(@sno,@ctagnm,@dob,@gen,@fnm,@cntno,@add,@ct,@frno)";
                 sno = CommonFunctions.GetNextValue(5);
                 cmd.Parameters.AddWithValue("@sno", sno);
                 cmd.Parameters.AddWithValue("@ctagnm", textBox1.Text);
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
        private void textBox2_TextChanged(object sender, EventArgs e)
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
    }
}
