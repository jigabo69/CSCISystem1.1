using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Management; // Not directly used in snippets, but kept
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Vanara.PInvoke; // Not directly used in snippets, but kept

namespace CSCISystem1._1
{
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-JCLJ6T4H\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;TrustServerCertificate=True");

        SqlCommand cmd;

        public Product()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadFilter();
            labelAction.Text = "Action";
        }

        private void InitializeDataGridView()
        {
            gridViewProductList.Columns.Clear();
            gridViewProductList.Rows.Clear();

            // IMPORTANT: The first string is the INTERNAL NAME (Name property) of the column.
            // The second string is the DISPLAY TEXT (HeaderText) of the column.
            // Your row.Cells["ColumnName"] access uses the INTERNAL NAME.
            gridViewProductList.Columns.Add("ProductCode", "Item Code");
            gridViewProductList.Columns.Add("ProductName", "Item Name");
            gridViewProductList.Columns.Add("ExpDate", "Expiration Date"); // Corrected for consistency below
            gridViewProductList.Columns.Add("Quantity", "Qty");
            gridViewProductList.Columns.Add("Price", "Unit Price");
            gridViewProductList.Columns.Add("TotalPrice", "Total Price");

            //edit button
            var editButton = new DataGridViewImageColumn
            {
                Name = "EditAction",
                HeaderText = "", // We'll set a label over it later
                                 // Image = Image.FromFile(@"C:\Users\emman\Downloads\Icon\edit-20.png"),
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            gridViewProductList.Columns.Add(editButton);

            //delete button
            var deleteButton = new DataGridViewImageColumn
            {
                Name = "DeleteAction",
                HeaderText = "",
                //Image = Image.FromFile(@"C:\Users\emman\Downloads\Icon\delete-20.png"),
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            gridViewProductList.Columns.Add(deleteButton);

            LoadProductData();
        }

        private void LoadProductData()
        {
            try
            {
                con.Open();
                string query = "SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice FROM tb_product";
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gridViewProductList.Rows.Add(
                        reader["ProductCode"].ToString(),
                        reader["ProductName"].ToString(),
                        Convert.ToDateTime(reader["ExpDate"]).ToString("yyyy-MM-dd"),
                        reader["Quantity"].ToString(),
                        reader["Price"].ToString(),
                        reader["TotalPrice"].ToString()
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

        private void DeleteProductFromDatabase(string productCode)
        {
            try
            {
                con.Open();
                string deleteQuery = "DELETE FROM tb_product WHERE ProductCode = @ProductCode";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                deleteCmd.Parameters.AddWithValue("@ProductCode", productCode);
                deleteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadFilter()
        {
            filter.Items.Add("Date");
            filter.Items.Add("Item Code");
            filter.Items.Add("Item Name");
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            InitializeDataGridView();
        }

        private void gridViewProductList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked and it's the "DeleteAction" column
            if (e.RowIndex >= 0 && gridViewProductList.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                // Get the clicked row
                var row = gridViewProductList.Rows[e.RowIndex];

                // Get product data from the DataGridView cells.
                // THESE NAMES MUST MATCH THE FIRST STRING (NAME) OF THE COLUMNS ADDED IN InitializeDataGridView().
                // Also, ensure they match the InventoryReport.AddRemovedItem parameter order.
                string itemCode = row.Cells["ProductCode"].Value.ToString(); // Changed: "ItemCode" to "ProductCode"
                string itemName = row.Cells["ProductName"].Value.ToString(); // Changed: "ItemName" to "ProductName"
                int qty = int.Parse(row.Cells["Quantity"].Value.ToString());
                double unitPrice = double.Parse(row.Cells["Price"].Value.ToString()); // Changed: "UnitPrice" to "Price"
                DateTime expDate = DateTime.Parse(row.Cells["ExpDate"].Value.ToString()); // Changed: "ExpirationDate" to "ExpDate"

                // Send to InventoryReport.cs
                // This call uses the parameters that match InventoryReport's AddRemovedItem
                InventoryReport.AddRemovedItem(itemCode, itemName, qty, unitPrice, expDate);

                // Confirm and remove from grid
                DialogResult result = MessageBox.Show($"Are you sure you want to remove {itemName}?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    gridViewProductList.Rows.RemoveAt(e.RowIndex);
                    // Also delete from database if that's the intended action here
                    // DeleteProductFromDatabase(itemCode);
                }
            }
        }

        private void breadcrumb1_ItemClick(object sender, AntdUI.BreadcrumbItemEventArgs e)
        {
            if (e.Item.Text == "Home")
            {
                this.Close();
            }
        }
    }
}