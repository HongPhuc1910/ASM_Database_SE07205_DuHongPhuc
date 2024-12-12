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

            if (Utils.roleID == 1)
            {

                // id = 2 la SALE

                // button5.Visible = false;
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
