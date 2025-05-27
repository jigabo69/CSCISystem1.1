namespace CSCISystem1._1
{
    partial class InventoryReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryReport));
            this.panel1 = new AntdUI.Panel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel2 = new AntdUI.Panel();
            this.gridViewUserList = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.panel3 = new AntdUI.Panel();
            this.siticoneDataGridView1 = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneLabel3);
            this.panel1.Controls.Add(this.siticoneLabel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.siticoneLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Radius = 20;
            this.panel1.Size = new System.Drawing.Size(936, 657);
            this.panel1.TabIndex = 2;
            this.panel1.Text = "panel1";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Satoshi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(78, 37);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(178, 32);
            this.siticoneLabel1.TabIndex = 10;
            this.siticoneLabel1.Text = "Inventory Report";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Back = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridViewUserList);
            this.panel2.Location = new System.Drawing.Point(23, 159);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Radius = 20;
            this.panel2.Size = new System.Drawing.Size(898, 192);
            this.panel2.TabIndex = 11;
            this.panel2.Text = "panel2";
            // 
            // gridViewUserList
            // 
            this.gridViewUserList.AllowUserToAddRows = false;
            this.gridViewUserList.AllowUserToResizeColumns = false;
            this.gridViewUserList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridViewUserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewUserList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.gridViewUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewUserList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewUserList.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewUserList.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewUserList.EnableHeadersVisualStyles = false;
            this.gridViewUserList.GridColor = System.Drawing.Color.White;
            this.gridViewUserList.Location = new System.Drawing.Point(27, 13);
            this.gridViewUserList.Name = "gridViewUserList";
            this.gridViewUserList.ReadOnly = true;
            this.gridViewUserList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridViewUserList.RowHeadersVisible = false;
            this.gridViewUserList.RowTemplate.Height = 60;
            this.gridViewUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewUserList.Size = new System.Drawing.Size(842, 148);
            this.gridViewUserList.TabIndex = 4;
            this.gridViewUserList.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewUserList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewUserList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
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
            this.gridViewUserList.ThemeStyle.RowsStyle.Height = 60;
            this.gridViewUserList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridViewUserList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Back = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.siticoneDataGridView1);
            this.panel3.Location = new System.Drawing.Point(23, 430);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Radius = 20;
            this.panel3.Size = new System.Drawing.Size(898, 192);
            this.panel3.TabIndex = 12;
            this.panel3.Text = "panel3";
            // 
            // siticoneDataGridView1
            // 
            this.siticoneDataGridView1.AllowUserToAddRows = false;
            this.siticoneDataGridView1.AllowUserToResizeColumns = false;
            this.siticoneDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.siticoneDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.siticoneDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.siticoneDataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.siticoneDataGridView1.EnableHeadersVisualStyles = false;
            this.siticoneDataGridView1.GridColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.Location = new System.Drawing.Point(27, 13);
            this.siticoneDataGridView1.Name = "siticoneDataGridView1";
            this.siticoneDataGridView1.ReadOnly = true;
            this.siticoneDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.siticoneDataGridView1.RowHeadersVisible = false;
            this.siticoneDataGridView1.RowTemplate.Height = 60;
            this.siticoneDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siticoneDataGridView1.Size = new System.Drawing.Size(842, 148);
            this.siticoneDataGridView1.TabIndex = 4;
            this.siticoneDataGridView1.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.siticoneDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.siticoneDataGridView1.ThemeStyle.ReadOnly = true;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 60;
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.Location = new System.Drawing.Point(38, 131);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(87, 22);
            this.siticoneLabel2.TabIndex = 13;
            this.siticoneLabel2.Text = "Overall Item";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.Location = new System.Drawing.Point(38, 402);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(102, 22);
            this.siticoneLabel3.TabIndex = 14;
            this.siticoneLabel3.Text = "Removed Item";
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 657);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserList)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private AntdUI.Panel panel3;
        private Siticone.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private AntdUI.Panel panel2;
        private Siticone.UI.WinForms.SiticoneDataGridView gridViewUserList;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
    }
}