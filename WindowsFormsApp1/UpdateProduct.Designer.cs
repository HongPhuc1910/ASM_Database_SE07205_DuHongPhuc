namespace WindowsFormsApp1
{
    partial class dgv_UpdateProduct
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txb_price = new System.Windows.Forms.TextBox();
            this.txb_amount = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_code = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Aqua;
            this.button6.Location = new System.Drawing.Point(497, 342);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 47);
            this.button6.TabIndex = 19;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Aqua;
            this.button5.Location = new System.Drawing.Point(197, 342);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 47);
            this.button5.TabIndex = 18;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(132, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 46);
            this.button4.TabIndex = 17;
            this.button4.Text = "Giá";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txb_price
            // 
            this.txb_price.Location = new System.Drawing.Point(367, 258);
            this.txb_price.Multiline = true;
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(301, 44);
            this.txb_price.TabIndex = 16;
            // 
            // txb_amount
            // 
            this.txb_amount.Location = new System.Drawing.Point(367, 196);
            this.txb_amount.Multiline = true;
            this.txb_amount.Name = "txb_amount";
            this.txb_amount.Size = new System.Drawing.Size(301, 44);
            this.txb_amount.TabIndex = 15;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(367, 130);
            this.txb_name.Multiline = true;
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(301, 44);
            this.txb_name.TabIndex = 14;
            // 
            // txb_code
            // 
            this.txb_code.Location = new System.Drawing.Point(367, 61);
            this.txb_code.Multiline = true;
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(301, 44);
            this.txb_code.TabIndex = 13;
            this.txb_code.TextChanged += new System.EventHandler(this.txb_code_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(132, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 46);
            this.button3.TabIndex = 12;
            this.button3.Text = "Số lượng";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(132, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Tên sản phẩm";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(132, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mã sàn phẩm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgv_UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txb_price);
            this.Controls.Add(this.txb_amount);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_code);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "dgv_UpdateProduct";
            this.Text = "UpdateProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.TextBox txb_amount;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_code;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}