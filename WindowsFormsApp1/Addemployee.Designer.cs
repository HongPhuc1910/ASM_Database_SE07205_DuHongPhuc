namespace WindowsFormsApp1
{
    partial class Addemployee
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
            this.txb_code = new System.Windows.Forms.TextBox();
            this.txb_position = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbt_admin = new System.Windows.Forms.RadioButton();
            this.rbt_sale = new System.Windows.Forms.RadioButton();
            this.rbt_warehouse = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rbt_employee = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txb_code
            // 
            this.txb_code.Location = new System.Drawing.Point(127, 40);
            this.txb_code.Multiline = true;
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(213, 45);
            this.txb_code.TabIndex = 0;
            // 
            // txb_position
            // 
            this.txb_position.Location = new System.Drawing.Point(127, 187);
            this.txb_position.Multiline = true;
            this.txb_position.Name = "txb_position";
            this.txb_position.Size = new System.Drawing.Size(213, 41);
            this.txb_position.TabIndex = 1;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(127, 116);
            this.txb_name.Multiline = true;
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(213, 42);
            this.txb_name.TabIndex = 2;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(227, 318);
            this.txb_username.Multiline = true;
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(327, 55);
            this.txb_username.TabIndex = 3;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(227, 422);
            this.txb_password.Multiline = true;
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(327, 55);
            this.txb_password.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pasword";
            // 
            // rbt_admin
            // 
            this.rbt_admin.AutoSize = true;
            this.rbt_admin.Location = new System.Drawing.Point(488, 40);
            this.rbt_admin.Name = "rbt_admin";
            this.rbt_admin.Size = new System.Drawing.Size(66, 20);
            this.rbt_admin.TabIndex = 11;
            this.rbt_admin.TabStop = true;
            this.rbt_admin.Text = "Admin";
            this.rbt_admin.UseVisualStyleBackColor = true;
            // 
            // rbt_sale
            // 
            this.rbt_sale.AutoSize = true;
            this.rbt_sale.Location = new System.Drawing.Point(488, 92);
            this.rbt_sale.Name = "rbt_sale";
            this.rbt_sale.Size = new System.Drawing.Size(56, 20);
            this.rbt_sale.TabIndex = 12;
            this.rbt_sale.TabStop = true;
            this.rbt_sale.Text = "Sale";
            this.rbt_sale.UseVisualStyleBackColor = true;
            // 
            // rbt_warehouse
            // 
            this.rbt_warehouse.AutoSize = true;
            this.rbt_warehouse.Location = new System.Drawing.Point(488, 142);
            this.rbt_warehouse.Name = "rbt_warehouse";
            this.rbt_warehouse.Size = new System.Drawing.Size(101, 20);
            this.rbt_warehouse.TabIndex = 13;
            this.rbt_warehouse.TabStop = true;
            this.rbt_warehouse.Text = "WareHouse";
            this.rbt_warehouse.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(508, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 56);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbt_employee
            // 
            this.rbt_employee.AutoSize = true;
            this.rbt_employee.Location = new System.Drawing.Point(488, 208);
            this.rbt_employee.Name = "rbt_employee";
            this.rbt_employee.Size = new System.Drawing.Size(90, 20);
            this.rbt_employee.TabIndex = 15;
            this.rbt_employee.TabStop = true;
            this.rbt_employee.Text = "Employee";
            this.rbt_employee.UseVisualStyleBackColor = true;
            // 
            // Addemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(686, 617);
            this.Controls.Add(this.rbt_employee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbt_warehouse);
            this.Controls.Add(this.rbt_sale);
            this.Controls.Add(this.rbt_admin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_position);
            this.Controls.Add(this.txb_code);
            this.Name = "Addemployee";
            this.Text = "Addemployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_code;
        private System.Windows.Forms.TextBox txb_position;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbt_admin;
        private System.Windows.Forms.RadioButton rbt_sale;
        private System.Windows.Forms.RadioButton rbt_warehouse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbt_employee;
    }
}