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
            this.titlebar = new AntdUI.PageHeader();
            this.siticoneControlBox3 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.input1 = new AntdUI.Input();
            this.input2 = new AntdUI.Input();
            this.select1 = new AntdUI.Select();
            this.datePicker1 = new AntdUI.DatePicker();
            this.datePicker2 = new AntdUI.DatePicker();
            this.txtQuantity = new AntdUI.InputNumber();
            this.button1 = new AntdUI.Button();
            this.txtPrice = new AntdUI.InputNumber();
            this.txtTotalPrice = new AntdUI.InputNumber();
            this.panel1.SuspendLayout();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.datePicker2);
            this.panel1.Controls.Add(this.datePicker1);
            this.panel1.Controls.Add(this.select1);
            this.panel1.Controls.Add(this.input2);
            this.panel1.Controls.Add(this.input1);
            this.panel1.Controls.Add(this.titlebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 661);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
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
            this.titlebar.Size = new System.Drawing.Size(479, 27);
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
            this.siticoneControlBox3.Location = new System.Drawing.Point(389, -1);
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
            this.siticoneControlBox1.Location = new System.Drawing.Point(434, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 6;
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
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(57, 136);
            this.input2.Name = "input2";
            this.input2.PlaceholderText = "Product Name";
            this.input2.Size = new System.Drawing.Size(375, 55);
            this.input2.TabIndex = 7;
            // 
            // select1
            // 
            this.select1.Font = new System.Drawing.Font("Satoshi", 12F);
            this.select1.Location = new System.Drawing.Point(57, 197);
            this.select1.Name = "select1";
            this.select1.PlaceholderText = "Category";
            this.select1.Size = new System.Drawing.Size(375, 55);
            this.select1.TabIndex = 8;
            // 
            // datePicker1
            // 
            this.datePicker1.Font = new System.Drawing.Font("Satoshi", 12F);
            this.datePicker1.Location = new System.Drawing.Point(57, 258);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.PlaceholderText = "Manufacturing Date";
            this.datePicker1.Size = new System.Drawing.Size(375, 55);
            this.datePicker1.TabIndex = 9;
            // 
            // datePicker2
            // 
            this.datePicker2.Font = new System.Drawing.Font("Satoshi", 12F);
            this.datePicker2.Location = new System.Drawing.Point(57, 319);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.PlaceholderText = "Expiration Date";
            this.datePicker2.Size = new System.Drawing.Size(375, 55);
            this.datePicker2.TabIndex = 10;
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
            this.txtQuantity.ThousandsSeparator = true;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
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
            this.txtPrice.ThousandsSeparator = true;
            this.txtPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
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
            this.txtTotalPrice.ThousandsSeparator = true;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(499, 674);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductForm";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.panel1.ResumeLayout(false);
            this.titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.PageHeader titlebar;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.Select select1;
        private AntdUI.DatePicker datePicker2;
        private AntdUI.DatePicker datePicker1;
        private AntdUI.InputNumber txtQuantity;
        private AntdUI.Button button1;
        private AntdUI.InputNumber txtPrice;
        private AntdUI.InputNumber txtTotalPrice;
    }
}