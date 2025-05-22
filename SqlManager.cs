using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CSCISystem1._1
{
    class SqlManager
    {
        SqlConnection _con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand _cmd;
        public SqlManager()
        {

        }

        public void LoadSQLUserData()
        {
            _con.Open();
            string query = "SELECT username, email, password, usertype FROM tb_user";
            _cmd = new SqlCommand(query, _con);
            SqlDataReader reader = _cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader["username"].ToString();
                string email = reader["email"].ToString();
                string password = reader["password"].ToString();
                string usertype = reader["usertype"].ToString();
                // Do something with the data, e.g., add it to a list or display it
            }

        }

    }
}
