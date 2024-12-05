using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerForm : Form
    {
        public static string connectionString
      = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";

        public CustomerForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Optionally, set StartPosition to CenterScreen if you want centered loading
            this.StartPosition = FormStartPosition.CenterScreen;
            dgv_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadData();


            dgv_customer.CellClick += dataGridView1_CellClick;
        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số hàng
            {

                // Check if the clicked row is valid
                if (e.RowIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgv_customer.Rows[e.RowIndex];

                    // Retrieve data from each cell in the selected row
                    var code = selectedRow.Cells["code"].Value.ToString();
                    var name = selectedRow.Cells["name"].Value.ToString();
                    var phone = selectedRow.Cells["phoneNumber"].Value.ToString();
                    var address = selectedRow.Cells["address"].Value.ToString();

                    UpdateCustomer updateForm = new UpdateCustomer(code, name, phone, address);
                    updateForm.ShowDialog();



                }
            }
        }

        private void LoadData()
        {
            // SQL query to fetch data
            string query = "SELECT * FROM Customer";

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
                    dgv_customer.DataSource = dataTable;
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
            Menuform menu = new Menuform();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv_customer.Rows[e.RowIndex];

                // Retrieve data from each cell in the selected row
                var code = selectedRow.Cells["code"].Value.ToString();
                var name = selectedRow.Cells["name"].Value.ToString();
                var phone = selectedRow.Cells["phoneNumber"].Value.ToString();
                var address = selectedRow.Cells["address"].Value.ToString();


                UpdateCustomer updateForm = new UpdateCustomer(code, name, phone, address);
                updateForm.ShowDialog();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menuform menu = new Menuform();
            // Hiển thị màn hình menu lên đầu 
            menu.Show();
            // Ẩn giao diện của màn hình hiện tại
            this.Hide();
        }
    }
}
