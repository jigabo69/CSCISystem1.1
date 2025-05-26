using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using AntdUI;

namespace CSCISystem1._1
{
    public partial class AddUser: Form
    {
        SqlConnection con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand cmd = new SqlCommand();

        public AddUser()
        {
            InitializeComponent();
            RadiusForm();
            
        }

        private void AddUserToDatabase()
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Users (Username, Email, Password, FirstName, LastName, UserType, ProfilePicture) VALUES (@Username, @Email, @Password, @FirstName, @LastName, @UserType, @ProfilePicture)";
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtFname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLname.Text);
                cmd.Parameters.AddWithValue("@UserType", selectUsertype.SelectedIndex.ToString());
                if (pictureBoxAddUser.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxAddUser.Image.Save(ms, pictureBoxAddUser.Image.RawFormat);
                        byte[] imageBytes = ms.ToArray();
                        cmd.Parameters.AddWithValue("@ProfilePicture", imageBytes);
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ProfilePicture", DBNull.Value);
                }
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User added successfully.");
                    ClearField();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
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
            ClearField();
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
    }
}
