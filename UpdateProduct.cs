using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            gridviewUpdateProductList.DataSource = ItemsData.Products;
            gridviewUpdateProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void gridviewProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRowIndex = e.RowIndex;
            if (currentRowIndex > -1)
            {
                Product productSelected = (Product)ItemsData.Products[currentRowIndex];
                txtProductID.Text = productSelected.productID.ToString();
                txtProductName.Text = productSelected.productName;
                numUpDownCurrentStock.Value = productSelected.currentStockQuantity;
                numUpDownCurrentPrice.Value = productSelected.currentPrice;
                numUpDownNormalPrice.Value = productSelected.normalPrice;
                numUpDownDiscountRate.Value = productSelected.discountRate;

            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
           
            if (currentRowIndex > -1)
            {
                Product productSelected = (Product)ItemsData.Products[currentRowIndex];
                // If text field was somehow modified but its still the same value as before

                if (idFieldChanged)
                {
                    //TODO: Try to modify using LINQ if possible
                    
                    if (!txtProductID.Text.Equals(productSelected.productID.ToString()))
                    {
                        foreach (Product product in ItemsData.Products)
                        {
                            if (product.productID.ToString().Equals(txtProductID.Text))
                            {
                                MessageBox.Show("Product ID must be unique.");
                                return;
                            }
                        }
                    }
                    
                }
                productSelected.productID = !txtProductID.Text.Equals("") ? Convert.ToInt32(txtProductID.Text) : productSelected.productID;
                if (txtProductID.Text.Equals("")) { MessageBox.Show("Empty product ID was found. The ID was set to its original ID prior to change."); } 
                productSelected.productName = txtProductName.Text;
                productSelected.currentStockQuantity = Convert.ToInt32(numUpDownCurrentStock.Value);
                productSelected.currentPrice = numUpDownCurrentPrice.Value;
                productSelected.normalPrice = numUpDownNormalPrice.Value;
                productSelected.discountRate = numUpDownDiscountRate.Value;
                ItemsData.Products[currentRowIndex] = productSelected;
                CSVOperations.UpdateCSV(ItemsData.Products, Selection.filePath);
                gridviewUpdateProductList.Refresh();
                
                
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
                numUpDownCurrentPrice.Value = (numUpDownNormalPrice.Value - (numUpDownNormalPrice.Value * numUpDownDiscountRate.Value));
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
                numUpDownCurrentPrice.Value = (numUpDownNormalPrice.Value - (numUpDownNormalPrice.Value * numUpDownDiscountRate.Value));
            }
        }
    }
}
