using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teletubbies_Sales_and_Inventory
{
    public partial class Cashier : Form
    {
        public static DataTable? cartItems = new DataTable();
        public static Cashier cashierInstance;
        public decimal totalPrice;
        bool hasDiscount = false;
        int selectedCartItemIndex = -1;

        public Cashier()
        {
            InitializeComponent();
            cashierInstance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CashierSearch().Show();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
  
            SQL.RefreshGridView();
            // Initialize column headers in cart grid view
            cartItems = ItemsData.Inventory.Copy();
            cartItems.Clear();
            cartGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cartGridView.DataSource = cartItems;
            cartItems.Columns.Add("Quantity", typeof(System.Int32));

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            cartGridView.DataSource = cartItems;
        }

        private void cartGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCartItemIndex = e.RowIndex;
            if (selectedCartItemIndex != -1)
            {
                this.numUpDownQuantity.Maximum = Convert.ToDecimal(cartGridView.Rows[selectedCartItemIndex].Cells[2].Value);
                numUpDownQuantity.Value = Convert.ToDecimal(cartGridView.Rows[selectedCartItemIndex].Cells[6].Value);
                txtProductID.Text = cartGridView.Rows[selectedCartItemIndex].Cells[0].Value.ToString();
                txtProductName.Text = cartGridView.Rows[selectedCartItemIndex].Cells[1].Value.ToString();
                txtPrice.Text = (Convert.ToDecimal(cartGridView.Rows[selectedCartItemIndex].Cells[3].Value) * numUpDownQuantity.Value).ToString();
            }
        }

        private void numUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (selectedCartItemIndex != -1)
            {
                cartGridView.Rows[selectedCartItemIndex].Cells[6].Value = numUpDownQuantity.Value;
                calculateTotalPrice();
            }
            else
            {

                MessageBox.Show("No item was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        public void calculateTotalPrice()
        {
            totalPrice = 0;
            if (!hasDiscount)
            {
                foreach (DataGridViewRow rows in cartGridView.Rows)
                {
                    totalPrice += (Convert.ToDecimal(rows.Cells[3].Value) * (Convert.ToDecimal(rows.Cells[6].Value)));
                }
            } else
            {
                foreach (DataGridViewRow rows in cartGridView.Rows)
                {
                    totalPrice += (Convert.ToDecimal(rows.Cells[3].Value) * (Convert.ToDecimal(rows.Cells[6].Value)));
                }
                totalPrice = totalPrice - (totalPrice * (numUpDownDiscount.Value / 100));
            }
            txtTotalAmount.Text = totalPrice.ToString();
        }

        private void chkbokDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxDiscount.Checked)
            {
                numUpDownDiscount.Enabled = true;
                hasDiscount = true;
            }
            else
            {
                numUpDownDiscount.Value = 0;
                numUpDownDiscount.Enabled = false;
                hasDiscount = false;
                calculateTotalPrice();
            }
        }

        private void numUpDownDiscount_ValueChanged(object sender, EventArgs e)
        {
            calculateTotalPrice();
        }
        private void btnRemoveCartProduct_Click(object sender, EventArgs e)
        {
  
            cartGridView.Rows.Remove(cartGridView.Rows[selectedCartItemIndex]);
            calculateTotalPrice();
        }
    }
}
