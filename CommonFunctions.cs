using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FirstInformationReport
{
    class CommonFunctions
    {
        public static int GetNextValue (int entity)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select LastData from NextValues where KeyNo=" + entity.ToString();

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int nv = dr.GetInt32(0);
            dr.Close();
            nv++;
            cmd.CommandText = "update NextValues Set LastData=@Ld where keyno=" + entity.ToString();

            cmd.Parameters.AddWithValue("@Ld", nv);
            cmd.ExecuteNonQuery();

            return nv;
        }

    }
}
