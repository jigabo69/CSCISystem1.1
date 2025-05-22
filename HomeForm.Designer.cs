namespace CSCISystem1._1
{
    partial class HomeForm
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
            AntdUI.CarouselItem carouselItem1 = new AntdUI.CarouselItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            AntdUI.CarouselItem carouselItem2 = new AntdUI.CarouselItem();
            this.panel1 = new AntdUI.Panel();
            this.carousel1 = new AntdUI.Carousel();
            this.labelTime1 = new AntdUI.LabelTime();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneLabel1);
            this.panel1.Controls.Add(this.labelTime1);
            this.panel1.Controls.Add(this.carousel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Radius = 20;
            this.panel1.Size = new System.Drawing.Size(1047, 769);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel1";
            // 
            // carousel1
            // 
            this.carousel1.DotMargin = 20;
            this.carousel1.DotPosition = AntdUI.TAlignMini.Top;
            this.carousel1.DotSize = new System.Drawing.Size(30, 6);
            carouselItem1.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem1.Img")));
            carouselItem2.Img = ((System.Drawing.Image)(resources.GetObject("carouselItem2.Img")));
            this.carousel1.Image.Add(carouselItem1);
            this.carousel1.Image.Add(carouselItem2);
            this.carousel1.Location = new System.Drawing.Point(78, 181);
            this.carousel1.Name = "carousel1";
            this.carousel1.Radius = 6;
            this.carousel1.SelectIndex = 1;
            this.carousel1.Size = new System.Drawing.Size(903, 473);
            this.carousel1.TabIndex = 2;
            this.carousel1.Text = "carousel1";
            // 
            // labelTime1
            // 
            this.labelTime1.BackColor = System.Drawing.Color.Transparent;
            this.labelTime1.Location = new System.Drawing.Point(833, 37);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(135, 32);
            this.labelTime1.TabIndex = 3;
            this.labelTime1.Text = "labelTime1";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Satoshi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(78, 37);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(67, 32);
            this.siticoneLabel1.TabIndex = 10;
            this.siticoneLabel1.Text = "Home";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1047, 769);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Carousel carousel1;
        private AntdUI.LabelTime labelTime1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
    }
}