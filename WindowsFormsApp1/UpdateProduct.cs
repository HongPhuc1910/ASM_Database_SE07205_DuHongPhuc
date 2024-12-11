using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class dgv_UpdateProduct : Form
    {
        public static string connectionString
      = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";



        //(code, name, price, quantity);

        public dgv_UpdateProduct(string code, string name, int price, int quantity)
        {
            {
                InitializeComponent();

                // Set the form to start in the center of the screen
                this.StartPosition = FormStartPosition.CenterScreen;


                // Disable the maximize/restore button
                this.MaximizeBox = false;

                // Optional: Set a fixed border style to prevent resizing
                this.FormBorderStyle = FormBorderStyle.FixedSingle;

                txb_amount.Text = quantity + "";
                txb_price.Text = price + "";
                txb_code.Text = code;
                txb_name.Text = name;
            }
        }

        private void txb_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateProductInDatabase(string code, string name, int price, int quantity)
        {
            string query = "UPDATE Product SET Name = @Name, Price = @Price, Quantity = @Quantity WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Quantity", quantity);

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No product found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void DeleteProductFromDatabase(string code)
        {
            string query = "UPDATE Product SET active = 0 WHERE code = @code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        // Execute the update command

                        command.Parameters.AddWithValue("@code", code);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No product found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Get updated values from textboxes
            string code = txb_code.Text;
            string name = txb_name.Text;
            int price = int.Parse(txb_price.Text.ToString().Trim());
            int quantity = int.Parse(txb_amount.Text.ToString().Trim());


            UpdateProductInDatabase(code, name, price, quantity);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Get the product code from the textbox
            string code = txb_code.Text.Trim();

            // Confirm before deleting
            var confirmResult = MessageBox.Show("Are you sure you want to delete this product?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Call method to delete the product from the database
                DeleteProductFromDatabase(code);
            }
        }
    }
}
