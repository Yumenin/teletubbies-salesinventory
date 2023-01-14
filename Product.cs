using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teletubbies_Sales_and_Inventory
{
    internal class Product
    {
        [DisplayName("Product ID")]
        public int productID { get;  set; }
        [DisplayName("Product Name")]
        public string productName { get; set; } = "";
        [DisplayName("Current Stock Quantity")]
        public int currentStockQuantity { get; set; }
        [DisplayName("Current Price")]
        public decimal currentPrice { get; set; }
        [DisplayName("Normal Price")]
        public decimal normalPrice { get; set; }
        [DisplayName("Discount Rate")]
        public decimal discountRate { get; set; }
       
    }
}
