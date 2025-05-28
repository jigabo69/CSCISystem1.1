
namespace CSCISystem1._1
{
    partial class SalesReport
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

        private void InitializeComponent()
        {
            InitializeComponent(cartesianChart1);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(LiveCharts.WinForms.CartesianChart cartesianChart1)
        {
            this.panel1 = new AntdUI.Panel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();

            this.panel1.SuspendLayout();
            this.SuspendLayout();

            //
            // panel1
            //

            // Fix: Add 'this.' before cartesianChart1
           
            this.panel1.Controls.Add(this.siticoneLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Radius = 20;
            this.panel1.Size = new System.Drawing.Size(920, 618);
            this.panel1.TabIndex = 3;
            this.panel1.Text = "panel1";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Satoshi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(78, 37);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(136, 32);
            this.siticoneLabel1.TabIndex = 10;
            this.siticoneLabel1.Text = "Sales Report";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.Transparent;
            this.cartesianChart1.Location = new System.Drawing.Point(39, 273);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(842, 318);
            this.cartesianChart1.TabIndex = 11;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 618);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Panel panel1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
   
    }
}

namespace LiveChartsCore
{
    class SkiaSharpView
    {
        internal class WinForms
        {
            internal class CartesianChart : LiveCharts.WinForms.CartesianChart
            {
            }
        }
    }
}