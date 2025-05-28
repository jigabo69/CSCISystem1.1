using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Microsoft.Data.SqlClient;

namespace AntdUIDemo
{
    public partial class POS : AntdUI.Window
    {
        SqlConnection con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand cmd;

        public POS()
        {
            InitializeComponent();
            LoadMoP();

        }

        private void LoadMoP()
        {
            mopDropdown.Items.Add("Cash");

        }

        private void POS_Load(object sender, EventArgs e)
        {
            txtSearchItem.Focus();
            LoadReceipt();
            LoadProductDataHeader();
            LoadProductDatabase();
        }

        private void LoadReceipt()
        {
            receiptTextBox.Clear();
            receiptTextBox.Text += "Address: Legazpi City \n";
            receiptTextBox.Text += "Tel: 999-685-0001\n";
            receiptTextBox.Text += "-----------------------------------------\n";
            receiptTextBox.Text += "Date: " + DateTime.Now + "\n";
            receiptTextBox.Text += "-----------------------------------------\n\n";
            receiptTextBox.Text += "Item\t\t" + "Qty.\t\t" + "Price\t\n";
            receiptTextBox.Text += "-----------------------------------------\n";
        }

        private void LoadProductDataHeader()
        {
            gridDataProductList.Columns.Clear();
            gridDataProductList.Rows.Clear();

            gridDataProductList.Columns.Add("ProductCode", "Item Code");
            gridDataProductList.Columns.Add("ProductName", "Item Name");
            gridDataProductList.Columns.Add("Price", "Unit Price");
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "ImageProduct";
            imgCol.HeaderText = "                      Image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            gridDataProductList.Columns.Add(imgCol);

        }

        private void LoadProductDatabase()
        {
            try
            {
                con.Open();
                string query = "SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice, Image FROM tb_product";
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gridDataProductList.Rows.Add(
                        reader["ProductCode"].ToString(),
                        reader["ProductName"].ToString(),
                        reader["Price"].ToString(),
                        reader["Image"] != DBNull.Value ? Image.FromStream(new MemoryStream((byte[])reader["Image"])) : null
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
