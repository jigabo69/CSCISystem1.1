namespace CSCISystem1._1
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainpanelProduct = new AntdUI.Panel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.txtSearchItem = new AntdUI.Input();
            this.button3 = new AntdUI.Button();
            this.panel1 = new AntdUI.Panel();
            this.gridViewProductList = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.AddProductBtn = new AntdUI.Button();
            this.mainpanelProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanelProduct
            // 
            this.mainpanelProduct.Controls.Add(this.siticoneLabel1);
            this.mainpanelProduct.Controls.Add(this.txtSearchItem);
            this.mainpanelProduct.Controls.Add(this.button3);
            this.mainpanelProduct.Controls.Add(this.panel1);
            this.mainpanelProduct.Controls.Add(this.AddProductBtn);
            this.mainpanelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanelProduct.Location = new System.Drawing.Point(10, 0);
            this.mainpanelProduct.Name = "mainpanelProduct";
            this.mainpanelProduct.Radius = 20;
            this.mainpanelProduct.Size = new System.Drawing.Size(942, 696);
            this.mainpanelProduct.TabIndex = 0;
            this.mainpanelProduct.Text = "panel1";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Satoshi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(49, 26);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(86, 32);
            this.siticoneLabel1.TabIndex = 9;
            this.siticoneLabel1.Text = "Product";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearchItem.JoinLeft = true;
            this.txtSearchItem.Location = new System.Drawing.Point(553, 91);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.PlaceholderText = "Search";
            this.txtSearchItem.Size = new System.Drawing.Size(267, 47);
            this.txtSearchItem.TabIndex = 7;
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
            this.button3.Location = new System.Drawing.Point(502, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 55);
            this.button3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gridViewProductList);
            this.panel1.Location = new System.Drawing.Point(21, 155);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Radius = 20;
            this.panel1.Size = new System.Drawing.Size(898, 512);
            this.panel1.TabIndex = 6;
            this.panel1.Text = "panel1";
            // 
            // gridViewProductList
            // 
            this.gridViewProductList.AllowUserToAddRows = false;
            this.gridViewProductList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.gridViewProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewProductList.ColumnHeadersHeight = 40;
            this.gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewProductList.EnableHeadersVisualStyles = false;
            this.gridViewProductList.GridColor = System.Drawing.Color.White;
            this.gridViewProductList.Location = new System.Drawing.Point(28, 13);
            this.gridViewProductList.MultiSelect = false;
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.ReadOnly = true;
            this.gridViewProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridViewProductList.RowHeadersVisible = false;
            this.gridViewProductList.RowTemplate.Height = 40;
            this.gridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewProductList.Size = new System.Drawing.Size(842, 470);
            this.gridViewProductList.TabIndex = 4;
            this.gridViewProductList.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewProductList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.gridViewProductList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.gridViewProductList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewProductList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridViewProductList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewProductList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewProductList.ThemeStyle.HeaderStyle.Height = 40;
            this.gridViewProductList.ThemeStyle.ReadOnly = true;
            this.gridViewProductList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewProductList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gridViewProductList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewProductList.ThemeStyle.RowsStyle.Height = 40;
            this.gridViewProductList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridViewProductList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridViewProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewProductList_CellClick_1);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.AddProductBtn.Icon = ((System.Drawing.Image)(resources.GetObject("AddProductBtn.Icon")));
            this.AddProductBtn.IconRatio = 1F;
            this.AddProductBtn.IconSize = new System.Drawing.Size(25, 25);
            this.AddProductBtn.Location = new System.Drawing.Point(841, 90);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Radius = 9;
            this.AddProductBtn.Size = new System.Drawing.Size(62, 48);
            this.AddProductBtn.TabIndex = 2;
            this.AddProductBtn.WaveSize = 1;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(952, 696);
            this.Controls.Add(this.mainpanelProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "Product";
            this.mainpanelProduct.ResumeLayout(false);
            this.mainpanelProduct.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel mainpanelProduct;
        private AntdUI.Button AddProductBtn;
        private AntdUI.Panel panel1;
        private Siticone.UI.WinForms.SiticoneDataGridView gridViewProductList;
        private AntdUI.Input txtSearchItem;
        private AntdUI.Button button3;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
    }
}