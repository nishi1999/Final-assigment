using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Books
{
   public  class Database
    {
        public static SqlConnection connect()
        {
            string connString = "Server=LAPTOP-6F2DUTV4; Database=Library; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
