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
            string query = "SELECT * FROM Employee";

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
    }
}