using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teletubbies_Sales_and_Inventory
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool productIDBoxHasText = txtProductID.Text != "" ? true : false;
            if (productIDBoxHasText)
            {
                foreach (Product product in ItemsData.Products)
                {
                    string currentProductID = (product.productID).ToString();
                    if (txtProductID.Text.Equals(currentProductID))
                    {
                        MessageBox.Show("An existing ID is already present in the list. Please use a unique id.");
                        return;
                    }
                }
            }
            Product item = null;
            try
            {
                item = new Product()
                {
                    productID = productIDBoxHasText ? Convert.ToInt32(txtProductID.Text) : Convert.ToInt32(ItemsData.Products.Count) + 1,
                    productName = txtProductName.Text,
                    currentStockQuantity = Convert.ToInt32(numUpDownCurrentStock.Value),
                    currentPrice = Convert.ToDecimal(txtCurrentPrice.Text),
                    normalPrice = numUpDownNormalPrice.Value,
                    discountRate = numUpDownDiscountRate.Value
                   
                }; 
            } catch (FormatException err)
            {
                MessageBox.Show("Please fill all the fields or type an appropriate input in one of the fields provided.");
            }

            
            if (item != null) { 
                ItemsData.Products.Add(item);
                CSVOperations.UpdateCSV(ItemsData.Products, Selection.filePath);
                txtProductID.Text = (ItemsData.Products.Count + 1).ToString(); 
            }
            
            
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            txtProductID.Text = (ItemsData.Products.Count + 1).ToString();
            Console.BackgroundColor = ConsoleColor.Blue;
        }

        private void numUpDownNormalPrice_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDownDiscountRate.Value > 0)
            {
                txtCurrentPrice.Text = (numUpDownNormalPrice.Value - (numUpDownNormalPrice.Value * numUpDownDiscountRate.Value)).ToString();
            }
            else
            {
                txtCurrentPrice.Text = numUpDownNormalPrice.Value.ToString();
            }
        }

        private void numUpDownDiscountRate_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDownNormalPrice.Value > 0)
            {
                txtCurrentPrice.Text = (numUpDownNormalPrice.Value - (numUpDownNormalPrice.Value * numUpDownDiscountRate.Value)).ToString();
            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txtProductID.Text, @"^\d*$"))
            {
                MessageBox.Show("This textbox accepts only numerical characters.");
                txtProductID.Text = "";
            }
        }
    }
}
