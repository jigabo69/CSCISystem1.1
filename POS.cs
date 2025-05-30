﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Microsoft.Data.SqlClient;
using CSCISystem1._1;

namespace AntdUIDemo
{
    public partial class POS : AntdUI.Window
    {
        private bool isRemovingItem = false;
        private bool eventHandlersAttached = false;
        // This is your global connection string

        SqlConnection con = new SqlConnection(@"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        public POS()
        {
            InitializeComponent();
            LoadMoP();
        }

        private void LoadMoP()
        {
            mopDropdown.Items.Add("Cash");
            mopDropdown.SelectedIndex = 0;
        }

        private void LoadCartHeader()
        {
            siticoneDataGridView2.Columns.Clear();
            siticoneDataGridView2.Rows.Clear();
            siticoneDataGridView2.Columns.Add("ItemName", "Item");
            siticoneDataGridView2.Columns.Add("Qty", "Qty.");
            siticoneDataGridView2.Columns.Add("Price", "Price");
        }

        private void POS_Load(object sender, EventArgs e)
        {
            if (!eventHandlersAttached)
            {
                txtCash.TextChanged += txtCash_TextChanged;
                //button2.Click += RemoveVoidBtn;
                button1.Click += button1_Click;

                eventHandlersAttached = true;
            }

            txtSearchItem.Focus();
            LoadReceipt();
            LoadProductDataHeader();
            LoadProductDatabase();
            LoadCartHeader();

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
            gridDataProductList.Columns.Add("Quantity", "Stock");
            gridDataProductList.Columns.Add("Price", "Unit Price");
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "ImageProduct";
            imgCol.HeaderText = "              Image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            gridDataProductList.Columns.Add(imgCol);
        }
        // added by zeus pogi

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCash.Text, out decimal cash))
            {
                decimal total = decimal.Parse(input6.Text.Replace("₱", ""));
                decimal change = cash - total;
                input3.Text = "₱" + (change >= 0 ? change.ToString("0.00") : "0.00");
            }
            else
            {
                input3.Text = "₱0.00";
            }
        }

        private void UpdateTotals()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in siticoneDataGridView2.Rows)
            {
                if (row.Cells["Price"].Value != null && decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price))
                {
                    subtotal += price;
                }
            }

            decimal tax = subtotal * 0.12m;
            decimal total = subtotal + tax;

            input4.Text = "₱" + subtotal.ToString("0.00"); // Subtotal
            input5.Text = "₱" + tax.ToString("0.00");     // Tax
            input6.Text = "₱" + total.ToString("0.00");   // Total
        }

        private void gridDataProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string name = gridDataProductList.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                decimal price = Convert.ToDecimal(gridDataProductList.Rows[e.RowIndex].Cells["Price"].Value);

                // Get available stock from grid
                // You must ensure Quantity is added as a column in gridDataProductList
                int availableQty = 0;
                if (gridDataProductList.Columns.Contains("Quantity"))
                {
                    availableQty = Convert.ToInt32(gridDataProductList.Rows[e.RowIndex].Cells["Quantity"].Value);
                }
                else
                {
                    MessageBox.Show("Quantity column not found in grid.");
                    return;
                }

                bool found = false;
                foreach (DataGridViewRow row in siticoneDataGridView2.Rows)
                {
                    if (row.Cells["ItemName"].Value?.ToString() == name)
                    {
                        int qtyInCart = Convert.ToInt32(row.Cells["Qty"].Value);
                        if (qtyInCart + 1 > availableQty)
                        {
                            MessageBox.Show("Cannot add more. Stock limit reached.");
                            return;
                        }

                        row.Cells["Qty"].Value = qtyInCart + 1;
                        row.Cells["Price"].Value = (qtyInCart + 1) * price;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    if (availableQty < 1)
                    {
                        MessageBox.Show("Out of stock.");
                        return;
                    }

                    siticoneDataGridView2.Rows.Add(name, 1, price);
                }
                UpdateTotals();
            }
        }

        private void LoadProductDatabase()
        {
            // --- CHANGE THIS LINE ---
            // Use your local computer name: LAPTOP-JCLJ6T4H
            using (SqlConnection localCon = new SqlConnection(@"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                try
                {
                    localCon.Open();
                    string query = "SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice, Image FROM tb_product";

                    using (SqlCommand cmd = new SqlCommand(query, localCon))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        gridDataProductList.Rows.Clear(); // clear existing rows
                        while (reader.Read())
                        {
                            object imageObj = reader["Image"];
                            Image img = null;

                            if (imageObj != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])imageObj;
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    img = Image.FromStream(ms);
                                }
                            }

                            gridDataProductList.Rows.Add(
                                reader["ProductCode"].ToString(),
                                reader["ProductName"].ToString(),
                                reader["Quantity"].ToString(),
                                reader["Price"].ToString(),
                                img
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Step 1: Check payment method
            if (mopDropdown.SelectedValue == null) // safer than .SelectedValue
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            // Step 2: Check cash input
            if (!decimal.TryParse(txtCash.Text, out decimal cash))
            {
                MessageBox.Show("Invalid cash amount.");
                return;
            }

            decimal total = decimal.Parse(input6.Text.Replace("₱", ""));
            if (cash < total)
            {
                MessageBox.Show("Insufficient cash.");
                return;
            }

            foreach (DataGridViewRow row in siticoneDataGridView2.Rows)
            {
                if (row.Cells["ItemName"].Value != null)
                {
                    string name = row.Cells["ItemName"].Value.ToString();
                    int qty = Convert.ToInt32(row.Cells["Qty"].Value);
                    double unitPrice = 0;

                    // Find the unit price from the product list
                    foreach (DataGridViewRow gridRow in gridDataProductList.Rows)
                    {
                        if (gridRow.Cells["ProductName"].Value?.ToString() == name)
                        {
                            unitPrice = Convert.ToDouble(gridRow.Cells["Price"].Value);
                            break;
                        }
                    }

                    InventoryReport.AddSoldItem(name, qty, unitPrice);
                }
            }


            // Step 3: Update database
            try
            {
                con.Open(); // This uses the global 'con' connection

                foreach (DataGridViewRow row in siticoneDataGridView2.Rows)
                {
                    string productName = row.Cells["ItemName"].Value.ToString();
                    int qtyPurchased = Convert.ToInt32(row.Cells["Qty"].Value);
                    double unitPrice = Convert.ToDouble(row.Cells["Price"].Value) / qtyPurchased; // Calculate unit price

                    string updateQuery = @"
                        UPDATE tb_product
                        SET Quantity = Quantity - @Qty
                        WHERE ProductName = @Name AND Quantity >= @Qty";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Qty", qtyPurchased);
                        cmd.Parameters.AddWithValue("@Name", productName);
                        


                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show($"Error updating stock for {productName}. It may be out of stock.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message);
            }
            finally
            {
                // Make sure the connection is closed even if there's an error
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }

            // Step 4: Clear UI and reload stock
            MessageBox.Show("Payment Successful!");
            siticoneDataGridView2.Rows.Clear();
            txtCash.Text = "";
            input3.Text = "₱0.00";
            UpdateTotals();
            LoadProductDatabase(); // Reload product list with updated stock
        }

        private void RemoveVoidBtn(object sender, EventArgs e)
        {
            AdminLogin loginForm = new AdminLogin();
            DialogResult result = loginForm.ShowDialog();

            if (result == DialogResult.OK && loginForm.IsAuthenticated)
            {
                foreach (DataGridViewRow row in siticoneDataGridView2.SelectedRows)
                {
                    siticoneDataGridView2.Rows.Remove(row);
                }

                MessageBox.Show("Item removed by admin.");
                UpdateTotals();
            }
            else
            {
                MessageBox.Show("Action canceled or unauthorized.", "Not Authorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
    
