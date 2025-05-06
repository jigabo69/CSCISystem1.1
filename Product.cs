using Inventory;
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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            
            gridViewProductList.Columns.Add("ProductCode", "Product Code");
            gridViewProductList.Columns.Add("ProductName", "Product Name");
            gridViewProductList.Columns.Add("Category", "Category");
            gridViewProductList.Columns.Add("MfgDate", "Manufacturing Date");
            gridViewProductList.Columns.Add("ExpDate", "Expiration Date");
            gridViewProductList.Columns.Add("Quantity", "Qty.");
            gridViewProductList.Columns.Add("Price", "Price (per item)");
            gridViewProductList.Columns.Add("TotalPrice", "Total Price");




            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.AllowUserToAddRows = false;

            gridViewProductList.Rows.Add("P001", "Coke 1.5L", "Beverage", "2025-01-01", "2028-04-01", "1", "100.00", "100.00");
            gridViewProductList.Rows.Add("P002", "Pepsi 1.5L", "Beverage", "2025-01-01", "2028-04-01", "5", "100.00", "500.00");
        }
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }
    }
}
