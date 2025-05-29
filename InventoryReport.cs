using System;
using System.Data;
using System.Windows.Forms;

namespace CSCISystem1._1
{
    public partial class InventoryReport : Form
    {
        private static DataTable soldItemsTable = new DataTable();
        private static DataTable removedItemsTable = new DataTable();

        private static string connectionString = "Data Source=LAPTOP-JCLJ6T4HS\\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        static InventoryReport()
        {
            if (soldItemsTable.Columns.Count == 0)
            {
                soldItemsTable.Columns.Add("Item Name", typeof(string));
                soldItemsTable.Columns.Add("Quantity", typeof(int));
                soldItemsTable.Columns.Add("Date Sold", typeof(DateTime));
            }

            if (removedItemsTable.Columns.Count == 0)
            {
                removedItemsTable.Columns.Add("Item Name", typeof(string));
                removedItemsTable.Columns.Add("Quantity", typeof(int));
                removedItemsTable.Columns.Add("Date Removed", typeof(DateTime));
            }
        }

        public InventoryReport()
        {
            InitializeComponent();
            gridViewUserList.DataSource = soldItemsTable;
            siticoneDataGridView1.DataSource = removedItemsTable;
        }



        public static void AddSoldItem(string itemName, int quantity)
        {
            soldItemsTable.Rows.Add(itemName, quantity, DateTime.Now);
        }

        public static void AddRemovedItem(string itemName, int quantity)
        {
            removedItemsTable.Rows.Add(itemName, quantity, DateTime.Now);
        }
    }
}