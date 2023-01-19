using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        decimal tenderAmount = 0;
        decimal change = 0;
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
            numUpDownTenderAmount.Value = tenderAmount;
            txtChange.Text = change.ToString("0.00");
            checkEmpty();

        }

        private void checkEmpty()
        {
            if (cartGridView.Rows.Count > 0)
            {
                chkboxDiscount.Enabled = true;
                btnPay.Enabled = true;
                btnRemoveCartProduct.Enabled = true;
                numUpDownTenderAmount.Enabled = true;
            }
            else
            {
                txtProductID.Text = "";
                txtProductName.Text = "";
                txtPrice.Text = "";
                txtTotalAmount.Text = "";
                numUpDownTenderAmount.Value = 0;
                numUpDownQuantity.Value = 1;
                numUpDownDiscount.Value = 0;
                chkboxDiscount.Checked = false;
                chkboxDiscount.Enabled = false;
                btnPay.Enabled = false;
                btnRemoveCartProduct.Enabled = false;
                numUpDownTenderAmount.Enabled = false;
            }
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
                txtPrice.Text = (Convert.ToDecimal(cartGridView.Rows[selectedCartItemIndex].Cells[3].Value) * numUpDownQuantity.Value).ToString("0.00");
            }
        }

        private void numUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cartGridView.Rows[selectedCartItemIndex].Cells[6].Value != null)
                {
                    cartGridView.Rows[selectedCartItemIndex].Cells[6].Value = numUpDownQuantity.Value;
                    calculateTotalPrice();
                }
                else
                {

                    MessageBox.Show($"No item was selected index was {selectedCartItemIndex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } catch (ArgumentOutOfRangeException err)
            {

            }
            
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        public void calculateTotalPrice()
        {
            checkEmpty();
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
            txtTotalAmount.Text = totalPrice.ToString("0.00");
            updateChange();
        }

        private void chkbokDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxDiscount.Checked)
            {
                numUpDownDiscount.Enabled = true;
                hasDiscount = true;
                calculateTotalPrice();
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
            if (selectedCartItemIndex != -1)
            {
                
                cartGridView.Rows.Remove(cartGridView.Rows[selectedCartItemIndex]);
                calculateTotalPrice();
                checkEmpty();
                selectedCartItemIndex = -1;
                txtProductID.Text = "";
                txtProductName.Text = "";
                txtPrice.Text = "";
                //numUpDownQuantity.Value = 1;
            }
            else
            {
                MessageBox.Show("Please select a cell to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (tenderAmount > totalPrice)
            {
                MessageBox.Show($"Your change is {change}");
                // Transaction code (Update the stock quantity in sql and stuff)
            } else
            {
                MessageBox.Show("Insufficient funds");
                return;
            }


            string receipt = "----------SALES INVOICE--------";
            foreach (DataGridViewRow row in cartGridView.Rows)
            {
                receipt += $"\nName: {row.Cells[1].Value.ToString()}" +
                    $"\nItem Price Per Item: {row.Cells[3].Value.ToString()} " +
                    $"\nQuantity Bought: {row.Cells[6].Value.ToString()} " +
                    $"\nTotal Price: {(Convert.ToDecimal(row.Cells[3].Value) * Convert.ToDecimal(row.Cells[6].Value)).ToString()} " +
                    $"\n=========================================================\n";
                SQL.updateProductStocks(row);
            }
            receipt += $"\nGrand Total Price: {txtTotalAmount.Text}" +
                $"\nCash Tendered: {numUpDownTenderAmount.Value}" +
                $"\nChange: {txtChange.Text}" +
                $"\nDate: {DateTime.Now}";

            MigraDoc.DocumentObjectModel.Document doc = new MigraDoc.DocumentObjectModel.Document();
            MigraDoc.DocumentObjectModel.Section sec = doc.AddSection();

            sec.AddParagraph(receipt);

            MigraDoc.Rendering.PdfDocumentRenderer docRend = new MigraDoc.Rendering.PdfDocumentRenderer(false);
            docRend.Document = doc;
            docRend.RenderDocument();
            //var documentDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileName = $"Sales Invoice {DateTime.Now.TimeOfDay.Hours}-{DateTime.Now.TimeOfDay.Minutes}-{DateTime.Now.TimeOfDay.Seconds}.pdf";
            docRend.PdfDocument.Save(fileName);
            cartItems.Clear();
            checkEmpty();
            /*PdfDocument doc = new PdfDocument();
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 11, XFontStyle.Regular);
            gfx.DrawString(receipt, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height),
                XStringFormat.Center);
            
            
            string fileName = $"Receipt.pdf";
            doc.Save(fileName);*/

            

        }

        private void numUpDownTenderAmount_ValueChanged(object sender, EventArgs e)
        {
            updateChange();
            

        }

        private void updateChange() 
        {
            tenderAmount = Convert.ToDecimal(numUpDownTenderAmount.Value);
            if (tenderAmount > totalPrice)
            {
                change = tenderAmount - totalPrice;
            }
            else
            {
                change = 0;
            }
            txtChange.Text = change.ToString("0.00");
        }
    }
}
