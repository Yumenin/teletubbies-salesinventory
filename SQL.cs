using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teletubbies_Sales_and_Inventory
{
    internal class SQL
    {
        static String SQLDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public static SqlConnection conn = new SqlConnection("" +
                "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                $"AttachDbFilename={SQLDir}\\Inventory.mdf;" +
                "Integrated Security=True");

        public static void RefreshGridView()
        {

            SQL.conn.Open();

            SqlCommand cmd = SQL.conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            ItemsData.Inventory = dt;
            // MessageBox.Show(dt.Rows[dt.Rows.Count - 1][0].ToString());
            // First index is the row, second index is the column

            //new InventoryManagerWindow().gridviewProductList.DataSource = dt;

            SQL.conn.Close();

        }


    }
}
