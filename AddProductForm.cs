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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    ProductClass newProduct = new ProductClass(
                        txtProductName.Text,
                        comboBoxCategory.Text,
                        dtpMfgDate.Value.ToString("yyyy-MM-dd"),
                        dtpExpDate.Value.ToString("yyyy-MM-dd"),
                        Convert.ToDouble(txtPrice.Text),
                        Convert.ToInt32(txtQuantity.Text),
                        txtDescription.Text
                    );

                    // Add to the main product list
                    if (Application.OpenForms["Product"] is Product productForm)
                    {
                        productForm.AddProductToList(newProduct);
                    }

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpExpDate.Value <= dtpMfgDate.Value)
            {
                MessageBox.Show("Expiration date must be after manufacturing date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }

}
