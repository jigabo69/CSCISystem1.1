using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using AntdUI;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace CSCISystem1._1
{
    public partial class AddUser: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        SqlCommand cmd = new SqlCommand();

        public AddUser()
        {
            InitializeComponent();
            RadiusForm();
            
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        private void AddUserToDatabase()
        {
            //gathering input values
            var username = txtUsername.Text.Trim();
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text.Trim();
            var firstName = txtFname.Text.Trim();
            var lastName = txtLname.Text.Trim();

            //check for empty required fields
            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                selectUsertype.SelectedValue == null ||
                string.IsNullOrEmpty(selectUsertype.SelectedValue.ToString()))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //validate email format
            if (!IsValidEmail(email))
            {
                labelEmail.Text = "Please enter a valid Email Address.";
                return;
            }
            labelEmail.Text = "";

            try
            {
                string query = "INSERT INTO tb_user (Username, Email, Password, FirstName, LastName, UserType, ProfilePicture) " +
                               "VALUES (@Username, @Email, @Password, @FirstName, @LastName, @UserType, @ProfilePicture)";
                using (SqlCommand _cmd = new SqlCommand(query, con))
                {
                    string hashedPassword = HashPassword(password);

                    _cmd.Parameters.AddWithValue("@Username", username);
                    _cmd.Parameters.AddWithValue("@Email", email);
                    _cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    _cmd.Parameters.AddWithValue("@FirstName", firstName);
                    _cmd.Parameters.AddWithValue("@LastName", lastName);
                    _cmd.Parameters.AddWithValue("@UserType", selectUsertype.SelectedValue.ToString());

                    if (pictureBoxAddUser.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBoxAddUser.Image.Save(ms, pictureBoxAddUser.Image.RawFormat);
                            byte[] imageBytes = ms.ToArray();
                            _cmd.Parameters.AddWithValue("@ProfilePicture", imageBytes);
                        }
                    }
                    else
                    {
                        _cmd.Parameters.AddWithValue("@ProfilePicture", DBNull.Value);
                    }

                    con.Open();
                    _cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }



        private void LoadUserType()
        {
            selectUsertype.Items.Clear();
            selectUsertype.Items.Add("Admin");
            selectUsertype.Items.Add("Cashier");
            selectUsertype.SelectedIndex = -1;

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            
            LoadUserType();
        }

        private void ClearField()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtFname.Clear();
            txtLname.Clear();
            selectUsertype.SelectedIndex = -1; 
            pictureBoxAddUser.Image = null;


            string defaultImagePath = @"C:\Users\emman\OneDrive\Pictures\Icon Black small\23.png"; 
            if (File.Exists(defaultImagePath))
            {
                pictureBoxAddUser.Image = Image.FromFile(defaultImagePath);
            }
            else
            {
                pictureBoxAddUser.Image = null; //in case file is missing
            }

            txtUsername.Focus();
        }
        private void RadiusForm()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            var radius = 18;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 272, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            Region = new Region(path);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddUserToDatabase();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                pictureBoxAddUser.Image = Image.FromFile(openFileDialog.FileName);
                pictureBoxAddUser.ImageFit = TFit.Cover;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            labelEmail.Text = "";
        }
    }
}
