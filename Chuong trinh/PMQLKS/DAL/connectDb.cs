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
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-REHBC99\SQLEXPRESS;Initial Catalog=HotelManagerNew1;Integrated Security=True");
                return conn;
            }
        
    }
}
