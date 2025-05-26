using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CSCISystem1._1
{
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand cmd;
        public Product()
        {
            InitializeComponent();
            InitializeDataGridView();
        }



        private void InitializeDataGridView()
        {
            gridViewProductList.Columns.Clear();
            gridViewProductList.Rows.Clear();
            

            gridViewProductList.Columns.Add("ProductCode", "Item Code");
            gridViewProductList.Columns.Add("ProductName", "Item Name");
            gridViewProductList.Columns.Add("ExpDate", "Expiration Date");
            gridViewProductList.Columns.Add("Quantity", "Qty");
            gridViewProductList.Columns.Add("Price", "Unit Price");
            gridViewProductList.Columns.Add("TotalPrice", "Total Price");

            // Add Edit button
            var editButton = new DataGridViewButtonColumn
            {
                Name = "EditAction",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                HeaderText = "Edit",
                
            };
            gridViewProductList.Columns.Add(editButton);

            // Add Delete button
            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteAction",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                HeaderText = "Delete",
                
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

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            InitializeDataGridView();

        }

        private void gridViewProductList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string productCode = gridViewProductList.Rows[e.RowIndex].Cells["ProductCode"].Value.ToString();

            if (gridViewProductList.Columns[e.ColumnIndex].Name == "EditAction")
            {
                // Assume AddProductForm has a constructor for editing:
                // public AddProductForm(string productCode)
                AddProductForm editForm = new AddProductForm();
                editForm.ShowDialog();
                

                // Reload after editing
                InitializeDataGridView();
            }
            else if (gridViewProductList.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {productCode}?",
                    "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteProductFromDatabase(productCode);
                    gridViewProductList.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
