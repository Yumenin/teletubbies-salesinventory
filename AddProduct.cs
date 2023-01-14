﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private void button1_Click(object sender, EventArgs e) // Add Button
        {
            SQL.conn.Open();
            SqlCommand cmd = SQL.conn.CreateCommand();
            /*cmd.CommandText = "INSERT INTO Products VALUES ('"
                + txtProductID.Text
                + "','" + txtLastName.Text
                + "','" + txtFirstName.Text
                + "','" + txtMiddleInitial.Text
                + "','" + txtAge.Text + "')";*/
            cmd.CommandText = $"INSERT INTO Products VALUES (" +
                $"'{txtProductID.Text}'," +
                $"'{txtProductName.Text}'," +
                $"'{numUpDownCurrentStock.Value}'," +
                $"'{txtCurrentPrice.Text}'," +
                $"'{numUpDownNormalPrice.Value}'," +
                $"'{numUpDownDiscountRate.Value}')";
            cmd.ExecuteNonQuery();
            SQL.conn.Close();
            SQL.RefreshGridView();
            InventoryManagerWindow.InventoryManagerWindow_Instance.gridviewProductList.DataSource = ItemsData.Inventory;
            ItemsData.deletedIDs.Remove(0);
            MessageBox.Show("Added product.", "Product added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

            SQL.RefreshGridView();
            if (ItemsData.deletedIDs.Count > 0)
            {
                txtProductID.Text = ItemsData.deletedIDs.ElementAt(0).ToString();
            }
            else
            {
                txtProductID.Text = (ItemsData.Inventory.Rows.Count + 1).ToString();
            }

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
