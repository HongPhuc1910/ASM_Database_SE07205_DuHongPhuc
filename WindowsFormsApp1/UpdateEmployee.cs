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
    public partial class UpdateEmployee : Form
    {
        public static string connectionString
     = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";
        public UpdateEmployee(string code, string fullname, string position, int role, string username, string password)
        {
            InitializeComponent();

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
