using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class PurchaseHistoryForm : Form
    {
        public static string connectionString
       = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";



        string[] items = { "All", "Cancle", "Pending", "Finish" };
        int[] statusValues = { -1, 1, 2, 3 }; // Tương ứng với các trạng thái trong cơ sở dữ liệu
        static int selectID = 0;

        public PurchaseHistoryForm()
        {
            InitializeComponent();


            // Maximum the form and keep it above the Taskbar
            this.WindowState = FormWindowState.Maximized;

            // Set the form border style to ensure it has a standard window look
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Optionally set StartPosition to CenterScreen if you want centered loading
            this.StartPosition = FormStartPosition.CenterScreen;
            dgv_PurchaseHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // this.LoadData();
            LoadPurchaseHistoryWithDetails(dgv_PurchaseHistory, 0);

            comboBox1.Items.AddRange(items);
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private void PurchaseHistory_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            selectID = selectedIndex;
            LoadPurchaseHistoryWithDetails(dgv_PurchaseHistory, selectedIndex - 1);

            // Gets the selected index
            if (selectedIndex != -1) // Check if an item is selected
            {
                MessageBox.Show($"Selected Index: {selectedIndex}");
            }
            else
            {
                MessageBox.Show("No item selected.");
            }
        }




        private void LoadPurchaseHistoryWithDetails(DataGridView dataGridView, int status)
        {
            // SQL query to retrieve all records
            string queryAll = @"
    SELECT 
        ph.purchaseID,
        ph.customerCode,
        c.name AS CustomerName,
        ph.productCode,
        p.name AS ProductName,
        ph.purchaseDate,
        ph.quantity,
        ph.status,
        ph.active
    FROM 
        PurchaseHistory ph
    INNER JOIN 
        Product p ON ph.productCode = p.code
    INNER JOIN 
        Customer c ON ph.customerCode = c.code";

            // SQL query to filter by status
            string query = @"
    SELECT 
        ph.purchaseID,
        ph.customerCode,
        c.name AS CustomerName,
        ph.productCode,
        p.name AS ProductName,
        ph.purchaseDate,
        ph.quantity,
        ph.status,
        ph.active
    FROM 
        PurchaseHistory ph
    INNER JOIN 
        Product p ON ph.productCode = p.code
    INNER JOIN 
        Customer c ON ph.customerCode = c.code 
    WHERE 
        ph.status = @status";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    SqlCommand command;
                    if (status == -1) // "All"
                    {
                        // Use queryAll if "All" is selected
                        command = new SqlCommand(queryAll, connection);
                    }
                    else
                    {
                        // Use query with parameter for other statuses
                        command = new SqlCommand(query, connection);

                        // Truyền giá trị số của trạng thái
                        command.Parameters.AddWithValue("@status", status);
                    }

                    // Execute the command and retrieve data
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to the DataGridView
                    dataGridView.DataSource = dataTable;

                    // Adjust DataGridView settings (optional)
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    // Show error message
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadData()
        {
            // SQL query to fetch data
            string query = "SELECT * FROM PurchaseHistory where active = 1";

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
                    dgv_PurchaseHistory.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPurchaseHistory addPurchaseHistory = new AddPurchaseHistory(); ;
            addPurchaseHistory.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menuform menu = new Menuform();
            // Hiển thị màn hình menu lên đầu 
            menu.Show();
            // Ẩn giao diện của màn hình hiện tại
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Lấy từ khóa từ TextBox
            string keyword = txb_search.Text.Trim();

            // Gọi phương thức tìm kiếm
            SearchPurchaseHistory(dgv_PurchaseHistory, keyword);
        }

        // Phương thức tìm kiếm
        private void SearchPurchaseHistory(DataGridView dataGridView, string keyword)
        {
            // SQL query để tìm kiếm theo tên khách hàng hoặc tên sản phẩm
            string query = @"
    SELECT 
        ph.purchaseID,
        ph.customerCode,
        c.name AS CustomerName,
        ph.productCode,
        p.name AS ProductName,
        ph.purchaseDate,
        ph.quantity,
        ph.status,
        ph.active
    FROM 
        PurchaseHistory ph
    INNER JOIN 
        Product p ON ph.productCode = p.code
    INNER JOIN 
        Customer c ON ph.customerCode = c.code
    WHERE 
        c.name LIKE @keyword OR
        p.name LIKE @keyword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo SqlCommand
                    SqlCommand command = new SqlCommand(query, connection);

                    // Thêm tham số @keyword
                    command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    // Thực thi lệnh và tải dữ liệu
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu trong DataGridView
                    dataGridView.DataSource = dataTable;

                    // Điều chỉnh DataGridView (nếu cần)
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo tài nguyên được giải phóng hoặc đóng kết nối nếu cần
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }




        private string selectedpurchaseID;
        private string selectedcustomerCode;
        private string selectedproductCode;
        private DateTime selectedpurchaseDate;
        private int selectedquantity;
        private int selectedstatus;
        private void dgv_PurchaseHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_PurchaseHistory.Rows[e.RowIndex];

                // Lấy giá trị từ DataGridView
                selectedpurchaseID = selectedRow.Cells["purchaseID"].Value.ToString();
                selectedcustomerCode = selectedRow.Cells["customerCode"].Value.ToString();
                selectedproductCode = selectedRow.Cells["productCode"].Value.ToString();
                selectedpurchaseDate = Convert.ToDateTime(selectedRow.Cells["purchaseDate"].Value);
                selectedquantity = int.Parse(selectedRow.Cells["quantity"].Value.ToString());
                string selectedStatus = selectedRow.Cells["status"].Value.ToString(); // Lấy giá trị status

                // Mở form UpdatePurchaseHistory với giá trị status
                UpdatePurchaseHistory updatePurchase = new UpdatePurchaseHistory(
                    selectedpurchaseID,
                    selectedcustomerCode,
                    selectedproductCode,
                    selectedpurchaseDate,
                    selectedquantity,
                    selectedStatus
                );
                updatePurchase.ShowDialog();
            }
        }
    }
}