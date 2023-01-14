using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teletubbies_Sales_and_Inventory
{
    internal class SQL
    {

        public static SqlConnection conn = new SqlConnection("" +
                "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFilename=C:\\Skyrim Special DL\\Teletubbies_Sales_and_Inventory_2\\Teletubbies_Sales_and_Inventory\\Teletubbies Sales and Inventory\\Inventory.mdf;" +
                "Integrated Security=True");


    }
}
