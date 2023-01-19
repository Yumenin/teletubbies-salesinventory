using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teletubbies_Sales_and_Inventory
{
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            gridviewUpdateProductList.DataSource = ItemsData.Inventory;
            gridviewUpdateProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void gridviewProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRowIndex = e.RowIndex;
            if (currentRowIndex > -1)
            {
                txtProductID.Text = ItemsData.Inventory.Rows[currentRowIndex][0].ToString();
                txtProductName.Text = ItemsData.Inventory.Rows[currentRowIndex][1].ToString();
                numUpDownCurrentStock.Value = Convert.ToDecimal(ItemsData.Inventory.Rows[currentRowIndex][2]);
                numUpDownCurrentPrice.Value = Convert.ToDecimal(ItemsData.Inventory.Rows[currentRowIndex][3]);
                numUpDownNormalPrice.Value = Convert.ToDecimal(ItemsData.Inventory.Rows[currentRowIndex][4]);
                numUpDownDiscountRate.Value = Convert.ToDecimal(ItemsData.Inventory.Rows[currentRowIndex][5]);

            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
           
            if (currentRowIndex > -1)
            {
                SQL.conn.Open();
                SqlCommand cmd = SQL.conn.CreateCommand();
                cmd.CommandText = $"UPDATE Products " +
                    $"SET productName = '{txtProductName.Text}'," +
                    $"currentStockQuantity = '{numUpDownCurrentStock.Value}'," +
                    $"currentPrice = '{numUpDownCurrentPrice.Value}'," +
                    $"normalPrice = '{numUpDownNormalPrice.Value}'," +
                    $"discountRate = '{numUpDownDiscountRate.Value}'" +
                    $"WHERE productID = {txtProductID.Text}";
                //MessageBox.Show($"{txtProductName.Text}, {numUpDownCurrentStock.Value}, {numUpDownCurrentPrice},  {numUpDownNormalPrice.Value}, {numUpDownDiscountRate.Value}, {txtProductID.Text}");

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product record updated", "Record updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SQL.conn.Close();
                SQL.RefreshGridView();
                gridviewUpdateProductList.DataSource = ItemsData.Inventory;
                InventoryManagerWindow.InventoryManagerWindow_Instance.gridviewProductList.DataSource = ItemsData.Inventory;

            }
            else
            {
                MessageBox.Show("Choose a cell to make changes.");
            }
        }

        private void txtProductID_ModifiedChanged(object sender, EventArgs e)
        {
            idFieldChanged = true;
        }

        private void numUpDownNormalPrice_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDownDiscountRate.Value > 0)
            {
                numUpDownCurrentPrice.Value = (numUpDownNormalPrice.Value - (numUpDownNormalPrice.Value * (numUpDownDiscountRate.Value / 100)));
            }
            else
            {
                numUpDownCurrentPrice.Value = numUpDownNormalPrice.Value;
            }
        }

        private void numUpDownDiscountRate_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDownNormalPrice.Value > 0)
            {
                numUpDownCurrentPrice.Value = (numUpDownNormalPrice.Value - (numUpDownNormalPrice.Value * (numUpDownDiscountRate.Value / 100)));
            }
        }
    }
}
