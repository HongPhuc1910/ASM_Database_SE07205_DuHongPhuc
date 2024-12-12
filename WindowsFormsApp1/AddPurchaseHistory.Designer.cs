namespace WindowsFormsApp1
{
    partial class AddPurchaseHistory
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_purchaseID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_productID = new System.Windows.Forms.TextBox();
            this.txb_customerID = new System.Windows.Forms.TextBox();
            this.txb_quantity = new System.Windows.Forms.TextBox();
            this.dtp_datetime = new System.Windows.Forms.DateTimePicker();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PurchaseID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProductID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CustomerID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "DateTime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // txb_purchaseID
            // 
            this.txb_purchaseID.Location = new System.Drawing.Point(123, 50);
            this.txb_purchaseID.Multiline = true;
            this.txb_purchaseID.Name = "txb_purchaseID";
            this.txb_purchaseID.Size = new System.Drawing.Size(187, 41);
            this.txb_purchaseID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantity";
            // 
            // txb_productID
            // 
            this.txb_productID.Location = new System.Drawing.Point(123, 113);
            this.txb_productID.Multiline = true;
            this.txb_productID.Name = "txb_productID";
            this.txb_productID.Size = new System.Drawing.Size(187, 41);
            this.txb_productID.TabIndex = 7;
            // 
            // txb_customerID
            // 
            this.txb_customerID.Location = new System.Drawing.Point(485, 50);
            this.txb_customerID.Multiline = true;
            this.txb_customerID.Name = "txb_customerID";
            this.txb_customerID.Size = new System.Drawing.Size(187, 41);
            this.txb_customerID.TabIndex = 8;
            // 
            // txb_quantity
            // 
            this.txb_quantity.Location = new System.Drawing.Point(485, 113);
            this.txb_quantity.Multiline = true;
            this.txb_quantity.Name = "txb_quantity";
            this.txb_quantity.Size = new System.Drawing.Size(187, 41);
            this.txb_quantity.TabIndex = 9;
            // 
            // dtp_datetime
            // 
            this.dtp_datetime.Location = new System.Drawing.Point(232, 229);
            this.dtp_datetime.Name = "dtp_datetime";
            this.dtp_datetime.Size = new System.Drawing.Size(318, 22);
            this.dtp_datetime.TabIndex = 10;
            this.dtp_datetime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Location = new System.Drawing.Point(232, 298);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(318, 24);
            this.cbx_status.TabIndex = 11;
            this.cbx_status.SelectedIndexChanged += new System.EventHandler(this.cbx_status_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(474, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(709, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.dtp_datetime);
            this.Controls.Add(this.txb_quantity);
            this.Controls.Add(this.txb_customerID);
            this.Controls.Add(this.txb_productID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_purchaseID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPurchaseHistory";
            this.Text = "AddPurchaseHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_purchaseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_productID;
        private System.Windows.Forms.TextBox txb_customerID;
        private System.Windows.Forms.TextBox txb_quantity;
        private System.Windows.Forms.DateTimePicker dtp_datetime;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.Button button1;
    }
}