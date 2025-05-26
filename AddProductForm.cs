﻿using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using AntdUI;

namespace CSCISystem1._1
{
    public partial class AddProductForm: Form
    {
        SqlConnection _con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand _cmd = new SqlCommand();

        public AddProductForm()
        {
            InitializeComponent();
            RadiusForm();
            CalculateTotalPrice();
        }

        private void AddProductToDatabase()
        {
            var productCode = txtProductCode.Text.Trim();
            var productName = txtProductName.Text.Trim();
            var quantityText = txtQuantity.Text.Trim();
            var priceText = txtPrice.Text.Trim();
            var totalPriceText = txtTotalPrice.Text.Trim();
            if (string.IsNullOrEmpty(productCode) || string.IsNullOrEmpty(productName) ||
                string.IsNullOrEmpty(quantityText) || string.IsNullOrEmpty(priceText) ||
                string.IsNullOrEmpty(totalPriceText))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Add your logic to save the product information to the database here
            var query = "INSERT INTO tb_product (ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice) " +
                        "VALUES (@ProductCode, @ProductName, @ExpDate, @Quantity, @Price, @TotalPrice)";
            _cmd = new SqlCommand(query, _con);
            _cmd.Parameters.AddWithValue("@ProductCode", productCode);
            _cmd.Parameters.AddWithValue("@ProductName", productName);

            _cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(quantityText));
            _cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(priceText));
            _cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(totalPriceText));
            _con.Open();
            _cmd.ExecuteNonQuery();
            _con.Close();
            // Optionally, you can clear the input fields after adding the product
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearField();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            ClearField();
        }
        private void ClearField()
        {
            txtPrice.Clear();
            txtProductCode.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();
            datePicker = null;
            pictureBoxAddProduct.Image = null;
            txtProductCode.Focus();
        }

        private void RadiusForm()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            var radius = 18;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 272, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            Region = new Region(path);
        }

        private void CalculateTotalPrice()
        {
            var quantityText = txtQuantity.Text.Trim();
            var priceText = txtPrice.Text.Trim();

            if (int.TryParse(quantityText, out var quantity) &&
                decimal.TryParse(priceText, out var price) &&
                quantity > 0 && price > 0)
            {
                var totalPrice = quantity * price;
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
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProductToDatabase();
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                pictureBoxAddProduct.Image = Image.FromFile(openFileDialog.FileName);
                pictureBoxAddProduct.ImageFit = TFit.Cover;
            }
        }
    }
}
