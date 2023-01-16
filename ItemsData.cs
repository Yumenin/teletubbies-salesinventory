using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public static void addDeletedID(int id)
        // when performing remove function
        {
            SQL.conn.Open();
            SqlCommand cmd = SQL.conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO DeletedIDs (DeletedID)" +
                $"VALUES ('{id}')";
            cmd.ExecuteNonQuery();
            ItemsData.deletedIDs.Add(id);
            SQL.conn.Close();
        }

        public static void renewDeletedId(int id) 
        // re-assigning deleted IDs to new ones
        // remove from sql and list as indication of being used once again
        {
            SQL.conn.Open();
            SqlCommand cmd = SQL.conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM DeletedIDs WHERE DeletedID = {id}";
            cmd.ExecuteNonQuery();
            ItemsData.deletedIDs.Remove(id);
            SQL.conn.Close();
        }

        public static void updateDeletedIDList()
        // refreshes list
        {
            SQL.conn.Open();
            SqlCommand cmd = SQL.conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM DeletedIDs";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; ++i)
            {
                ItemsData.deletedIDs.Add(Convert.ToInt32(dt.Rows[i][1]));
            }
            SQL.conn.Close();
        }
    }

   
}
