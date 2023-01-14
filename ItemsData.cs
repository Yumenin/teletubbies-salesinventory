using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Teletubbies_Sales_and_Inventory
{
    internal class ItemsData
    {
        public static BindingSource Products { get; set; }
        public static DataTable Inventory { get; set; }

        public static List<int> deletedIDs = new List<int>();

    }

   
}
