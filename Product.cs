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
    public partial class Product: Form
    {
        public Product()
        {
            InitializeComponent();
            //showProductList = new BindingSource();
        }


        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            addProduct.ShowDialog();

        }
    }
}
