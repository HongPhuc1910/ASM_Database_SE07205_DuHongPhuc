using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional Set a fixed border style to prevent resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txb_username.Text;
            string password = txb_password.Text;

            string hashPassword = Utils.HashPassword(password);

            bool checkLogin = CheckLogin(username, hashPassword);

            if (checkLogin)
            {
                Menuform main = new Menuform();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txb_password_TextChanged(object sender, EventArgs e)
        {

        }
        public static string connectionString
        = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";
        private bool CheckLogin(string username, string hashedPassword)
        {
            string query = "SELECT password, roleId FROM Employee WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["password"].ToString(); // Retrieved hashed password
                            int roleId = Convert.ToInt32(reader["roleId"]); // Retrieved roleId


                            Utils.roleID = roleId; // Assign the roleId to your global variable or utility class

                            return storedHash == hashedPassword; // Compare the hashes
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return false; // Return false if username not found or any error occurs
        }
    }
}