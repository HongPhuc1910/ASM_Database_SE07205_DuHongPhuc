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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class UpdatePurchaseHistory : Form
    {
        public static string connectionString
      = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";

        private string purchaseID;
        private string productCode;
        private string customerCode;
        private string purchaseDate;
        private string quantity;


        public UpdatePurchaseHistory(string purchaseID, string customerCode, string productCode, DateTime purchaseDate, int quantity, string status)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            // Gán danh sách status cho ComboBox
            cbx_status.Items.AddRange(new string[] { "Cancle", "Pending", "Finish" });
            cbx_status.SelectedItem = status; // Gán giá trị ban đầu dựa trên dữ liệu hiện có

            // Gán giá trị cho các trường nhập liệu
            txb_purchaseID.Text = purchaseID;
            txb_customerCode.Text = customerCode;
            txb_productCode.Text = productCode;
            dtp_datetime.Text = purchaseDate.ToString("yyyy-MM-dd");
            txb_quantity.Text = quantity.ToString();
        }

        public UpdatePurchaseHistory(string purchaseID, string productCode, string customerCode, string purchaseDate, string quantity, string status)
        {
            this.purchaseID = purchaseID;
            this.productCode = productCode;
            this.customerCode = customerCode;
            this.purchaseDate = purchaseDate;
            this.quantity = quantity;
        }

        private void UpdatePurchaseInDatabase(string purchaseID, string customerCode, string productCode, DateTime purchaseDate, int quantity, int status)
        {
            string query = "UPDATE PurchaseHistory SET customerCode = @customerCode, productCode = @productCode, purchaseDate = @purchaseDate, quantity = @quantity, status = @status WHERE PurchaseID = @purchaseID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@purchaseID", purchaseID);
                        command.Parameters.AddWithValue("@customerCode", customerCode);
                        command.Parameters.AddWithValue("@productCode", productCode);
                        command.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@status", status); // Truyền đúng kiểu int

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Purchase updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No purchase found with the specified ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void UpdatePurchaseHistory_Load(object sender, EventArgs e)
        {
            // Thêm các mục vào ComboBox
            cbx_status.Items.Add("Cancle");
            cbx_status.Items.Add("Pending");
            cbx_status.Items.Add("Finish");

            // Đặt giá trị mặc định nếu cần
            cbx_status.SelectedIndex = 0; // Chọn mục đầu tiên
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của thông tin nhập vào
            if (string.IsNullOrWhiteSpace(txb_purchaseID.Text) ||
                string.IsNullOrWhiteSpace(txb_customerCode.Text) ||
                string.IsNullOrWhiteSpace(txb_productCode.Text) ||
                !DateTime.TryParse(dtp_datetime.Text, out DateTime purchaseDate) ||
                !int.TryParse(txb_quantity.Text, out int quantity) ||
                cbx_status.SelectedItem == null) // Kiểm tra xem người dùng đã chọn status chưa
            {
                MessageBox.Show("Please check the product information and select a valid status.");
                return;
            }

            // Ánh xạ giá trị của ComboBox thành số nguyên
            int status;
            string selectedStatus = cbx_status.SelectedItem.ToString();

            if (selectedStatus == "Cancle")
            {
                status = 0;
            }
            else if (selectedStatus == "Pending")
            {
                status = 1;
            }
            else if (selectedStatus == "Finish")
            {
                status = 2;
            }
            else
            {
                MessageBox.Show("Invalid status selected.");
                return;
            }

            // Gọi hàm Update để cập nhật dữ liệu vào database
            UpdatePurchaseInDatabase(
                txb_purchaseID.Text,
                txb_customerCode.Text,
                txb_productCode.Text,
                purchaseDate,
                quantity,
                status
            );

            MessageBox.Show("Purchase updated successfully!");
            this.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            txb_purchaseID.Clear();
            txb_customerCode.Clear();
            txb_productCode.Clear();
            txb_quantity.Clear();
            cbx_status.SelectedIndex = -1; // Reset ComboBox
        }
    }
}
