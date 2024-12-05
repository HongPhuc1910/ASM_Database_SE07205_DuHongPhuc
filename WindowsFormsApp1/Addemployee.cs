using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Addemployee : Form
    {

        public static string connectionString
      = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";

        public Addemployee()
        {
            InitializeComponent();


            // Thiết lập giao diện ở trung tâm màn hình

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = txb_name.Text;
            string code = txb_code.Text;
            string username = txb_username.Text;
            string password = txb_password.Text;

            string hashPassword = HashPassword(password);
            string position = txb_position.Text;

            int roleID = 2;

            InsertData(code, fullname, position, roleID, username, hashPassword);
        }

        private void InsertData(string code, string name, string position, int roleID, string username, string password)
        {
            // Connection string to your database

            // SQL query to insert data
            string query = "INSERT INTO Employee (code, name, position, username, password) VALUES (@code, @name, @position, @username, @password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@position", position);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@roleId", roleID);

                        command.Parameters.AddWithValue("@password", password);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
