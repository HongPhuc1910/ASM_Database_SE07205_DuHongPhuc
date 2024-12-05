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
    public partial class Mainform : Form
    {
        public static string connectionString
       = "Server=HPL2024\\SQLEXPRESS;Database=ASM1;Trusted_Connection=True;";

        public Mainform()
        {
            InitializeComponent();

            // Maximum the form and keep it above the Taskbar
            this.WindowState = FormWindowState.Maximized;

            // Set the form border style to ensure it has a standard window look
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Optionally set StartPosition to CenterScreen if you want centered loading
            this.StartPosition = FormStartPosition.CenterScreen;
            dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            //this.dgv_product.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.LoadData();

            dgv_product.CellClick += dataGridView1_CellClick;
        }

        

        private void LoadData()
        {
            // SQL query to fetch data
            string query = "SELECT * FROM Product";

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
                    dgv_product.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();

            form.ShowDialog();
        }
        private string selectedProductCode;
        private string selectedProductName;
        private int selectedProductPrice;
        private int selectedProductQuantity;
      /*  private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
*/
                private void button2_Click_1(object sender, EventArgs e)
        {

            this.LoadData();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv_product.Rows[e.RowIndex];

                // Retrieve data from each cell in the selected row
                var code = selectedRow.Cells["Code"].Value.ToString();
                var name = selectedRow.Cells["Name"].Value.ToString();
                var price = int.Parse(selectedRow.Cells["Price"].Value.ToString());
                var quantity = int.Parse(selectedRow.Cells["Quantity"].Value.ToString());

                // Display data in textboxes or labels, or use it as needed
                /*  txtID.Text = id.ToString();
                  txtName.Text = name;
                  txtAge.Text = age.ToString();*/

                // MessageBox.Show($"Code  : {code}, Name: {name}, Price: {price},  Quantity: {quantity}");


                dgv_UpdateProduct updateProduct = new dgv_UpdateProduct(code, name, price, quantity);
                updateProduct.ShowDialog();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menuform menu = new Menuform();
            // Hiển thị màn hình menu lên đầu 
            menu.Show();
            // Ẩn giao diện của màn hình hiện tại
            this.Hide();
        }
    }
}