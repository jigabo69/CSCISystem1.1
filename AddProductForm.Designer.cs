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
            this.input3 = new AntdUI.Input();
            this.input2 = new AntdUI.Input();
            this.input1 = new AntdUI.Input();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titlebar);
            this.panel1.Controls.Add(this.input3);
            this.panel1.Controls.Add(this.input2);
            this.panel1.Controls.Add(this.input1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 430);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // titlebar
            // 
            this.titlebar.CloseSize = 30;
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.MaximizeBox = false;
            this.titlebar.Name = "titlebar";
            this.titlebar.ShowButton = true;
            this.titlebar.ShowIcon = true;
            this.titlebar.Size = new System.Drawing.Size(780, 38);
            this.titlebar.SubText = "";
            this.titlebar.TabIndex = 5;
            this.titlebar.Text = "Add Product";
            // 
            // input3
            // 
            this.input3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input3.IconGap = 1F;
            this.input3.IconRatio = 1F;
            this.input3.Location = new System.Drawing.Point(63, 172);
            this.input3.Name = "input3";
            this.input3.PlaceholderText = "Search";
            this.input3.Size = new System.Drawing.Size(197, 42);
            this.input3.TabIndex = 4;
            this.input3.WaveSize = 1;
            // 
            // input2
            // 
            this.input2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.IconGap = 1F;
            this.input2.IconRatio = 1F;
            this.input2.Location = new System.Drawing.Point(63, 124);
            this.input2.Name = "input2";
            this.input2.PlaceholderText = "Search";
            this.input2.Size = new System.Drawing.Size(197, 42);
            this.input2.TabIndex = 3;
            this.input2.WaveSize = 1;
            // 
            // input1
            // 
            this.input1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.IconGap = 1F;
            this.input1.IconRatio = 1F;
            this.input1.Location = new System.Drawing.Point(63, 76);
            this.input1.Name = "input1";
            this.input1.PlaceholderText = "Search";
            this.input1.Size = new System.Drawing.Size(197, 42);
            this.input1.TabIndex = 2;
            this.input1.WaveSize = 1;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "AddProductForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Input input3;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.PageHeader titlebar;
    }
}