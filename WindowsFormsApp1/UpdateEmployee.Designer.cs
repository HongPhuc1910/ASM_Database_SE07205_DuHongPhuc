namespace WindowsFormsApp1
{
    partial class UpdateEmployee
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
            this.button1 = new System.Windows.Forms.Button();
            this.rbt_warehouse = new System.Windows.Forms.RadioButton();
            this.rbt_sale = new System.Windows.Forms.RadioButton();
            this.rbt_admin = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_position = new System.Windows.Forms.TextBox();
            this.txb_code = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rbt_employee = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(145, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 56);
            this.button1.TabIndex = 29;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbt_warehouse
            // 
            this.rbt_warehouse.AutoSize = true;
            this.rbt_warehouse.Location = new System.Drawing.Point(601, 159);
            this.rbt_warehouse.Name = "rbt_warehouse";
            this.rbt_warehouse.Size = new System.Drawing.Size(101, 20);
            this.rbt_warehouse.TabIndex = 28;
            this.rbt_warehouse.TabStop = true;
            this.rbt_warehouse.Text = "WareHouse";
            this.rbt_warehouse.UseVisualStyleBackColor = true;
            // 
            // rbt_sale
            // 
            this.rbt_sale.AutoSize = true;
            this.rbt_sale.Location = new System.Drawing.Point(601, 107);
            this.rbt_sale.Name = "rbt_sale";
            this.rbt_sale.Size = new System.Drawing.Size(56, 20);
            this.rbt_sale.TabIndex = 27;
            this.rbt_sale.TabStop = true;
            this.rbt_sale.Text = "Sale";
            this.rbt_sale.UseVisualStyleBackColor = true;
            // 
            // rbt_admin
            // 
            this.rbt_admin.AutoSize = true;
            this.rbt_admin.Location = new System.Drawing.Point(601, 52);
            this.rbt_admin.Name = "rbt_admin";
            this.rbt_admin.Size = new System.Drawing.Size(66, 20);
            this.rbt_admin.TabIndex = 26;
            this.rbt_admin.TabStop = true;
            this.rbt_admin.Text = "Admin";
            this.rbt_admin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Pasword";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Code";
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(340, 424);
            this.txb_password.Multiline = true;
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(327, 55);
            this.txb_password.TabIndex = 19;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(340, 323);
            this.txb_username.Multiline = true;
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(327, 55);
            this.txb_username.TabIndex = 18;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(173, 106);
            this.txb_name.Multiline = true;
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(247, 46);
            this.txb_name.TabIndex = 17;
            // 
            // txb_position
            // 
            this.txb_position.Location = new System.Drawing.Point(174, 180);
            this.txb_position.Multiline = true;
            this.txb_position.Name = "txb_position";
            this.txb_position.Size = new System.Drawing.Size(246, 45);
            this.txb_position.TabIndex = 16;
            // 
            // txb_code
            // 
            this.txb_code.Location = new System.Drawing.Point(173, 38);
            this.txb_code.Multiline = true;
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(247, 45);
            this.txb_code.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(586, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 56);
            this.button2.TabIndex = 30;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbt_employee
            // 
            this.rbt_employee.AutoSize = true;
            this.rbt_employee.Location = new System.Drawing.Point(601, 216);
            this.rbt_employee.Name = "rbt_employee";
            this.rbt_employee.Size = new System.Drawing.Size(90, 20);
            this.rbt_employee.TabIndex = 31;
            this.rbt_employee.TabStop = true;
            this.rbt_employee.Text = "Employee";
            this.rbt_employee.UseVisualStyleBackColor = true;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.rbt_employee);
            this.Controls.Add(this.button2);
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
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbt_warehouse;
        private System.Windows.Forms.RadioButton rbt_sale;
        private System.Windows.Forms.RadioButton rbt_admin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_position;
        private System.Windows.Forms.TextBox txb_code;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbt_employee;
    }
}