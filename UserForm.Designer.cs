namespace CSCISystem1._1
{
    partial class UserForm
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
            AntdUI.BreadcrumbItem breadcrumbItem1 = new AntdUI.BreadcrumbItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            AntdUI.BreadcrumbItem breadcrumbItem2 = new AntdUI.BreadcrumbItem();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new AntdUI.Panel();
            this.panel3 = new AntdUI.Panel();
            this.filter = new AntdUI.Dropdown();
            this.txtSearchUser = new AntdUI.Input();
            this.panel2 = new AntdUI.Panel();
            this.breadcrumb1 = new AntdUI.Breadcrumb();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.AddUserBtn = new AntdUI.Button();
            this.panel4 = new AntdUI.Panel();
            this.labelAction = new AntdUI.Label();
            this.gridViewUserList = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 20;
            this.panel1.Size = new System.Drawing.Size(942, 696);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.filter);
            this.panel3.Controls.Add(this.txtSearchUser);
            this.panel3.Location = new System.Drawing.Point(0, 177);
            this.panel3.Name = "panel3";
            this.panel3.Radius = 10;
            this.panel3.RadiusAlign = AntdUI.TAlignRound.Top;
            this.panel3.Size = new System.Drawing.Size(942, 71);
            this.panel3.TabIndex = 14;
            this.panel3.Text = "panel3";
            // 
            // filter
            // 
            this.filter.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.filter.IconHoverSvg = "";
            this.filter.LoadingRespondClick = true;
            this.filter.Location = new System.Drawing.Point(315, 18);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(57, 38);
            this.filter.TabIndex = 8;
            this.filter.Text = "Filter";
            this.filter.ToggleIconHoverSvg = "";
            this.filter.ToggleIconSvg = "";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUser.Location = new System.Drawing.Point(17, 18);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.PlaceholderText = "Search";
            this.txtSearchUser.PrefixSvg = "SearchOutlined";
            this.txtSearchUser.Radius = 10;
            this.txtSearchUser.Size = new System.Drawing.Size(292, 38);
            this.txtSearchUser.TabIndex = 7;
            this.txtSearchUser.WaveSize = 0;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.breadcrumb1);
            this.panel2.Controls.Add(this.siticoneLabel1);
            this.panel2.Controls.Add(this.AddUserBtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 10;
            this.panel2.Size = new System.Drawing.Size(942, 160);
            this.panel2.TabIndex = 13;
            this.panel2.Text = "panel2";
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // breadcrumb1
            // 
            this.breadcrumb1.BackColor = System.Drawing.Color.Transparent;
            this.breadcrumb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            breadcrumbItem1.Icon = ((System.Drawing.Image)(resources.GetObject("breadcrumbItem1.Icon")));
            breadcrumbItem1.LocalizationText = "homebread";
            breadcrumbItem1.Text = "Home";
            breadcrumbItem2.LocalizationText = "productbread";
            breadcrumbItem2.Text = "User";
            this.breadcrumb1.Items.Add(breadcrumbItem1);
            this.breadcrumb1.Items.Add(breadcrumbItem2);
            this.breadcrumb1.Location = new System.Drawing.Point(38, 20);
            this.breadcrumb1.Name = "breadcrumb1";
            this.breadcrumb1.Size = new System.Drawing.Size(873, 40);
            this.breadcrumb1.TabIndex = 10;
            this.breadcrumb1.Text = "breadcrumb1";
            this.breadcrumb1.ItemClick += new AntdUI.BreadcrumbItemEventHandler(this.breadcrumb1_ItemClick);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Satoshi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(38, 84);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(72, 42);
            this.siticoneLabel1.TabIndex = 9;
            this.siticoneLabel1.Text = "User";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUserBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddUserBtn.Font = new System.Drawing.Font("Satoshi", 11.25F);
            this.AddUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddUserBtn.Icon = ((System.Drawing.Image)(resources.GetObject("AddUserBtn.Icon")));
            this.AddUserBtn.IconRatio = 1F;
            this.AddUserBtn.IconSize = new System.Drawing.Size(25, 25);
            this.AddUserBtn.Location = new System.Drawing.Point(740, 92);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Radius = 9;
            this.AddUserBtn.Size = new System.Drawing.Size(179, 37);
            this.AddUserBtn.TabIndex = 2;
            this.AddUserBtn.Text = "New User";
            this.AddUserBtn.WaveSize = 1;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Back = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.labelAction);
            this.panel4.Controls.Add(this.gridViewUserList);
            this.panel4.Location = new System.Drawing.Point(0, 248);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Radius = 10;
            this.panel4.RadiusAlign = AntdUI.TAlignRound.Bottom;
            this.panel4.Size = new System.Drawing.Size(942, 448);
            this.panel4.TabIndex = 12;
            this.panel4.Text = "panel4";
            // 
            // labelAction
            // 
            this.labelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.labelAction.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAction.Location = new System.Drawing.Point(858, 11);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(53, 23);
            this.labelAction.TabIndex = 9;
            this.labelAction.Text = "";
            // 
            // gridViewUserList
            // 
            this.gridViewUserList.AllowUserToAddRows = false;
            this.gridViewUserList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridViewUserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewUserList.BackgroundColor = System.Drawing.Color.White;
            this.gridViewUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewUserList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewUserList.ColumnHeadersHeight = 40;
            this.gridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewUserList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewUserList.EnableHeadersVisualStyles = false;
            this.gridViewUserList.GridColor = System.Drawing.Color.White;
            this.gridViewUserList.Location = new System.Drawing.Point(26, 0);
            this.gridViewUserList.MultiSelect = false;
            this.gridViewUserList.Name = "gridViewUserList";
            this.gridViewUserList.ReadOnly = true;
            this.gridViewUserList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridViewUserList.RowHeadersVisible = false;
            this.gridViewUserList.RowTemplate.Height = 70;
            this.gridViewUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewUserList.Size = new System.Drawing.Size(885, 419);
            this.gridViewUserList.TabIndex = 4;
            this.gridViewUserList.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewUserList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewUserList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gridViewUserList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.gridViewUserList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewUserList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewUserList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewUserList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewUserList.ThemeStyle.HeaderStyle.Height = 40;
            this.gridViewUserList.ThemeStyle.ReadOnly = true;
            this.gridViewUserList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewUserList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewUserList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewUserList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewUserList.ThemeStyle.RowsStyle.Height = 70;
            this.gridViewUserList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridViewUserList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridViewUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewUserList_CellClick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(952, 696);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Panel panel3;
        private AntdUI.Dropdown filter;
        private AntdUI.Input txtSearchUser;
        private AntdUI.Panel panel2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private AntdUI.Button AddUserBtn;
        private AntdUI.Panel panel4;
        private Siticone.UI.WinForms.SiticoneDataGridView gridViewUserList;
        private AntdUI.Breadcrumb breadcrumb1;
        private AntdUI.Label labelAction;
    }
}