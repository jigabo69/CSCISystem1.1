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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new AntdUI.Panel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.txtSearchItem = new AntdUI.Input();
            this.button3 = new AntdUI.Button();
            this.panel2 = new AntdUI.Panel();
            this.gridViewUserList = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.AddUserBtn = new AntdUI.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneLabel1);
            this.panel1.Controls.Add(this.txtSearchItem);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.AddUserBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 20;
            this.panel1.Size = new System.Drawing.Size(942, 696);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Satoshi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(48, 26);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(51, 32);
            this.siticoneLabel1.TabIndex = 13;
            this.siticoneLabel1.Text = "User";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchItem.JoinLeft = true;
            this.txtSearchItem.Location = new System.Drawing.Point(636, 26);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.PlaceholderText = "Search";
            this.txtSearchItem.Size = new System.Drawing.Size(267, 47);
            this.txtSearchItem.TabIndex = 11;
            this.txtSearchItem.WaveSize = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Icon = ((System.Drawing.Image)(resources.GetObject("button3.Icon")));
            this.button3.JoinRight = true;
            this.button3.Location = new System.Drawing.Point(585, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 55);
            this.button3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Back = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridViewUserList);
            this.panel2.Location = new System.Drawing.Point(21, 155);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Radius = 20;
            this.panel2.Size = new System.Drawing.Size(898, 512);
            this.panel2.TabIndex = 10;
            this.panel2.Text = "panel2";
            // 
            // gridViewUserList
            // 
            this.gridViewUserList.AllowUserToResizeColumns = false;
            this.gridViewUserList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridViewUserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewUserList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gridViewUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewUserList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewUserList.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewUserList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewUserList.EnableHeadersVisualStyles = false;
            this.gridViewUserList.GridColor = System.Drawing.Color.White;
            this.gridViewUserList.Location = new System.Drawing.Point(27, 27);
            this.gridViewUserList.Name = "gridViewUserList";
            this.gridViewUserList.ReadOnly = true;
            this.gridViewUserList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridViewUserList.RowHeadersVisible = false;
            this.gridViewUserList.RowTemplate.Height = 40;
            this.gridViewUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewUserList.Size = new System.Drawing.Size(842, 454);
            this.gridViewUserList.TabIndex = 4;
            this.gridViewUserList.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewUserList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gridViewUserList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gridViewUserList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.gridViewUserList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewUserList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridViewUserList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewUserList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridViewUserList.ThemeStyle.HeaderStyle.Height = 40;
            this.gridViewUserList.ThemeStyle.ReadOnly = true;
            this.gridViewUserList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewUserList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewUserList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridViewUserList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewUserList.ThemeStyle.RowsStyle.Height = 40;
            this.gridViewUserList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridViewUserList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUserBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.AddUserBtn.Icon = ((System.Drawing.Image)(resources.GetObject("AddUserBtn.Icon")));
            this.AddUserBtn.IconRatio = 1F;
            this.AddUserBtn.IconSize = new System.Drawing.Size(25, 25);
            this.AddUserBtn.Location = new System.Drawing.Point(841, 90);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Radius = 9;
            this.AddUserBtn.Size = new System.Drawing.Size(62, 48);
            this.AddUserBtn.TabIndex = 8;
            this.AddUserBtn.WaveSize = 1;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Panel panel2;
        private Siticone.UI.WinForms.SiticoneDataGridView gridViewUserList;
        private AntdUI.Button AddUserBtn;
        private AntdUI.Input txtSearchItem;
        private AntdUI.Button button3;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
    }
}