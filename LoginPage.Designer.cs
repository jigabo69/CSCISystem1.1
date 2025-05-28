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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.labelIncoPassword = new Siticone.UI.WinForms.SiticoneLabel();
            this.labelIncUsername = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.loginBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.showPasswordCheckBox = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.txtPassword = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.txtUsername = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.loginlabel = new Siticone.UI.WinForms.SiticoneLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticonePanel1.Controls.Add(this.labelIncoPassword);
            this.siticonePanel1.Controls.Add(this.labelIncUsername);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel1.Controls.Add(this.loginBtn);
            this.siticonePanel1.Controls.Add(this.showPasswordCheckBox);
            this.siticonePanel1.Controls.Add(this.txtPassword);
            this.siticonePanel1.Controls.Add(this.txtUsername);
            this.siticonePanel1.Controls.Add(this.loginlabel);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.ForeColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(533, 619);
            this.siticonePanel1.TabIndex = 0;
            // 
            // labelIncoPassword
            // 
            this.labelIncoPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelIncoPassword.ForeColor = System.Drawing.Color.Red;
            this.labelIncoPassword.Location = new System.Drawing.Point(173, 343);
            this.labelIncoPassword.Name = "labelIncoPassword";
            this.labelIncoPassword.Size = new System.Drawing.Size(3, 2);
            this.labelIncoPassword.TabIndex = 7;
            this.labelIncoPassword.Text = null;
            // 
            // labelIncUsername
            // 
            this.labelIncUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelIncUsername.ForeColor = System.Drawing.Color.Red;
            this.labelIncUsername.Location = new System.Drawing.Point(173, 260);
            this.labelIncUsername.Name = "labelIncUsername";
            this.labelIncUsername.Size = new System.Drawing.Size(3, 2);
            this.labelIncUsername.TabIndex = 1;
            this.labelIncUsername.Text = null;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Gray;
            this.siticoneControlBox1.Location = new System.Drawing.Point(487, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.PressedColor = System.Drawing.Color.Snow;
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(46, 30);
            this.siticoneControlBox1.TabIndex = 6;
            // 
            // loginBtn
            // 
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoveredState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(205, 428);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(134, 45);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Log in";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPasswordCheckBox.CheckedState.BorderRadius = 2;
            this.showPasswordCheckBox.CheckedState.BorderThickness = 0;
            this.showPasswordCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPasswordCheckBox.ForeColor = System.Drawing.Color.Black;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(173, 364);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(101, 17);
            this.showPasswordCheckBox.TabIndex = 3;
            this.showPasswordCheckBox.Text = "Show password";
            this.showPasswordCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPasswordCheckBox.UncheckedState.BorderRadius = 2;
            this.showPasswordCheckBox.UncheckedState.BorderThickness = 0;
            this.showPasswordCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPasswordCheckBox.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoveredState.Parent = this.txtPassword;
            this.txtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconLeft")));
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtPassword.Location = new System.Drawing.Point(160, 295);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(225, 42);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoveredState.Parent = this.txtUsername;
            this.txtUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsername.IconLeft")));
            this.txtUsername.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtUsername.Location = new System.Drawing.Point(160, 212);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(225, 42);
            this.txtUsername.TabIndex = 1;
            // 
            // loginlabel
            // 
            this.loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.DimGray;
            this.loginlabel.Location = new System.Drawing.Point(234, 143);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(76, 33);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Log in";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 619);
            this.Controls.Add(this.siticonePanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtPassword;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox txtUsername;
        private Siticone.UI.WinForms.SiticoneLabel loginlabel;
        private Siticone.UI.WinForms.SiticoneCheckBox showPasswordCheckBox;
        private Siticone.UI.WinForms.SiticoneRoundedButton loginBtn;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneLabel labelIncoPassword;
        private Siticone.UI.WinForms.SiticoneLabel labelIncUsername;
    }
}