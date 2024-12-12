using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional Set a fixed border style to prevent resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // 1 là Admin, 2 là Sale, 3 là Warehouse, 4 là Employee
            if (Utils.roleID == 1) // Admin
            {
                button1.Visible = true;  // Product Management
                button3.Visible = true;  // Customer Management
                button4.Visible = true;  // Purchase History
                button5.Visible = true;  // Employee Management
            }
            else if (Utils.roleID == 2) // Sale
            {
                button1.Visible = true;  // Product Management
                button3.Visible = true;  // Customer Management
                button4.Visible = true;  // Purchase History
                button5.Visible = false; // Employee Management
            }
            else if (Utils.roleID == 3) // Warehouse
            {
                button1.Visible = true;  // Product Management
                button3.Visible = false; // Customer Management
                button4.Visible = false; // Purchase History
                button5.Visible = false; // Employee Management
            }
            else if (Utils.roleID == 4) // Employee
            {
                button1.Visible = false; // Product Management
                button3.Visible = false; // Customer Management
                button4.Visible = false; // Purchase History
                button5.Visible = false; // Employee Management
            }
            else
            {
                // Nếu không có roleID hợp lệ
                button1.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainform main = new Mainform();
            main.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PurchaseHistoryForm purchaseHistoryForm = new PurchaseHistoryForm();
            purchaseHistoryForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee Employee = new Employee();
            Employee.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
        }
    }
}
