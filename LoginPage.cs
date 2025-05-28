using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUIDemo;
using Azure.Identity;
using Microsoft.Data.SqlClient;

namespace CSCISystem1._1
{


    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand cmd;

        public bool IsLoginSuccessful { get; private set; } = false;
        public bool IsAuthenticated { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void ClearField()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            showPasswordCheckBox.Checked = false;

        }

        private void LoadUserData()
        {
            string connectionString = "Data Source=EMMAN\\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserType FROM tb_user WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim()); // Use HashPassword if applicable

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string userType = reader["UserType"].ToString();
                            IsLoginSuccessful = true;

                            MessageBox.Show($"Login successful! User Type: {userType}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearField();
                            this.Hide();

                            if (userType.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                            {
                                Main mainForm = new Main();
                                mainForm.Show();
                            }
                            else if (userType.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
                            {
                                POS pos = new POS();
                                pos.Show();
                            }
                            else
                            {
                                MessageBox.Show("Unrecognized user type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            ClearField();
                            labelIncUsername.Visible = true;
                            labelIncoPassword.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 18;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 272, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            Region = new Region(path);


            labelIncUsername.Visible = false;
            labelIncoPassword.Visible = false;
            labelIncUsername.Text = "*Incorrect username*";
            labelIncoPassword.Text = "*Incorrect password*";


        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }
    }
}
