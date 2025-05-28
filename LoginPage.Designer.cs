namespace CSCISystem1._1
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.loginlabel = new Siticone.UI.WinForms.SiticoneLabel();
            this.InputUserName = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.InputPassword = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.ShowPasswordBtn = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.Loginbutton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel1.Controls.Add(this.Loginbutton);
            this.siticonePanel1.Controls.Add(this.ShowPasswordBtn);
            this.siticonePanel1.Controls.Add(this.InputPassword);
            this.siticonePanel1.Controls.Add(this.InputUserName);
            this.siticonePanel1.Controls.Add(this.loginlabel);
            this.siticonePanel1.ForeColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.Location = new System.Drawing.Point(38, 25);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(522, 595);
            this.siticonePanel1.TabIndex = 0;
            // 
            // loginlabel
            // 
            this.loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.DimGray;
            this.loginlabel.Location = new System.Drawing.Point(227, 132);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(76, 33);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Log in";
            // 
            // InputUserName
            // 
            this.InputUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputUserName.BackColor = System.Drawing.Color.Transparent;
            this.InputUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputUserName.DefaultText = "";
            this.InputUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputUserName.DisabledState.Parent = this.InputUserName;
            this.InputUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputUserName.FocusedState.Parent = this.InputUserName;
            this.InputUserName.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputUserName.HoveredState.Parent = this.InputUserName;
            this.InputUserName.IconLeft = ((System.Drawing.Image)(resources.GetObject("InputUserName.IconLeft")));
            this.InputUserName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.InputUserName.Location = new System.Drawing.Point(152, 257);
            this.InputUserName.Name = "InputUserName";
            this.InputUserName.PasswordChar = '\0';
            this.InputUserName.PlaceholderText = "Username";
            this.InputUserName.SelectedText = "";
            this.InputUserName.ShadowDecoration.Parent = this.InputUserName;
            this.InputUserName.Size = new System.Drawing.Size(214, 42);
            this.InputUserName.TabIndex = 1;
            this.InputUserName.TextChanged += new System.EventHandler(this.siticoneRoundedTextBox1_TextChanged);
            // 
            // InputPassword
            // 
            this.InputPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPassword.DefaultText = "";
            this.InputPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputPassword.DisabledState.Parent = this.InputPassword;
            this.InputPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputPassword.FocusedState.Parent = this.InputPassword;
            this.InputPassword.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputPassword.HoveredState.Parent = this.InputPassword;
            this.InputPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("InputPassword.IconLeft")));
            this.InputPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.InputPassword.Location = new System.Drawing.Point(152, 328);
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '\0';
            this.InputPassword.PlaceholderText = "Password";
            this.InputPassword.SelectedText = "";
            this.InputPassword.ShadowDecoration.Parent = this.InputPassword;
            this.InputPassword.Size = new System.Drawing.Size(214, 42);
            this.InputPassword.TabIndex = 2;
          
            // 
            // ShowPasswordBtn
            // 
            this.ShowPasswordBtn.AutoSize = true;
            this.ShowPasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPasswordBtn.CheckedState.BorderRadius = 2;
            this.ShowPasswordBtn.CheckedState.BorderThickness = 0;
            this.ShowPasswordBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPasswordBtn.ForeColor = System.Drawing.Color.Black;
            this.ShowPasswordBtn.Location = new System.Drawing.Point(164, 386);
            this.ShowPasswordBtn.Name = "ShowPasswordBtn";
            this.ShowPasswordBtn.Size = new System.Drawing.Size(101, 17);
            this.ShowPasswordBtn.TabIndex = 3;
            this.ShowPasswordBtn.Text = "Show password";
            this.ShowPasswordBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPasswordBtn.UncheckedState.BorderRadius = 2;
            this.ShowPasswordBtn.UncheckedState.BorderThickness = 0;
            this.ShowPasswordBtn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPasswordBtn.UseVisualStyleBackColor = false;

            // 
            // Loginbutton
            // 
            this.Loginbutton.CheckedState.Parent = this.Loginbutton;
            this.Loginbutton.CustomImages.Parent = this.Loginbutton;
            this.Loginbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.HoveredState.Parent = this.Loginbutton;
            this.Loginbutton.Location = new System.Drawing.Point(197, 440);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.ShadowDecoration.Parent = this.Loginbutton;
            this.Loginbutton.Size = new System.Drawing.Size(134, 45);
            this.Loginbutton.TabIndex = 4;
            this.Loginbutton.Text = "Log in";
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Gray;
            this.siticoneControlBox1.Location = new System.Drawing.Point(473, 14);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.PressedColor = System.Drawing.Color.Snow;
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(34, 19);
            this.siticoneControlBox1.TabIndex = 6;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(604, 662);
            this.Controls.Add(this.siticonePanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox InputPassword;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox InputUserName;
        private Siticone.UI.WinForms.SiticoneLabel loginlabel;
        private Siticone.UI.WinForms.SiticoneCheckBox ShowPasswordBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton Loginbutton;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
    }
}