using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FirstInformationReport
{
    static class Program
    {
        public static SqlConnection con = new SqlConnection();
        [STAThread]
        static void Main()
        {
            con.ConnectionString = "server=DELL-PC\\PALLAVIDATA;database=police;trusted_connection=yes";
            con.Open();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            con.Close();
            con.Dispose();
        }
    }
}
