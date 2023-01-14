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
    public partial class InventoryManagerWindow : Form
    {
        public InventoryManagerWindow()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
        }

        private void gridviewProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new UpdateProduct().ShowDialog();
        }

        private void gridviewProductList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InventoryManagerWindow_Load_1(object sender, EventArgs e)
        {
            gridviewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SQL.RefreshGridView();
            gridviewProductList.DataSource = ItemsData.Inventory;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            new RemoveProduct().ShowDialog();
        }

        private void lblMainLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL.RefreshGridView();
            gridviewProductList.Refresh();
        }
    }
}
