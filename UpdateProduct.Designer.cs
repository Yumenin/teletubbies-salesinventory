namespace Teletubbies_Sales_and_Inventory
{
    partial class UpdateProduct
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
            this.components = new System.ComponentModel.Container();
            this.lblMainLabel = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblDiscountRate = new System.Windows.Forms.Label();
            this.lblNormalPrice = new System.Windows.Forms.Label();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.gridviewUpdateProductList = new System.Windows.Forms.DataGridView();
            this.numUpDownCurrentStock = new System.Windows.Forms.NumericUpDown();
            this.numUpDownCurrentPrice = new System.Windows.Forms.NumericUpDown();
            this.numUpDownNormalPrice = new System.Windows.Forms.NumericUpDown();
            this.numUpDownDiscountRate = new System.Windows.Forms.NumericUpDown();
            this.tooltipEmptyProdID = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewUpdateProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCurrentStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCurrentPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNormalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDiscountRate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainLabel
            // 
            this.lblMainLabel.AutoSize = true;
            this.lblMainLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMainLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMainLabel.Location = new System.Drawing.Point(425, 13);
            this.lblMainLabel.Name = "lblMainLabel";
            this.lblMainLabel.Size = new System.Drawing.Size(239, 37);
            this.lblMainLabel.TabIndex = 27;
            this.lblMainLabel.Text = "UPDATE PRODUCT";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateProduct.Location = new System.Drawing.Point(78, 392);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(185, 55);
            this.btnUpdateProduct.TabIndex = 26;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(137, 159);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(185, 23);
            this.txtProductName.TabIndex = 21;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(137, 117);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(185, 23);
            this.txtProductID.TabIndex = 20;
            this.txtProductID.ModifiedChanged += new System.EventHandler(this.txtProductID_ModifiedChanged);
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.AutoSize = true;
            this.lblDiscountRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscountRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiscountRate.Location = new System.Drawing.Point(8, 317);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(123, 21);
            this.lblDiscountRate.TabIndex = 19;
            this.lblDiscountRate.Text = "Discount Rate %";
            // 
            // lblNormalPrice
            // 
            this.lblNormalPrice.AutoSize = true;
            this.lblNormalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNormalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNormalPrice.Location = new System.Drawing.Point(12, 281);
            this.lblNormalPrice.Name = "lblNormalPrice";
            this.lblNormalPrice.Size = new System.Drawing.Size(101, 21);
            this.lblNormalPrice.TabIndex = 18;
            this.lblNormalPrice.Text = "Normal Price";
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.AutoSize = true;
            this.lblCurrentPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentPrice.Location = new System.Drawing.Point(12, 243);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(101, 21);
            this.lblCurrentPrice.TabIndex = 17;
            this.lblCurrentPrice.Text = "Current Price";
            this.lblCurrentPrice.Click += new System.EventHandler(this.lblCurrentPrice_Click);
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentStock.Location = new System.Drawing.Point(12, 200);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(104, 21);
            this.lblCurrentStock.TabIndex = 16;
            this.lblCurrentStock.Text = "Current Stock";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProductName.Location = new System.Drawing.Point(12, 157);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(110, 21);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProductID.Location = new System.Drawing.Point(12, 115);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(83, 21);
            this.lblProductID.TabIndex = 14;
            this.lblProductID.Text = "Product ID";
            // 
            // gridviewUpdateProductList
            // 
            this.gridviewUpdateProductList.AllowUserToAddRows = false;
            this.gridviewUpdateProductList.AllowUserToDeleteRows = false;
            this.gridviewUpdateProductList.AllowUserToResizeColumns = false;
            this.gridviewUpdateProductList.AllowUserToResizeRows = false;
            this.gridviewUpdateProductList.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.gridviewUpdateProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewUpdateProductList.Location = new System.Drawing.Point(338, 97);
            this.gridviewUpdateProductList.Name = "gridviewUpdateProductList";
            this.gridviewUpdateProductList.ReadOnly = true;
            this.gridviewUpdateProductList.RowTemplate.Height = 25;
            this.gridviewUpdateProductList.Size = new System.Drawing.Size(819, 350);
            this.gridviewUpdateProductList.TabIndex = 28;
            this.gridviewUpdateProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewProductList_CellClick);
            // 
            // numUpDownCurrentStock
            // 
            this.numUpDownCurrentStock.Location = new System.Drawing.Point(137, 203);
            this.numUpDownCurrentStock.Name = "numUpDownCurrentStock";
            this.numUpDownCurrentStock.Size = new System.Drawing.Size(185, 23);
            this.numUpDownCurrentStock.TabIndex = 29;
            // 
            // numUpDownCurrentPrice
            // 
            this.numUpDownCurrentPrice.DecimalPlaces = 2;
            this.numUpDownCurrentPrice.Enabled = false;
            this.numUpDownCurrentPrice.Location = new System.Drawing.Point(137, 243);
            this.numUpDownCurrentPrice.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numUpDownCurrentPrice.Name = "numUpDownCurrentPrice";
            this.numUpDownCurrentPrice.ReadOnly = true;
            this.numUpDownCurrentPrice.Size = new System.Drawing.Size(185, 23);
            this.numUpDownCurrentPrice.TabIndex = 30;
            // 
            // numUpDownNormalPrice
            // 
            this.numUpDownNormalPrice.DecimalPlaces = 2;
            this.numUpDownNormalPrice.Location = new System.Drawing.Point(137, 279);
            this.numUpDownNormalPrice.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numUpDownNormalPrice.Name = "numUpDownNormalPrice";
            this.numUpDownNormalPrice.Size = new System.Drawing.Size(185, 23);
            this.numUpDownNormalPrice.TabIndex = 31;
            this.numUpDownNormalPrice.ValueChanged += new System.EventHandler(this.numUpDownNormalPrice_ValueChanged);
            // 
            // numUpDownDiscountRate
            // 
            this.numUpDownDiscountRate.DecimalPlaces = 2;
            this.numUpDownDiscountRate.Location = new System.Drawing.Point(137, 320);
            this.numUpDownDiscountRate.Name = "numUpDownDiscountRate";
            this.numUpDownDiscountRate.Size = new System.Drawing.Size(185, 23);
            this.numUpDownDiscountRate.TabIndex = 32;
            this.numUpDownDiscountRate.ValueChanged += new System.EventHandler(this.numUpDownDiscountRate_ValueChanged);
            // 
            // tooltipEmptyProdID
            // 
            this.tooltipEmptyProdID.AutoPopDelay = 5000;
            this.tooltipEmptyProdID.InitialDelay = 50;
            this.tooltipEmptyProdID.IsBalloon = true;
            this.tooltipEmptyProdID.ReshowDelay = 100;
            this.tooltipEmptyProdID.ShowAlways = true;
            this.tooltipEmptyProdID.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tooltipEmptyProdID.ToolTipTitle = "Empty Product ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblMainLabel);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 66);
            this.panel1.TabIndex = 33;
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1169, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numUpDownDiscountRate);
            this.Controls.Add(this.numUpDownNormalPrice);
            this.Controls.Add(this.numUpDownCurrentPrice);
            this.Controls.Add(this.numUpDownCurrentStock);
            this.Controls.Add(this.gridviewUpdateProductList);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblDiscountRate);
            this.Controls.Add(this.lblNormalPrice);
            this.Controls.Add(this.lblCurrentPrice);
            this.Controls.Add(this.lblCurrentStock);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Name = "UpdateProduct";
            this.Text = "UpdateProduct";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewUpdateProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCurrentStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownCurrentPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNormalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDiscountRate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMainLabel;
        private Button btnUpdateProduct;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Label lblDiscountRate;
        private Label lblNormalPrice;
        private Label lblCurrentPrice;
        private Label lblCurrentStock;
        private Label lblProductName;
        private Label lblProductID;
        private DataGridView gridviewUpdateProductList;
        private int currentRowIndex = -1;
        private bool idFieldChanged;
        private NumericUpDown numUpDownCurrentStock;
        private NumericUpDown numUpDownCurrentPrice;
        private NumericUpDown numUpDownNormalPrice;
        private NumericUpDown numUpDownDiscountRate;
        private ToolTip tooltipEmptyProdID;
        private Panel panel1;
    }
}