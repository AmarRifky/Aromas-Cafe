using Microsoft.VisualBasic.Logging;
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

namespace Aroma_Cafe
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D2N0A5Q;Initial Catalog=Aroma_Cafe;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void arCustome1_Click(object sender, EventArgs e)
        {
          
            string fullname = Fullname_textBox.Text;
            string lastname = Lastname_textBox.Text;
            string email = Email_textBox.Text;
            
            string username = Username_textBox.Text.Trim();
            string password = Password_textBox.Text.Trim();

            // Check if any required fields are empty
            if ( string.IsNullOrEmpty(fullname)  || string.IsNullOrEmpty(lastname)
                ||string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all the required fields.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Assuming you have a SqlConnection object named con
                con.Open();

                // Begin a transaction
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Insert into the 'Reg' table
                    string regQuery = "INSERT INTO Reg (Fullname, Lastname, Email) " +
                        "VALUES (@fullname, @lastname, @email)";

                    using (SqlCommand regCommand = new SqlCommand(regQuery, con, transaction))
                    {
                        // Add parameter values

                        regCommand.Parameters.AddWithValue("@Fullname", fullname);
                        regCommand.Parameters.AddWithValue("@Email", email);
                        regCommand.Parameters.AddWithValue("@lastname", lastname);
                      

                        // Execute the query
                        int regRowsAffected = regCommand.ExecuteNonQuery();

                        if (regRowsAffected <= 0)
                        {
                            // Rollback the transaction and show an error message
                            transaction.Rollback();
                            MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert into the 'Login' table
                    string loginQuery = "INSERT INTO Login (Username, Password) VALUES (@Username, @Password)";

                    using (SqlCommand loginCommand = new SqlCommand(loginQuery, con, transaction))
                    {
                        // Add parameter values
                        loginCommand.Parameters.AddWithValue("@Username", username);
                        loginCommand.Parameters.AddWithValue("@Password", password);

                        // Execute the query
                        int loginRowsAffected = loginCommand.ExecuteNonQuery();

                        if (loginRowsAffected <= 0)
                        {
                            // Rollback the transaction and show an error message
                            transaction.Rollback();
                            MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Commit the transaction if both inserts were successful
                    transaction.Commit();

                    MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Additional code or actions after successful registration

                    //hiding the current form and showing a login form.
                    Form1 login = new Form1();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    // Rollback the transaction and show an error message
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close(); // Close the connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close(); // Close the connection in case of an exception
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
