namespace Teletubbies_Sales_and_Inventory
{
    partial class Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numUpDownTenderAmount = new System.Windows.Forms.NumericUpDown();
            this.btnPay = new System.Windows.Forms.Button();
            this.numUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.chkboxDiscount = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemoveCartProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQuantity)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTenderAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cartGridView);
            this.groupBox1.Location = new System.Drawing.Point(34, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
            // 
            // cartGridView
            // 
            this.cartGridView.AllowUserToAddRows = false;
            this.cartGridView.AllowUserToDeleteRows = false;
            this.cartGridView.AllowUserToResizeColumns = false;
            this.cartGridView.AllowUserToResizeRows = false;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Location = new System.Drawing.Point(6, 22);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.ReadOnly = true;
            this.cartGridView.RowTemplate.Height = 25;
            this.cartGridView.Size = new System.Drawing.Size(510, 445);
            this.cartGridView.TabIndex = 4;
            this.cartGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numUpDownQuantity);
            this.groupBox2.Controls.Add(this.txtProductID);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(562, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // numUpDownQuantity
            // 
            this.numUpDownQuantity.Location = new System.Drawing.Point(104, 124);
            this.numUpDownQuantity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownQuantity.Name = "numUpDownQuantity";
            this.numUpDownQuantity.Size = new System.Drawing.Size(120, 23);
            this.numUpDownQuantity.TabIndex = 8;
            this.numUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownQuantity.ValueChanged += new System.EventHandler(this.numUpDownQuantity_ValueChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(104, 31);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(248, 23);
            this.txtProductID.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(104, 60);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(248, 23);
            this.txtProductName.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(104, 95);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(248, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numUpDownTenderAmount);
            this.groupBox3.Controls.Add(this.btnPay);
            this.groupBox3.Controls.Add(this.numUpDownDiscount);
            this.groupBox3.Controls.Add(this.chkboxDiscount);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtChange);
            this.groupBox3.Controls.Add(this.txtTotalAmount);
            this.groupBox3.Location = new System.Drawing.Point(562, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 292);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary";
            // 
            // numUpDownTenderAmount
            // 
            this.numUpDownTenderAmount.Enabled = false;
            this.numUpDownTenderAmount.Location = new System.Drawing.Point(114, 67);
            this.numUpDownTenderAmount.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numUpDownTenderAmount.Name = "numUpDownTenderAmount";
            this.numUpDownTenderAmount.Size = new System.Drawing.Size(238, 23);
            this.numUpDownTenderAmount.TabIndex = 14;
            this.numUpDownTenderAmount.ValueChanged += new System.EventHandler(this.numUpDownTenderAmount_ValueChanged);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(57, 239);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(236, 35);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // numUpDownDiscount
            // 
            this.numUpDownDiscount.Enabled = false;
            this.numUpDownDiscount.Location = new System.Drawing.Point(114, 157);
            this.numUpDownDiscount.Name = "numUpDownDiscount";
            this.numUpDownDiscount.Size = new System.Drawing.Size(120, 23);
            this.numUpDownDiscount.TabIndex = 12;
            this.numUpDownDiscount.ValueChanged += new System.EventHandler(this.numUpDownDiscount_ValueChanged);
            // 
            // chkboxDiscount
            // 
            this.chkboxDiscount.AutoSize = true;
            this.chkboxDiscount.Location = new System.Drawing.Point(114, 186);
            this.chkboxDiscount.Name = "chkboxDiscount";
            this.chkboxDiscount.Size = new System.Drawing.Size(96, 19);
            this.chkboxDiscount.TabIndex = 11;
            this.chkboxDiscount.Text = "Senior / PWD";
            this.chkboxDiscount.UseVisualStyleBackColor = true;
            this.chkboxDiscount.CheckedChanged += new System.EventHandler(this.chkbokDiscount_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Change:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tender Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Amount:";
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtChange.Location = new System.Drawing.Point(114, 112);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(238, 39);
            this.txtChange.TabIndex = 2;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalAmount.Location = new System.Drawing.Point(114, 22);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(238, 39);
            this.txtTotalAmount.TabIndex = 0;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveCartProduct
            // 
            this.btnRemoveCartProduct.Location = new System.Drawing.Point(196, 528);
            this.btnRemoveCartProduct.Name = "btnRemoveCartProduct";
            this.btnRemoveCartProduct.Size = new System.Drawing.Size(156, 25);
            this.btnRemoveCartProduct.TabIndex = 4;
            this.btnRemoveCartProduct.Text = "Remove";
            this.btnRemoveCartProduct.UseVisualStyleBackColor = true;
            this.btnRemoveCartProduct.Click += new System.EventHandler(this.btnRemoveCartProduct_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 626);
            this.Controls.Add(this.btnRemoveCartProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQuantity)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTenderAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtChange;
        private TextBox txtTotalAmount;
        private Button btnRemoveCartProduct;
        public DataGridView cartGridView;
        private NumericUpDown numUpDownQuantity;
        private NumericUpDown numUpDownDiscount;
        private CheckBox chkboxDiscount;
        private Button btnPay;
        private NumericUpDown numUpDownTenderAmount;
    }
}