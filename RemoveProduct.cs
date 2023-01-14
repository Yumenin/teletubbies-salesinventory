using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teletubbies_Sales_and_Inventory
{
    public partial class RemoveProduct : Form
    {
        public RemoveProduct()
        {
            InitializeComponent();
        }

        private void RemoveProduct_Load(object sender, EventArgs e)
        {
            gridviewRemoveProductList.DataSource = ItemsData.Products;
            gridviewRemoveProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (currentRowIndex > -1 && ItemsData.Products.Count > 0 )
            {
                ItemsData.Products.RemoveAt(currentRowIndex);
                toolStripProgressBarCompletion.Value = 0;
                while (toolStripProgressBarCompletion.Value < 100)
                {
                    toolStripProgressBarCompletion.PerformStep();
                }
                toolStripLabelOperationStatus.Text = "Selection successfully deleted.";
                CSVOperations.UpdateCSV(ItemsData.Products, Selection.filePath);
                currentRowIndex = -1;
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
            currentRowIndex = e.RowIndex;
            toolStripLabelCurrentSelection.Text = $"Current selected row is {currentRowIndex}";
        }
    }
}
