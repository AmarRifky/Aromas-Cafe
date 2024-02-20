using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aroma_Cafe
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=DESKTOP-D2N0A5Q;Initial Catalog=Aroma_Cafe;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }
        private void PopulateComboBox(ComboBox comboBox, string category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT ProductName FROM Products WHERE Category = '{category}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["ProductName"].ToString());
                    }
                }
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            // Get selected items and quantities
            string selectedCoffee = CoffeeComboBox.SelectedItem?.ToString();


            int quantityCoffee;

            if (!int.TryParse(QuantityCoffeeTextBox.Text, out quantityCoffee) || quantityCoffee <= 0)
            {
                MessageBox.Show("Please enter a valid quantity for make the order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Calculate total price based on selected items and quantities
            decimal totalCoffee = 0;

            if (!string.IsNullOrEmpty(selectedCoffee))
                totalCoffee = GetProductPrice(selectedCoffee, "Coffee") * quantityCoffee;


            // Sum up the totals for all categories
            decimal grandTotal = totalCoffee;

            CultureInfo SriLankanCulture = new CultureInfo("si-LK");
            // Update the TotalTextBox with the calculated grand total formatted as LKR
            TotalTextBox.Text = string.Format(SriLankanCulture, "{0:C}", grandTotal);

        }
        private decimal GetProductPrice(string productName, string category)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT Price FROM Products WHERE ProductName = '{productName}' AND Category = '{category}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }
            return 0; // Default to 0 if price not found
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 page = new Form3();
            page.Show();
        }
    }
}
