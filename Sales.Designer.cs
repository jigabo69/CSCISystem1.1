namespace CSCISystem1._1
{
    partial class Sales
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
            AntdUI.BreadcrumbItem breadcrumbItem7 = new AntdUI.BreadcrumbItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            AntdUI.BreadcrumbItem breadcrumbItem8 = new AntdUI.BreadcrumbItem();
            this.panel6 = new AntdUI.Panel();
            this.breadcrumb1 = new AntdUI.Breadcrumb();
            this.siticoneLabel4 = new Siticone.UI.WinForms.SiticoneLabel();
            this.AddProductBtn = new AntdUI.Button();
            this.panel1 = new AntdUI.Panel();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.breadcrumb1);
            this.panel6.Controls.Add(this.siticoneLabel4);
            this.panel6.Controls.Add(this.AddProductBtn);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel6.Radius = 10;
            this.panel6.Size = new System.Drawing.Size(921, 170);
            this.panel6.TabIndex = 12;
            this.panel6.Text = "panel6";
            // 
            // breadcrumb1
            // 
            this.breadcrumb1.BackColor = System.Drawing.Color.Transparent;
            this.breadcrumb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            breadcrumbItem7.Icon = ((System.Drawing.Image)(resources.GetObject("breadcrumbItem7.Icon")));
            breadcrumbItem7.LocalizationText = "homebread";
            breadcrumbItem7.Text = "Home";
            breadcrumbItem8.LocalizationText = "sales";
            breadcrumbItem8.Text = "Sales";
            this.breadcrumb1.Items.Add(breadcrumbItem7);
            this.breadcrumb1.Items.Add(breadcrumbItem8);
            this.breadcrumb1.Location = new System.Drawing.Point(38, 20);
            this.breadcrumb1.Name = "breadcrumb1";
            this.breadcrumb1.Size = new System.Drawing.Size(873, 40);
            this.breadcrumb1.TabIndex = 10;
            this.breadcrumb1.Text = "breadcrumb1";
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Satoshi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.Location = new System.Drawing.Point(38, 84);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(81, 42);
            this.siticoneLabel4.TabIndex = 9;
            this.siticoneLabel4.Text = "Sales";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(40)))));
            this.AddProductBtn.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddProductBtn.Icon = ((System.Drawing.Image)(resources.GetObject("AddProductBtn.Icon")));
            this.AddProductBtn.IconRatio = 1F;
            this.AddProductBtn.IconSize = new System.Drawing.Size(25, 25);
            this.AddProductBtn.Location = new System.Drawing.Point(719, 92);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Radius = 9;
            this.AddProductBtn.Size = new System.Drawing.Size(179, 39);
            this.AddProductBtn.TabIndex = 2;
            this.AddProductBtn.Text = "Download";
            this.AddProductBtn.WaveSize = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Name = "panel1";
            this.panel1.padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Radius = 10;
            this.panel1.Size = new System.Drawing.Size(921, 425);
            this.panel1.TabIndex = 13;
            this.panel1.Text = "panel1";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(920, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel6;
        private AntdUI.Breadcrumb breadcrumb1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel4;
        private AntdUI.Button AddProductBtn;
        private AntdUI.Panel panel1;
    }
}