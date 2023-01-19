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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search:";
            // 
            // txtSearchInquiry
            // 
            this.txtSearchInquiry.Location = new System.Drawing.Point(572, 57);
            this.txtSearchInquiry.Name = "txtSearchInquiry";
            this.txtSearchInquiry.Size = new System.Drawing.Size(213, 23);
            this.txtSearchInquiry.TabIndex = 2;
            this.txtSearchInquiry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchProductGridView);
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
            this.searchProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchProductGridView.Location = new System.Drawing.Point(6, 22);
            this.searchProductGridView.Name = "searchProductGridView";
            this.searchProductGridView.ReadOnly = true;
            this.searchProductGridView.RowTemplate.Height = 25;
            this.searchProductGridView.Size = new System.Drawing.Size(762, 323);
            this.searchProductGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CashierSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchInquiry);
            this.Controls.Add(this.label1);
            this.Name = "CashierSearch";
            this.Text = "CashierSearch";
            this.Load += new System.EventHandler(this.CashierSearch_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchProductGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchInquiry;
        private GroupBox groupBox1;
        private DataGridView searchProductGridView;
        private Button button1;
    }
}