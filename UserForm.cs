using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CSCISystem1._1
{
    public partial class UserForm: Form
    {
        SqlConnection con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand cmd;


        public UserForm()
        {
            InitializeComponent();
            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            InitializeDataUser();
        }

        public void InitializeDataUser()
        {
            gridViewUserList.Columns.Add("username", "Username");
            gridViewUserList.Columns.Add("email", "Email");
            gridViewUserList.Columns.Add("fname", "First Name");
            gridViewUserList.Columns.Add("lname", "Last Name");
            gridViewUserList.Columns.Add("usertype", "User Type");

            con.Open();
            string query = "SELECT username, email, fname, lname, usertype FROM tb_user";
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                gridViewUserList.Rows.Add(
                    reader["username"].ToString(),
                    reader["email"].ToString(),
                    reader["fname"].ToString(),
                    reader["lname"].ToString(),
                    reader["usertype"].ToString()
                );
            }
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.ShowDialog();
        }
    }
}
