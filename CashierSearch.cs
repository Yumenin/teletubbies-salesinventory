using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teletubbies_Sales_and_Inventory
{
    public partial class CashierSearch : Form
    {
        private int selectedIndex = -1;

        DataGridViewRow selectedItem;
        DataTable? CashierDataTable = Cashier.cartItems;
        public CashierSearch()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CashierSearch_Load(object sender, EventArgs e)
        {
            CashierDataTable = ItemsData.Inventory.Copy();
            CashierDataTable.Clear();
            SQL.RefreshGridView();
            searchProductGridView.DataSource = ItemsData.Inventory;
            searchProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            /* ListViewItem productTest = new ListViewItem(testProduct);*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateGridView();
        }


        private void updateGridView()
        {
            searchProductGridView.DataSource = ItemsData.Inventory;

            if (txtSearchInquiry.Text != null)
            {
                string SearchBoxQuery = txtSearchInquiry.Text;
                DataTable tableTest = ItemsData.Inventory.Copy();
                tableTest.Clear();
                var rowQuery2 = searchProductGridView.Rows.Cast<DataGridViewRow>()
                    .Where(row => (row.Cells[1].Value != null));


                foreach (var something in rowQuery2)
                {
                    if (something.Cells["productName"].Value.ToString().ToLower().Contains(SearchBoxQuery.ToLower())
                        || something.Cells["productID"].Value.ToString().Contains(txtSearchInquiry.Text))
                    {
                        // MessageBox.Show("Trying to search for item name: " + SearchBoxQuery);
                        tableTest.Rows.Add(something.Cells["productID"].Value,
                            something.Cells["productName"].Value,
                            something.Cells["currentStockQuantity"].Value,
                            something.Cells["currentPrice"].Value,
                            something.Cells["normalPrice"].Value,
                            something.Cells["discountRate"].Value);
                        // MessageBox.Show(something.Cells[1].Value.ToString());
                    }
                }
                searchProductGridView.DataSource = tableTest;
            }
            else 
            {
                return;
            }

        }


        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            /*Cashier.cashierInstance.cartGridView.*/


            if (selectedIndex != -1)
            {

                var rowQuery3 = Cashier.cashierInstance.cartGridView.Rows.Cast<DataGridViewRow>()
                    .Where(row => (row.Cells[0].Value != null));

                foreach (var row in rowQuery3)
                {
                    if (row.Cells["productID"].Value.ToString().Equals(selectedItem.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Item already exists in cart.", "Duplicate found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedIndex = -1;
                        toolStripSelectionStatus.Text = "Product ID Selected: You have not selected anything.";
                        return;
                    }

                }
                if (Convert.ToDecimal(selectedItem.Cells[2].Value) == 0)
                {
                    selectedItem.Cells[2].Style.BackColor = Color.Red;
                    MessageBox.Show("This item has no stocks available.", "No stocks available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    selectedIndex = -1;
                    toolStripSelectionStatus.Text = "Product ID Selected: You have not selected anything.";
                    return;
                }
                MessageBox.Show("Added item to cart.", "Item added to cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cashier.cartItems.Rows.Add(selectedItem.Cells["productID"].Value,
                            selectedItem.Cells["productName"].Value,
                            selectedItem.Cells["currentStockQuantity"].Value,
                            selectedItem.Cells["currentPrice"].Value,
                            selectedItem.Cells["normalPrice"].Value,
                            selectedItem.Cells["discountRate"].Value,
                            1);
                Cashier.cashierInstance.calculateTotalPrice();
                selectedIndex = -1;
                toolStripSelectionStatus.Text = "Product ID Selected: You have not selected anything.";
                //MessageBox.Show(selectedItem.Cells[0].GetType().ToString());
            }
            else
            {
                MessageBox.Show("You have not selected anything", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

          

        private void searchProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
            if (selectedIndex != -1)
            {
                // Kevin's Code
                selectedItem = searchProductGridView.Rows[selectedIndex];
                toolStripSelectionStatus.Text = $"Product ID Selected: {searchProductGridView.Rows[selectedIndex].Cells[0].Value}";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

