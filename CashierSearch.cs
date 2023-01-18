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
            Product testProduct = new Product();
            testProduct.productID = 1;
            testProduct.normalPrice = 5;
            testProduct.currentPrice = 5;
            testProduct.discountRate = 0;
            testProduct.currentStockQuantity = 5;
            testProduct.productName = "Test";
           /* ListViewItem productTest = new ListViewItem(testProduct);*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
