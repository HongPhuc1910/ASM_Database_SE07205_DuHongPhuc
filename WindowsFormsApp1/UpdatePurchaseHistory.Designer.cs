namespace WindowsFormsApp1
{
    partial class UpdatePurchaseHistory
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
            this.button = new System.Windows.Forms.Button();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.dtp_datetime = new System.Windows.Forms.DateTimePicker();
            this.txb_quantity = new System.Windows.Forms.TextBox();
            this.txb_customerCode = new System.Windows.Forms.TextBox();
            this.txb_productCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_purchaseID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button.Location = new System.Drawing.Point(94, 359);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(133, 64);
            this.button.TabIndex = 25;
            this.button.Text = "Delete";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Location = new System.Drawing.Point(284, 281);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(318, 24);
            this.cbx_status.TabIndex = 24;
            // 
            // dtp_datetime
            // 
            this.dtp_datetime.Location = new System.Drawing.Point(284, 212);
            this.dtp_datetime.Name = "dtp_datetime";
            this.dtp_datetime.Size = new System.Drawing.Size(318, 22);
            this.dtp_datetime.TabIndex = 23;
            // 
            // txb_quantity
            // 
            this.txb_quantity.Location = new System.Drawing.Point(537, 96);
            this.txb_quantity.Multiline = true;
            this.txb_quantity.Name = "txb_quantity";
            this.txb_quantity.Size = new System.Drawing.Size(187, 41);
            this.txb_quantity.TabIndex = 22;
            // 
            // txb_customerCode
            // 
            this.txb_customerCode.Location = new System.Drawing.Point(537, 33);
            this.txb_customerCode.Multiline = true;
            this.txb_customerCode.Name = "txb_customerCode";
            this.txb_customerCode.Size = new System.Drawing.Size(187, 41);
            this.txb_customerCode.TabIndex = 21;
            // 
            // txb_productCode
            // 
            this.txb_productCode.Location = new System.Drawing.Point(175, 96);
            this.txb_productCode.Multiline = true;
            this.txb_productCode.Name = "txb_productCode";
            this.txb_productCode.Size = new System.Drawing.Size(187, 41);
            this.txb_productCode.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity";
            // 
            // txb_purchaseID
            // 
            this.txb_purchaseID.Location = new System.Drawing.Point(175, 33);
            this.txb_purchaseID.Multiline = true;
            this.txb_purchaseID.Name = "txb_purchaseID";
            this.txb_purchaseID.Size = new System.Drawing.Size(187, 41);
            this.txb_purchaseID.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "DateTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "CustomerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "ProductID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "PurchaseID";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(537, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 64);
            this.button2.TabIndex = 26;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdatePurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.dtp_datetime);
            this.Controls.Add(this.txb_quantity);
            this.Controls.Add(this.txb_customerCode);
            this.Controls.Add(this.txb_productCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_purchaseID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePurchaseHistory";
            this.Text = "UpdatePurchaseHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.DateTimePicker dtp_datetime;
        private System.Windows.Forms.TextBox txb_quantity;
        private System.Windows.Forms.TextBox txb_customerCode;
        private System.Windows.Forms.TextBox txb_productCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_purchaseID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}