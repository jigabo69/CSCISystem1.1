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
            gridViewProductList.Columns.Add("Price", "Price");
            
            
            
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.AllowUserToAddRows = false;
        }
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }
    }
}
