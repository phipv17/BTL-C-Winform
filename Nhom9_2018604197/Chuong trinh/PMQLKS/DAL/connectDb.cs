using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class connectDb
    {
        
            public static SqlConnection connectingDb()
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PPUSOIT\SQLEXPRESS;Initial Catalog=HotelManagerNew;Integrated Security=True");
                return conn;
            }
        
    }
}
