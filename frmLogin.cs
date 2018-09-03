using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstInformationReport
{
    public partial class frmLogin : Form
    {
        bool b;

        public frmLogin()
        {
            InitializeComponent();
        }

        public bool StartLogin ()
        {
            this.ShowDialog();
            return b;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "police" && textBox2.Text == "station")
            {
                b = true;
                this.Close();
               
                
            }
                
            else 
            {
                MessageBox.Show("Username or Password incorrect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = false;
            this.Close();
        }
    }
}
