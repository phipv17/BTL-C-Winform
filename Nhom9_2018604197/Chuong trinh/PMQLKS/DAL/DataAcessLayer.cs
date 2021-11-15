using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataAcessLayer
    {
        public void excuteQuerry(string sql)
        {
            SqlConnection conn = connectDb.connectingDb();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }

        //query trả về bảng
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = connectDb.connectingDb())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();

                return data;
            }
        }


        public DataTable getTableFromDB(string sql)
        {
            SqlConnection con = connectDb.connectingDb();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }

        public DataTable GetTable(string sql)
        {
            DataTable dtb = new DataTable();
            dtb = ExecuteQuery(sql);
            return dtb;
        }

        public bool isExecuteQuery(string sql)
        {
            int num = 0;
            try
            {
                SqlConnection conn = connectDb.connectingDb();
                conn.Open();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                num = (int)cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            if (num > 0)
                return true;
            else
                return false;
        }
    }
}
