namespace CSCISystem1._1
{
    partial class AddProductForm
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
            this.panel1 = new AntdUI.Panel();
            this.panel2 = new AntdUI.Panel();
            this.uploadDragger1 = new AntdUI.UploadDragger();
            this.txtTotalPrice = new AntdUI.InputNumber();
            this.txtPrice = new AntdUI.InputNumber();
            this.button1 = new AntdUI.Button();
            this.txtQuantity = new AntdUI.InputNumber();
            this.dtpExpDate = new AntdUI.DatePicker();
            this.dtpMfgDate = new AntdUI.DatePicker();
            this.comboBoxCategory = new AntdUI.Select();
            this.txtProductName = new AntdUI.Input();
            this.input1 = new AntdUI.Input();
            this.titlebar = new AntdUI.PageHeader();
            this.siticoneControlBox3 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.dtpExpDate);
            this.panel1.Controls.Add(this.dtpMfgDate);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.input1);
            this.panel1.Controls.Add(this.titlebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 661);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // panel2
            // 
            this.panel2.Back = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.uploadDragger1);
            this.panel2.Location = new System.Drawing.Point(491, 75);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 8;
            this.panel2.Size = new System.Drawing.Size(312, 283);
            this.panel2.TabIndex = 16;
            this.panel2.Text = "panel2";
            // 
            // uploadDragger1
            // 
            this.uploadDragger1.BackColor = System.Drawing.Color.Transparent;
            this.uploadDragger1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.uploadDragger1.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadDragger1.IconRatio = 2F;
            this.uploadDragger1.Location = new System.Drawing.Point(3, 198);
            this.uploadDragger1.Multiselect = false;
            this.uploadDragger1.Name = "uploadDragger1";
            this.uploadDragger1.Size = new System.Drawing.Size(306, 82);
            this.uploadDragger1.TabIndex = 17;
            this.uploadDragger1.Text = "Upload";
            this.uploadDragger1.TextDesc = "";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.DecimalPlaces = 2;
            this.txtTotalPrice.Font = new System.Drawing.Font("Satoshi", 12F);
            this.txtTotalPrice.Hexadecimal = true;
            this.txtTotalPrice.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTotalPrice.Location = new System.Drawing.Point(59, 502);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PlaceholderText = "Total Price";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(375, 55);
            this.txtTotalPrice.SuffixText = "";
            this.txtTotalPrice.TabIndex = 15;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.ThousandsSeparator = true;
            // 
            // txtPrice
            // 
            this.txtPrice.DecimalPlaces = 2;
            this.txtPrice.Font = new System.Drawing.Font("Satoshi", 12F);
            this.txtPrice.Location = new System.Drawing.Point(57, 441);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Price";
            this.txtPrice.Size = new System.Drawing.Size(375, 55);
            this.txtPrice.SuffixText = "";
            this.txtPrice.TabIndex = 14;
            this.txtPrice.Text = "1.00";
            this.txtPrice.ThousandsSeparator = true;
            this.txtPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // button1
            // 
            this.button1.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Satoshi", 12F);
            this.button1.Location = new System.Drawing.Point(166, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Satoshi", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(57, 380);
            this.txtQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "Quantity";
            this.txtQuantity.Size = new System.Drawing.Size(375, 55);
            this.txtQuantity.SuffixText = "";
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.Text = "1";
            this.txtQuantity.ThousandsSeparator = true;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Font = new System.Drawing.Font("Satoshi", 12F);
            this.dtpExpDate.Location = new System.Drawing.Point(57, 319);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.PlaceholderText = "Expiration Date";
            this.dtpExpDate.Size = new System.Drawing.Size(375, 55);
            this.dtpExpDate.TabIndex = 10;
            // 
            // dtpMfgDate
            // 
            this.dtpMfgDate.Font = new System.Drawing.Font("Satoshi", 12F);
            this.dtpMfgDate.Location = new System.Drawing.Point(57, 258);
            this.dtpMfgDate.Name = "dtpMfgDate";
            this.dtpMfgDate.PlaceholderText = "Manufacturing Date";
            this.dtpMfgDate.Size = new System.Drawing.Size(375, 55);
            this.dtpMfgDate.TabIndex = 9;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Satoshi", 12F);
            this.comboBoxCategory.Location = new System.Drawing.Point(57, 197);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.PlaceholderText = "Category";
            this.comboBoxCategory.Size = new System.Drawing.Size(375, 55);
            this.comboBoxCategory.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(57, 136);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "Product Name";
            this.txtProductName.Size = new System.Drawing.Size(375, 55);
            this.txtProductName.TabIndex = 7;
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(57, 75);
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "Product Code";
            this.input1.Size = new System.Drawing.Size(375, 55);
            this.input1.TabIndex = 6;
            // 
            // titlebar
            // 
            this.titlebar.CloseSize = 30;
            this.titlebar.Controls.Add(this.siticoneControlBox3);
            this.titlebar.Controls.Add(this.siticoneControlBox1);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.MaximizeBox = false;
            this.titlebar.Name = "titlebar";
            this.titlebar.ShowIcon = true;
            this.titlebar.Size = new System.Drawing.Size(855, 27);
            this.titlebar.SubText = "";
            this.titlebar.TabIndex = 5;
            this.titlebar.Text = "Add Product";
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneControlBox3.HoveredState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox3.Location = new System.Drawing.Point(765, -1);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox3.TabIndex = 8;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(810, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 6;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(875, 674);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductForm";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.PageHeader titlebar;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private AntdUI.Input txtProductName;
        private AntdUI.Input input1;
        private AntdUI.Select comboBoxCategory;
        private AntdUI.DatePicker dtpExpDate;
        private AntdUI.DatePicker dtpMfgDate;
        private AntdUI.InputNumber txtQuantity;
        private AntdUI.Button button1;
        private AntdUI.InputNumber txtPrice;
        private AntdUI.InputNumber txtTotalPrice;
        private AntdUI.Panel panel2;
        private AntdUI.UploadDragger uploadDragger1;
    }
}