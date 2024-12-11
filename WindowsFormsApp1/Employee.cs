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
    public partial class Employee : Form
    {
        public static string connectionString
      = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";
        public Employee()
        {
            InitializeComponent();

            // Maximum the form and keep it above the Taskbar
            this.WindowState = FormWindowState.Maximized;

            // Set the form border style to ensure it has a standard window look
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Optionally set StartPosition to CenterScreen if you want centered loading
            this.StartPosition = FormStartPosition.CenterScreen;
            dgv_Employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadData();
        }
        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            // SQL query to fetch data
            string query = "SELECT * FROM Employee where active = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with query results
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dgv_Employee.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addemployee addemployee = new Addemployee();
            addemployee.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menuform menu = new Menuform();
            // Hiển thị màn hình menu lên đầu 
            menu.Show();
            // Ẩn giao diện của màn hình hiện tại
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgv_Employee.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_Employee.SelectedRows[0];

                // Tạo instance của UpdateEmployee và truyền thông tin nhân viên
                UpdateEmployee updateForm = new UpdateEmployee(
                    selectedRow.Cells["code"].Value.ToString(),
                    selectedRow.Cells["name"].Value.ToString(), // Cập nhật ở đây
                    selectedRow.Cells["position"].Value.ToString(),
                    selectedRow.Cells["roleid"].Value.ToString(), // Cập nhật ở đây
                    selectedRow.Cells["username"].Value.ToString(),
                    selectedRow.Cells["password"].Value.ToString() // Cập nhật ở đây
                );

                // Hiển thị form cập nhật
                updateForm.ShowDialog();

                // Tải lại dữ liệu sau khi cập nhật
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật.");
            }
        }

        private void dgv_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu có hàng được chọn
            {
                DataGridViewRow selectedRow = dgv_Employee.Rows[e.RowIndex];

                // Lấy thông tin từ các cột hiện có
                string code = selectedRow.Cells["code"].Value?.ToString() ?? "N/A";
                string name = selectedRow.Cells["name"].Value?.ToString() ?? "N/A"; // Sử dụng 'name'
                string position = selectedRow.Cells["position"].Value?.ToString() ?? "N/A";
                string roleId = selectedRow.Cells["roleid"].Value?.ToString() ?? "N/A"; // Sử dụng 'roleid'
                string username = selectedRow.Cells["username"].Value?.ToString() ?? "N/A";
                string password = selectedRow.Cells["password"].Value?.ToString() ?? "N/A"; // Sử dụng 'password'

                // Tạo instance của UpdateEmployee và truyền thông tin
                UpdateEmployee updateEmployee = new UpdateEmployee(code, name,  position, roleId, username, password); // Truyền mật khẩu vào form
                // Hiển thị form cập nhật
                updateEmployee.ShowDialog();
            }
        }
    }
}