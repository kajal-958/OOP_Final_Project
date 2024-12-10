using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FinancialTracker
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source= LAPTOPD\\SQLEXPRESS; Initial Catalog= FinanicalTracker; Integrated Security = True; TrustServerCertificate=True;"; //Deepanshi
        // private string connectionString = "Data Source= LAPTOPD\\SQLEXPRESS; Initial Catalog= FinanicalTracker; Integrated Security = True; TrustServerCertificate=True;"; //Kajal
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate credentials
            if (ValidateLogin(username, password, email))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //OpenMainForm(); // Proceed to the main form
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateLogin(string username, string password, string email)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password AND Email = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private void OpenMainForm()
        {
            Form1 mainForm = new Form1();  // the income and expenses form should be here 
            mainForm.Show();
            this.Hide();
        }
    }
}
