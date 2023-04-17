using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecology
{
     class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V1PNP57\SQLEXPRESS;Initial Catalog=Ecology;Integrated Security=True;");
        public void openConnection()
        {
            if(con.State == System.Data.ConnectionState.Closed) 
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
