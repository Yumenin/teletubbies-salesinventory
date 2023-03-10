namespace Teletubbies_Sales_and_Inventory
{
    partial class CashierSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchInquiry = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchProductGridView = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.selectionStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripSelectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductGridView)).BeginInit();
            this.selectionStatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(506, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search:";
            // 
            // txtSearchInquiry
            // 
            this.txtSearchInquiry.Location = new System.Drawing.Point(557, 37);
            this.txtSearchInquiry.Name = "txtSearchInquiry";
            this.txtSearchInquiry.Size = new System.Drawing.Size(213, 23);
            this.txtSearchInquiry.TabIndex = 2;
            this.txtSearchInquiry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchProductGridView);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(11, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 351);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchProductGridView
            // 
            this.searchProductGridView.AllowUserToAddRows = false;
            this.searchProductGridView.AllowUserToDeleteRows = false;
            this.searchProductGridView.AllowUserToResizeColumns = false;
            this.searchProductGridView.AllowUserToResizeRows = false;
            this.searchProductGridView.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.searchProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchProductGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchProductGridView.Location = new System.Drawing.Point(6, 22);
            this.searchProductGridView.Name = "searchProductGridView";
            this.searchProductGridView.ReadOnly = true;
            this.searchProductGridView.RowTemplate.Height = 25;
            this.searchProductGridView.Size = new System.Drawing.Size(762, 323);
            this.searchProductGridView.TabIndex = 0;
            this.searchProductGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchProductGridView_CellClick);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Lime;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddToCart.Location = new System.Drawing.Point(264, 446);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(230, 43);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add Product To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // selectionStatusStrip
            // 
            this.selectionStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSelectionStatus});
            this.selectionStatusStrip.Location = new System.Drawing.Point(0, 500);
            this.selectionStatusStrip.Name = "selectionStatusStrip";
            this.selectionStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.selectionStatusStrip.TabIndex = 5;
            this.selectionStatusStrip.Text = "statusStrip1";
            // 
            // toolStripSelectionStatus
            // 
            this.toolStripSelectionStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripSelectionStatus.Name = "toolStripSelectionStatus";
            this.toolStripSelectionStatus.Size = new System.Drawing.Size(173, 17);
            this.toolStripSelectionStatus.Text = "-- Selection Status Goes Here --";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearchInquiry);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 69);
            this.panel1.TabIndex = 6;
            // 
            // CashierSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectionStatusStrip);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.groupBox1);
            this.Name = "CashierSearch";
            this.Text = "CashierSearch";
            this.Load += new System.EventHandler(this.CashierSearch_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchProductGridView)).EndInit();
            this.selectionStatusStrip.ResumeLayout(false);
            this.selectionStatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchInquiry;
        private GroupBox groupBox1;
        private DataGridView searchProductGridView;
        private Button btnAddToCart;
        private StatusStrip selectionStatusStrip;
        private ToolStripStatusLabel toolStripSelectionStatus;
        private Panel panel1;
    }
}