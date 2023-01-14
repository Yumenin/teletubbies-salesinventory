namespace Teletubbies_Sales_and_Inventory
{
    partial class Selection
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInventoryManager = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInventoryManager
            // 
            this.btnInventoryManager.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInventoryManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventoryManager.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInventoryManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventoryManager.Location = new System.Drawing.Point(336, 142);
            this.btnInventoryManager.Name = "btnInventoryManager";
            this.btnInventoryManager.Size = new System.Drawing.Size(201, 40);
            this.btnInventoryManager.TabIndex = 0;
            this.btnInventoryManager.Text = "Inventory Manager";
            this.btnInventoryManager.UseVisualStyleBackColor = false;
            this.btnInventoryManager.Click += new System.EventHandler(this.btnInventoryManager_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCashier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCashier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCashier.Location = new System.Drawing.Point(336, 188);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(201, 40);
            this.btnCashier.TabIndex = 1;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(127, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "User Selection Client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 72);
            this.panel1.TabIndex = 16;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(551, 238);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnInventoryManager);
            this.Name = "Selection";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnInventoryManager;
        private Button btnCashier;
        private Label label1;
        private Panel panel1;
        public static string filePath = "./ProductInventory.csv";
    }
}