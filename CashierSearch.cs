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
        public CashierSearch()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CashierSearch_Load(object sender, EventArgs e)
        {

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
            if (txtSearchInquiry.Text.Length == 0)
            {
                searchProductGridView.DataSource = ItemsData.Inventory;
            }
            else
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
            /*            foreach (DataGridViewRow? row in searchProductGridView.Rows)
                        {
                            string currrentProductName = (string)row.Cells["productName"].Value;
                            if (currrentProductName.Contains(txtSearchInquiry.Text)) {
                                MessageBox.Show(currrentProductName);
                            }
                        }*/

        }
    }

}

