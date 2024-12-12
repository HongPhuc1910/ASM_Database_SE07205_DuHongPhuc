﻿using System;
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
            // SQL query to join tables and retrieve data
            string query = @"
        SELECT 
            ph.purchaseID,
            ph.customerCode,
            c.name,
            ph.productCode,
            p.name,
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


            string queryAll = @"
        SELECT 
            ph.purchaseID,
            ph.customerCode,
            c.name,
            ph.productCode,
            p.name,
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Status = @status", connection);
                cmd.Parameters.AddWithValue("@status", "Active");
                try
                {
                    // Open the connection
                    connection.Open();


                    if (status == 0)
                    {
                        // Create the SQL command
                        SqlCommand command = new SqlCommand(queryAll, connection);

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
                    else
                    {
                        // Create the SQL command
                        SqlCommand command = new SqlCommand(query, connection);

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

                }
                catch (Exception ex)
                {
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
            
        }
    }
}
