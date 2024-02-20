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

namespace Aroma_Cafe
{
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=DESKTOP-D2N0A5Q;Initial Catalog=Aroma_Cafe;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
               // string connectionString = @"Data Source=DESKTOP-D2N0A5Q;Initial Catalog=Aroma_Cafe;Integrated Security=True";
                string query = "SELECT ProductName, Category, Price FROM Products";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you have a DataGridView named dataGridViewCourses
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Additional error handling or actions if data retrieval fails
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string productName = productnametextBox.Text;
                string category = ComboBox.Text;
                float price = float.Parse(PricetextBox.Text);

                string query = "INSERT INTO Products (ProductName, Category, Price) VALUES (@ProductName, @Category, @Price)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Price", price);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Product added successfully.");
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string productName = productnametextBox.Text;
                string category = ComboBox.Text;
                float price = float.Parse(PricetextBox.Text);

                string query = "UPDATE Products SET Category = @Category, Price = @Price WHERE ProductName = @ProductName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Price", price);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Product updated successfully.");
                    else
                        MessageBox.Show("Product not found.");
                }
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string productName = productnametextBox.Text;

                string query = "DELETE FROM Products WHERE ProductName = @ProductName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Product deleted successfully.");
                    else
                        MessageBox.Show("Product not found.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
