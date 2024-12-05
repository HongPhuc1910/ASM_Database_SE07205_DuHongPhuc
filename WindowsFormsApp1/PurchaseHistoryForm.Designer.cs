namespace WindowsFormsApp1
{
    partial class PurchaseHistoryForm
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
            this.dgv_PurchaseHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PurchaseHistory
            // 
            this.dgv_PurchaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PurchaseHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PurchaseHistory.Location = new System.Drawing.Point(0, 0);
            this.dgv_PurchaseHistory.Name = "dgv_PurchaseHistory";
            this.dgv_PurchaseHistory.RowHeadersWidth = 51;
            this.dgv_PurchaseHistory.RowTemplate.Height = 24;
            this.dgv_PurchaseHistory.Size = new System.Drawing.Size(800, 450);
            this.dgv_PurchaseHistory.TabIndex = 0;
            // 
            // PurchaseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_PurchaseHistory);
            this.Name = "PurchaseHistoryForm";
            this.Text = "PurchaseHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PurchaseHistory;
    }
}