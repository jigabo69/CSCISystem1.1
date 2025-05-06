using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCISystem1._1
{
    public partial class AddProductForm: Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            InitializeCategoryComboBox();
            RadiusForm();
            CalculateTotalPrice();
        }


        private void InitializeCategoryComboBox()
        {
            // Initialize the category combo box with some sample categories
            comboBoxCategory.Items.Add("Beverage");
            comboBoxCategory.Items.Add("Snack");
            comboBoxCategory.Items.Add("Dairy");
            comboBoxCategory.Items.Add("Bakery");
            comboBoxCategory.Items.Add("Frozen Food");
        }

        private void RadiusForm()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 18;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 272, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            Region = new Region(path);
        }

        private void CalculateTotalPrice()
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) && decimal.TryParse(txtPrice.Text, out decimal price))
            {
                decimal totalPrice = quantity * price;
                txtTotalPrice.Text = totalPrice.ToString("0.00");
            }
            else
            {
                txtTotalPrice.Text = "0.00";
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }
    }

}
