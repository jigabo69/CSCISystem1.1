using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;

namespace CSCISystem1._1
{

    public partial class LoginPage : Form
    {
        public bool IsLoginSuccessful { get; private set; } = false;

        String Username;
        String Password;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Username = InputUserName.Text;
            Password = InputPassword.Text;

            MessageBox.Show(Username + "/n" + Password);

            this.IsLoginSuccessful = true;
            this.Close();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }  
}
