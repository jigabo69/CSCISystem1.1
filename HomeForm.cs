using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CSCISystem1._1
{
    public partial class HomeForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, System.EventArgs e)
        {
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            try
            {
                con.Open();

                // Total Products (distinct ItemCodes in inventory)
                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM tb_product", con);
                int totalProducts = (int)cmd1.ExecuteScalar();
                labelTotalProducts.Text = ("Across " + totalProducts.ToString() + " products");

                // Total Inventory Value (sum of Quantity * UnitPrice)
                SqlCommand cmd2 = new SqlCommand("SELECT SUM(Quantity * UnitPrice) FROM tb_soldItems", con);
                object valueObj = cmd2.ExecuteScalar();
                decimal totalValue = valueObj != DBNull.Value ? Convert.ToDecimal(valueObj) : 0;
                labelTotalInventoryValue.Text = $"Php {totalValue:N2}";

                // Total Quantity of Items (sum of all item quantities)
                SqlCommand cmd3 = new SqlCommand("SELECT SUM(Quantity) FROM tb_product", con);
                object qtyObj = cmd3.ExecuteScalar();
                int totalQty = qtyObj != DBNull.Value ? Convert.ToInt32(qtyObj) : 0;
                labelQuantityOfItems.Text = ("Units in inventory " + totalQty.ToString());

                // Total Sold Items (sum of Quantity in sold items table)
                SqlCommand cmd4 = new SqlCommand("SELECT SUM(Quantity) FROM tb_soldItems", con);
                object soldObj = cmd4.ExecuteScalar();
                int totalSold = soldObj != DBNull.Value ? Convert.ToInt32(soldObj) : 0;
                labelTotalItems.Text = totalSold.ToString();

                // Out of Stock Items (items with Quantity = 0)
                SqlCommand cmd5 = new SqlCommand("SELECT COUNT(*) FROM tb_product WHERE Quantity = 0", con);
                int outOfStock = (int)cmd5.ExecuteScalar();
                LabelOutOfStock.Text = outOfStock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
