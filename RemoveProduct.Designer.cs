namespace Teletubbies_Sales_and_Inventory
{
    partial class RemoveProduct
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
            this.gridviewRemoveProductList = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMainLabel = new System.Windows.Forms.Label();
            this.statusStripSelectionIndicator = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelCurrentSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarCompletion = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabelOperationStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewRemoveProductList)).BeginInit();
            this.statusStripSelectionIndicator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridviewRemoveProductList
            // 
            this.gridviewRemoveProductList.AllowUserToAddRows = false;
            this.gridviewRemoveProductList.AllowUserToDeleteRows = false;
            this.gridviewRemoveProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewRemoveProductList.Location = new System.Drawing.Point(21, 71);
            this.gridviewRemoveProductList.Name = "gridviewRemoveProductList";
            this.gridviewRemoveProductList.ReadOnly = true;
            this.gridviewRemoveProductList.RowTemplate.Height = 25;
            this.gridviewRemoveProductList.Size = new System.Drawing.Size(776, 367);
            this.gridviewRemoveProductList.TabIndex = 0;
            this.gridviewRemoveProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewRemoveProductList_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.Location = new System.Drawing.Point(308, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(188, 37);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMainLabel
            // 
            this.btnMainLabel.AutoSize = true;
            this.btnMainLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainLabel.Location = new System.Drawing.Point(21, 14);
            this.btnMainLabel.Name = "btnMainLabel";
            this.btnMainLabel.Size = new System.Drawing.Size(230, 37);
            this.btnMainLabel.TabIndex = 2;
            this.btnMainLabel.Text = "Remove Product";
            this.btnMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStripSelectionIndicator
            // 
            this.statusStripSelectionIndicator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelCurrentSelection,
            this.toolStripProgressBarCompletion,
            this.toolStripLabelOperationStatus});
            this.statusStripSelectionIndicator.Location = new System.Drawing.Point(0, 428);
            this.statusStripSelectionIndicator.Name = "statusStripSelectionIndicator";
            this.statusStripSelectionIndicator.Size = new System.Drawing.Size(800, 22);
            this.statusStripSelectionIndicator.TabIndex = 3;
            // 
            // toolStripLabelCurrentSelection
            // 
            this.toolStripLabelCurrentSelection.Name = "toolStripLabelCurrentSelection";
            this.toolStripLabelCurrentSelection.Size = new System.Drawing.Size(220, 17);
            this.toolStripLabelCurrentSelection.Text = "- Current Selection Will Be Shown Here -";
            // 
            // toolStripProgressBarCompletion
            // 
            this.toolStripProgressBarCompletion.Name = "toolStripProgressBarCompletion";
            this.toolStripProgressBarCompletion.Size = new System.Drawing.Size(180, 16);
            // 
            // toolStripLabelOperationStatus
            // 
            this.toolStripLabelOperationStatus.Name = "toolStripLabelOperationStatus";
            this.toolStripLabelOperationStatus.Size = new System.Drawing.Size(217, 17);
            this.toolStripLabelOperationStatus.Text = "- Operation Status Will Be Shown Here -";
            // 
            // RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStripSelectionIndicator);
            this.Controls.Add(this.btnMainLabel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gridviewRemoveProductList);
            this.Name = "RemoveProduct";
            this.Text = "RemoveProduct";
            this.Load += new System.EventHandler(this.RemoveProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewRemoveProductList)).EndInit();
            this.statusStripSelectionIndicator.ResumeLayout(false);
            this.statusStripSelectionIndicator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridviewRemoveProductList;
        private Button btnRemove;
        private Label btnMainLabel;
        private int currentRowIndex = -1;
        private StatusStrip statusStripSelectionIndicator;
        private ToolStripStatusLabel toolStripLabelCurrentSelection;
        private ToolStripProgressBar toolStripProgressBarCompletion;
        private ToolStripStatusLabel toolStripLabelOperationStatus;
    }
}