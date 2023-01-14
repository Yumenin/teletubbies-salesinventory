using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teletubbies_Sales_and_Inventory
{
    internal class CSVOperations
    {
        // Overwrites existing file should there be any changes in the binding source
        public static void UpdateCSV(BindingSource Items, string filePath) 
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            foreach(Product product in ItemsData.Products)
            {
                sw.WriteLine($"{product.productID},{product.productName},{product.currentStockQuantity},{product.currentPrice},{product.normalPrice},{product.discountRate}");
            }
            sw.Close();
            fs.Close();

        }
    }
}
