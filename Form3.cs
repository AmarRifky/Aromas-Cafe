using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Aroma_Cafe
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D2N0A5Q;Initial Catalog=Aroma_Cafe;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            HoldernametextBox.Clear();
            CardnumbertextBox.Clear();
            CVVcodetextBox.Clear();
            CComboBox.SelectedIndex = -1;
            AmounttextBox.Clear();
            dateTimePicker1.Value = DateTime.Now;
            EmailtextBox.Clear();
        }

        private void arCustome1_Click(object sender, EventArgs e)
        {
            string Holdername = HoldernametextBox.Text.Trim();
            if (string.IsNullOrEmpty(Holdername))
            {
                MessageBox.Show("Holder Name is required.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cardnumber;
            if (!int.TryParse(CardnumbertextBox.Text.Trim(), out cardnumber))
            {
                MessageBox.Show("Invalid Card Number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int code;
            if (!int.TryParse(CVVcodetextBox.Text.Trim(), out code))
            {
                MessageBox.Show("Invalid CVV Code.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = dateTimePicker1.Value;
            if (selectedDate < DateTime.Now) // Assuming you want to check if the selected date is not in the past
            {
                MessageBox.Show("Invalid Expiry Date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string CardType = CComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(CardType))
            {
                MessageBox.Show("Card Type is required.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float amount;
            if (!float.TryParse(AmounttextBox.Text.Trim(), out amount))
            {
                MessageBox.Show("Invalid Amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO payments (holdername, cardnumber, code, expdate, cardtype, amount) " +
     "VALUES (@Holdername, @Cardnumber, @Code, @ExpDate, @CardType, @Amount)";


            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D2N0A5Q;Initial Catalog=Aroma_Cafe;Integrated Security=True"))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Holdername", Holdername);
                    command.Parameters.AddWithValue("@Cardnumber", cardnumber);
                    command.Parameters.AddWithValue("@Code", code);
                    command.Parameters.AddWithValue("@ExpDate", selectedDate);
                    command.Parameters.AddWithValue("@CardType", CardType);
                    command.Parameters.AddWithValue("@Amount", amount);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Additional code or actions after successful payment
                        }
                        else
                        {
                            MessageBox.Show("Payment failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Additional error handling or actions if payment fails
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"SQL Exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Cardtype_ComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }

}
