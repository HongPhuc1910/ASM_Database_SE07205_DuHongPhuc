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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class UpdateEmployee : Form
    {
        public static string connectionString
     = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";
        public UpdateEmployee(string code, string fullName, string position, string role, string username, string password)
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Initialize TextBox with existing employee data
            txb_code.Text = code;
            txb_name.Text = fullName;
            txb_position.Text = position;
            if (role == "Admin") rbt_admin.Checked = true;
            else if (role == "Warehouse") rbt_warehouse.Checked = true;
            else if (role == "Sale") rbt_sale.Checked = true;
            else if (role == "Customer") rbt_employee.Checked = true;
            txb_username.Text = username;
            txb_password.Text = password;
        }

        private void UpdateEmployeeInDatabase(string code, string fullName, string position, int roleId, string username, string password)
        {
            string query = "UPDATE Employee SET name = @Name, position = @Position, roleid = @RoleId, username = @Username, password = @Password WHERE code = @Code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Name", fullName);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@RoleId", roleId);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(txb_code.Text) ||
                string.IsNullOrWhiteSpace(txb_name.Text) ||
                string.IsNullOrWhiteSpace(txb_position.Text) ||
                string.IsNullOrWhiteSpace(txb_username.Text) ||
                string.IsNullOrWhiteSpace(txb_password.Text))
            {
                MessageBox.Show("Please check the employee information.");
                return;
            }

            string role = GetSelectedRole();
            MessageBox.Show($"Selected role: '{role}'");

            // Lấy roleId
            int roleId = GetRoleId(role);

            if (roleId == -1)
            {
                MessageBox.Show("Invalid role selected.");
                return;
            }

            // Cập nhật thông tin nhân viên
            UpdateEmployeeInDatabase(txb_code.Text, txb_name.Text, txb_position.Text, roleId, txb_username.Text, txb_password.Text);
            this.Close();
        }

        private string GetSelectedRole()
        {
            if (rbt_admin.Checked) return "admin";
            if (rbt_warehouse.Checked) return "warehouse";
            if (rbt_sale.Checked) return "sale";
            if (rbt_employee.Checked) return "employee"; // Đảm bảo "employee" là tên role chính xác
            return string.Empty;
        }

        private string GetSelectedRoleid()
        {
            if (rbt_admin.Checked) return "admin";
            if (rbt_warehouse.Checked) return "warehouse";
            if (rbt_sale.Checked) return "sale";
            if (rbt_employee.Checked) return "customer";

            MessageBox.Show("No role selected."); // Thông báo nếu không có vai trò nào được chọn
            return string.Empty;
        }
        private int GetRoleId(string roleName)
        {
            int roleId = -1;
            string query = "SELECT id FROM [Role] WHERE roleName = @RoleName";

            Console.WriteLine($"Searching for role: '{roleName}'");  // Debug

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoleName", roleName);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    roleId = Convert.ToInt32(result);
                }
            }

            if (roleId == -1)
            {
                throw new ArgumentException($"Invalid role: '{roleName}'");
            }

            return roleId;
        }
        private bool IsValidRole(string roleName)
        {

            var validRoles = new List<string> { "Admin", "Warehouse", "Sale", "Employee" };
            return validRoles.Contains(roleName);
        }


        private void DeleteEmployeeFromDatabase(string code)
        {
            string query = "DELETE FROM Employee WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter to prevent SQL injection
                        command.Parameters.AddWithValue("@Code", code);

                        // Execute the delete command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the specified code.");
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
            // Get the customer code from the textbox
            string code = txb_code.Text.Trim();

            // Confirm before deleting
            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Call method to delete the customer from the database
                DeleteEmployeeFromDatabase(code);
            }
        }
    }
}
