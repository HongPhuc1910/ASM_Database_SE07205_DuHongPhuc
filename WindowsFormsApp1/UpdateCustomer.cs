using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class UpdateCustomer : Form
    {
        public static string connectionString
     = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";
        private string phoneNumber;

        public UpdateCustomer(string code, string name, string phoneNumber, string address)
        {
            InitializeComponent();

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txb_phone.Text = phoneNumber + "";
            txb_address.Text = address + "";
            txb_code.Text = code;
            txb_name.Text = name;
        }

        private void UpdateCustomerInDatabase(string code, string name, string phoneNumber, string address)
        {
            string query = "UPDATE Customer SET name = @name, code = @code, address = @address, phoneNumber = @phoneNumber WHERE code = @code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@address", address);

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer update successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void DeleteCustomerFromDatabase(string code)
        {
            string query = "UPDATE Customer SET active = 0 WHERE code = @code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@code", code);

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No customer found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Get updated values from textboxes
            string code = txb_code.Text;
            string name = txb_name.Text;
            string phoneNumber = txb_phone.Text.ToString().Trim();
            string address = txb_address.Text.ToString().Trim();


            UpdateCustomerInDatabase(code, name, phoneNumber, address);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Get the customer code from the textbox
            string code = txb_code.Text.Trim();

            // Confirm before deleting
            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Call method to delete the customer from the database
                DeleteCustomerFromDatabase(code);
            }
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
