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
            this.label1 = new System.Windows.Forms.Label();
            this.input1 = new AntdUI.Input();
            this.AddProductBtn = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.panel1 = new AntdUI.Panel();
            this.gridViewProductList = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.mainpanelProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanelProduct
            // 
            this.mainpanelProduct.Controls.Add(this.panel1);
            this.mainpanelProduct.Controls.Add(this.button2);
            this.mainpanelProduct.Controls.Add(this.AddProductBtn);
            this.mainpanelProduct.Controls.Add(this.input1);
            this.mainpanelProduct.Controls.Add(this.label1);
            this.mainpanelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanelProduct.Location = new System.Drawing.Point(10, 0);
            this.mainpanelProduct.Name = "mainpanelProduct";
            this.mainpanelProduct.Radius = 20;
            this.mainpanelProduct.Size = new System.Drawing.Size(942, 696);
            this.mainpanelProduct.TabIndex = 0;
            this.mainpanelProduct.Text = "panel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // input1
            // 
            this.input1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.IconGap = 1F;
            this.input1.IconRatio = 1F;
            this.input1.Location = new System.Drawing.Point(546, 26);
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "Search";
            this.input1.Radius = 20;
            this.input1.Size = new System.Drawing.Size(223, 42);
            this.input1.TabIndex = 1;
            this.input1.WaveSize = 1;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.AddProductBtn.Icon = ((System.Drawing.Image)(resources.GetObject("AddProductBtn.Icon")));
            this.AddProductBtn.IconRatio = 1F;
            this.AddProductBtn.IconSize = new System.Drawing.Size(30, 30);
            this.AddProductBtn.Location = new System.Drawing.Point(840, 122);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Radius = 20;
            this.AddProductBtn.Shape = AntdUI.TShape.Circle;
            this.AddProductBtn.Size = new System.Drawing.Size(50, 50);
            this.AddProductBtn.TabIndex = 2;
            this.AddProductBtn.WaveSize = 1;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.button2.Icon = ((System.Drawing.Image)(resources.GetObject("button2.Icon")));
            this.button2.IconRatio = 0.1F;
            this.button2.IconSize = new System.Drawing.Size(20, 20);
            this.button2.Location = new System.Drawing.Point(775, 26);
            this.button2.Name = "button2";
            this.button2.Radius = 20;
            this.button2.Shape = AntdUI.TShape.Circle;
            this.button2.Size = new System.Drawing.Size(42, 42);
            this.button2.TabIndex = 4;
            this.button2.WaveSize = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gridViewProductList);
            this.panel1.Location = new System.Drawing.Point(50, 227);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Radius = 20;
            this.panel1.Size = new System.Drawing.Size(841, 420);
            this.panel1.TabIndex = 6;
            this.panel1.Text = "panel1";
            // 
            // gridViewProductList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewProductList.BackgroundColor = System.Drawing.Color.White;
            this.gridViewProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewProductList.EnableHeadersVisualStyles = false;
            this.gridViewProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewProductList.Location = new System.Drawing.Point(41, 65);
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.RowHeadersVisible = false;
            this.gridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewProductList.Size = new System.Drawing.Size(762, 296);
            this.gridViewProductList.TabIndex = 0;
            this.gridViewProductList.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewProductList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewProductList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridViewProductList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewProductList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridViewProductList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProductList.ThemeStyle.HeaderStyle.Height = 4;
            this.gridViewProductList.ThemeStyle.ReadOnly = false;
            this.gridViewProductList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewProductList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridViewProductList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridViewProductList.ThemeStyle.RowsStyle.Height = 22;
            this.gridViewProductList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewProductList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
        private System.Windows.Forms.Label label1;
        private AntdUI.Input input1;
        private AntdUI.Button AddProductBtn;
        private AntdUI.Button button2;
        private AntdUI.Panel panel1;
        private Siticone.UI.WinForms.SiticoneDataGridView gridViewProductList;
    }
}