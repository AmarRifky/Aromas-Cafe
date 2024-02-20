using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Aroma_Cafe
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D2N0A5Q;Initial Catalog=Aroma_Cafe;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            PasswordtextBox.Clear();
            UsernametextBox.Clear();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            _ = UsernametextBox.Text;
            _ = PasswordtextBox.Text;

            if (UsernametextBox.Text == "" || PasswordtextBox.Text == "")
            {
                MessageBox.Show("Please Fill The User Name And Password ", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT COUNT(*) FROM login Where username='" + UsernametextBox.Text + "'AND password='" + PasswordtextBox.Text + "'",con);
                DataTable datatbl = new DataTable();
                sqlda.Fill(datatbl);
                if (datatbl.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show(" Login Successfull ", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Form2 page = new Form2();
                    page.Show();
                }
                else
                {
                    MessageBox.Show(" Login Failed ", "Login Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    PasswordtextBox.Clear();
                    UsernametextBox.Clear();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void UsernametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}