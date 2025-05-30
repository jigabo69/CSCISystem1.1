using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CSCISystem1._1
{
    public partial class InventoryReport : Form
    {
        private static DataTable soldItemsTable = new DataTable();
        private static DataTable removedItemsTable = new DataTable();

        private static string connectionString = "Data Source=EMMAN\\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlConnection con = new SqlConnection(@"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        SqlCommand cmd;
        static InventoryReport()
        {
            if (soldItemsTable.Columns.Count == 0)
            {
                soldItemsTable.Columns.Add("Item Name", typeof(string));
                soldItemsTable.Columns.Add("Quantity", typeof(int));
                soldItemsTable.Columns.Add("Date Sold", typeof(DateTime));
                soldItemsTable.Columns.Add("Unit Price", typeof(double));
            }

            if (removedItemsTable.Columns.Count == 0)
            {
                removedItemsTable.Columns.Add("Item Code", typeof(string));
                removedItemsTable.Columns.Add("Item Name", typeof(string));
                removedItemsTable.Columns.Add("Quantity", typeof(int));
                removedItemsTable.Columns.Add("Unit Price", typeof(double));
                removedItemsTable.Columns.Add("Expiration Date", typeof(DateTime));
                removedItemsTable.Columns.Add("Date Removed", typeof(DateTime));
            }
        }

        public InventoryReport()
        {
            InitializeComponent();
            gridViewSoldList.DataSource = soldItemsTable;
            gridViewRemovedList.DataSource = removedItemsTable;
            LoadFilterSoldItem();
            LoadFilterRemovedItem();

        }

        private void LoadFilterSoldItem()
        {
            filterSoldItem.Items.Add("All");
            filterSoldItem.Items.Add("Today");
            filterSoldItem.Items.Add("Last 7 Days");
            filterSoldItem.Items.Add("Last 30 Days");
            

        }

        private void LoadFilterRemovedItem()
        {
            filterRemovedItem.Items.Add("All");
        }

        public static void AddSoldItem(string itemName, int quantity, double unitPrice)
        {
            soldItemsTable.Rows.Add(itemName, quantity, DateTime.Now, unitPrice);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tb_soldItems (ItemName, Quantity, DateSold, UnitPrice) VALUES (@ItemName, @Quantity, @DateSold, @UnitPrice)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@DateSold", DateTime.Now);
                    cmd.Parameters.AddWithValue("@UnitPrice",unitPrice);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void AddRemovedItem(string itemCode, string itemName, int quantity, double unitPrice, DateTime expirationDate)
        {
            removedItemsTable.Rows.Add(itemCode, itemName, quantity, unitPrice, expirationDate, DateTime.Now);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO tb_removedItems 
                         (ItemCode, ItemName, Quantity, UnitPrice, ExpirationDate, DateRemoved) 
                         VALUES (@ItemCode, @ItemName, @Quantity, @UnitPrice, @ExpirationDate, @DateRemoved)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ItemCode", itemCode);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    cmd.Parameters.AddWithValue("@DateRemoved", DateTime.Now);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            LoadSoldItemsFromDB();
            LoadRemovedItemsFromDB();
        }

        private void LoadSoldItemsFromDB()
        {
            soldItemsTable.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ItemName, Quantity, DateSold, UnitPrice FROM tb_soldItems";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            soldItemsTable.Rows.Add(
                                reader["ItemName"],
                                reader["Quantity"],
                                reader["DateSold"],
                                reader["UnitPrice"]
                            );

                        }
                    }
                }
            }
        }

        private void LoadRemovedItemsFromDB()
        {
            removedItemsTable.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ItemCode, ItemName, Quantity, UnitPrice, ExpirationDate, DateRemoved FROM tb_removedItems";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            removedItemsTable.Rows.Add(
                                reader["ItemCode"],
                                reader["ItemName"],
                                reader["Quantity"],
                                reader["UnitPrice"],
                                reader["ExpirationDate"],
                                reader["DateRemoved"]
                            );
                        }
                    }
                }
            }
        }

        private void txtSearchSoldItem_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtSearchSoldItem.Text.Trim());
        }

        private void txtSearchRemovedItem_TextChanged(object sender, EventArgs e)
        {
            SearchRemovedItem(txtSearchRemovedItem.Text.Trim());
        }

        private void SearchProducts(string searchText)
        {
            try
            {
                gridViewSoldList.Rows.Clear();
                con.Open();

                string query = "";
                string column = "";

                if (filterSoldItem.SelectedValue == null || filterSoldItem.SelectedValue.ToString() == "All")
                {
                    query = @"SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice
                      FROM tb_product
                      WHERE ProductCode LIKE @search OR ProductName LIKE @search";
                }
                else
                {
                    column = filterSoldItem.SelectedValue.ToString();
                    query = $@"SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice
                       FROM tb_product
                       WHERE {column} LIKE @search";
                }

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gridViewSoldList.Rows.Add(
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
                MessageBox.Show("Search error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void SearchRemovedItem(string searchTxt)
        {
            try
            {
                gridViewRemovedList.Rows.Clear();
                con.Open();
                string query = @"SELECT ItemCode, ItemName, Quantity, UnitPrice, ExpirationDate, DateRemoved 
                                 FROM tb_removedItems 
                                 WHERE ItemCode LIKE @search OR ItemName LIKE @search";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", "%" + searchTxt + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gridViewRemovedList.Rows.Add(
                        reader["ItemCode"].ToString(),
                        reader["ItemName"].ToString(),
                        reader["Quantity"].ToString(),
                        reader["UnitPrice"].ToString(),
                        Convert.ToDateTime(reader["ExpirationDate"]).ToString("yyyy-MM-dd"),
                        Convert.ToDateTime(reader["DateRemoved"]).ToString("yyyy-MM-dd")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }



    }
}