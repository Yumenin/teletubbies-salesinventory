using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teletubbies_Sales_and_Inventory
{
    public partial class RemoveProduct : Form
    {
        int selectedProductId = -1;
        public RemoveProduct()
        {
            InitializeComponent();
        }

        private void RemoveProduct_Load(object sender, EventArgs e)
        {
            gridviewRemoveProductList.DataSource = ItemsData.Inventory;
            gridviewRemoveProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedProductId >= 0)
            {
                SQL.conn.Open();
                SqlCommand cmd = SQL.conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM Products WHERE productID = {selectedProductId}";
                cmd.ExecuteNonQuery();
                SQL.conn.Close();
                ItemsData.addDeletedID(selectedProductId);
                ItemsData.updateDeletedIDList();
                SQL.RefreshGridView();
                InventoryManagerWindow.InventoryManagerWindow_Instance.gridviewProductList.DataSource = ItemsData.Inventory;
                gridviewRemoveProductList.DataSource = ItemsData.Inventory;
                toolStripProgressBarCompletion.Value = 0;
                while (toolStripProgressBarCompletion.Value < 100)
                {
                    toolStripProgressBarCompletion.PerformStep();
                }
                toolStripLabelOperationStatus.Text = "Selection successfully deleted.";
                selectedProductId = -1;
                toolStripLabelCurrentSelection.Text = "No cell currently selected.";
            }
            else
            {
                MessageBox.Show("Please choose a cell row to remove.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripLabelCurrentSelection.Text = "No cell currently selected.";
                toolStripLabelOperationStatus.Text = "Selection deletion failed.";
            }
        }

        private void gridviewRemoveProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProductId = (int) gridviewRemoveProductList.Rows[e.RowIndex].Cells[0].Value;
            toolStripLabelCurrentSelection.Text = $"Current selected ID is {selectedProductId}";
        }
    }
}
