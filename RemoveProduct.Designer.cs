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
            this.statusStripSelectionIndicator = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelCurrentSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarCompletion = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabelOperationStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewRemoveProductList)).BeginInit();
            this.statusStripSelectionIndicator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridviewRemoveProductList
            // 
            this.gridviewRemoveProductList.AllowUserToAddRows = false;
            this.gridviewRemoveProductList.AllowUserToDeleteRows = false;
            this.gridviewRemoveProductList.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.gridviewRemoveProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewRemoveProductList.Location = new System.Drawing.Point(12, 97);
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
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(290, 470);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(188, 37);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // statusStripSelectionIndicator
            // 
            this.statusStripSelectionIndicator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelCurrentSelection,
            this.toolStripProgressBarCompletion,
            this.toolStripLabelOperationStatus});
            this.statusStripSelectionIndicator.Location = new System.Drawing.Point(0, 519);
            this.statusStripSelectionIndicator.Name = "statusStripSelectionIndicator";
            this.statusStripSelectionIndicator.Size = new System.Drawing.Size(800, 22);
            this.statusStripSelectionIndicator.TabIndex = 3;
            // 
            // toolStripLabelCurrentSelection
            // 
            this.toolStripLabelCurrentSelection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.toolStripLabelOperationStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripLabelOperationStatus.Name = "toolStripLabelOperationStatus";
            this.toolStripLabelOperationStatus.Size = new System.Drawing.Size(217, 17);
            this.toolStripLabelOperationStatus.Text = "- Operation Status Will Be Shown Here -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(254, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Removing Product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 61);
            this.panel1.TabIndex = 16;
            // 
            // RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStripSelectionIndicator);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gridviewRemoveProductList);
            this.Name = "RemoveProduct";
            this.Text = "RemoveProduct";
            this.Load += new System.EventHandler(this.RemoveProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewRemoveProductList)).EndInit();
            this.statusStripSelectionIndicator.ResumeLayout(false);
            this.statusStripSelectionIndicator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridviewRemoveProductList;
        private Button btnRemove;
/*        private int selectedProductId = -1;*/
        private StatusStrip statusStripSelectionIndicator;
        private ToolStripStatusLabel toolStripLabelCurrentSelection;
        private ToolStripProgressBar toolStripProgressBarCompletion;
        private ToolStripStatusLabel toolStripLabelOperationStatus;
        private string selector;
        private Label label1;
        private Panel panel1;
    }
}