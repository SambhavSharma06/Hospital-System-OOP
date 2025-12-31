using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS___CA_ONE
{
    internal class DAO
    {
        SqlConnection con;

        public DAO()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString);
        }

        public SqlConnection OpenCon()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.Open();
            }
            return con;
        }

        public void CloseCon()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
        }
    }

}
