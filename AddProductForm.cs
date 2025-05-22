using AntdUIDemo;
using Microsoft.Data.SqlClient;
using Siticone.UI.WinForms.Suite;
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
        SqlConnection _con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand _cmd = new SqlCommand();

        public AddProductForm()
        {
            InitializeComponent();
            RadiusForm();
            CalculateTotalPrice();
            LoadDay();
            LoadMonth();
            LoadYear();
            
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
            dayComboBox.SelectedIndex = -1;
            monthComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
            pictureBox.Image = null;

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

        private void LoadDay()
        {
            
            dayComboBox.SelectedIndex = 0;

            // looping from 1 to 31
            for (var i = 1; i <= 31; i++)
            {
                dayComboBox.Items.Add(i);
            }            
        }
        private void LoadMonth()
        {
            
            monthComboBox.SelectedIndex = 0;

            // looping from 1 to 12
            for (var i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i);
            }
        }
        private void LoadYear()
        {
            // looping from 2025 to 1900
            
            yearComboBox.SelectedIndex = 0;
            for (var i = 2025; i <= 2045; i++)
            {
                yearComboBox.Items.Add(i);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
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
            _cmd.Parameters.AddWithValue("@ExpDate", new DateTime(Convert.ToInt32(yearComboBox.Text), Convert.ToInt32(monthComboBox.Text), Convert.ToInt32(dayComboBox.Text)));
            _cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(quantityText));
            _cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(priceText));
            _cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(totalPriceText));
            _con.Open();
            _cmd.ExecuteNonQuery();
            _con.Close();
            // Optionally, you can clear the input fields after adding the product
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearField();

            // Refresh the DataGridView or any other UI element to show the newly added product
            // For example, you can call the method to reload the DataGridView here

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void uploadDragger_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
