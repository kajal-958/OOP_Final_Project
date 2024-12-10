using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialTracker
{
    public partial class registrationForm : Form
    {
        private string connectionString = "Data Source= LAPTOPD\\SQLEXPRESS; Initial Catalog= FinanicalTracker; Integrated Security = True; TrustServerCertificate=True;"; //Deepanshi
        // private string connectionString = "Data Source= LAPTOPD\\SQLEXPRESS; Initial Catalog= FinanicalTracker; Integrated Security = True; TrustServerCertificate=True;"; //Kajal
        public registrationForm()
        {
            InitializeComponent();
            txtRegisterPassword.UseSystemPasswordChar = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegisterUserName.Text.Trim();
            string password = txtRegisterPassword.Text.Trim();
            string email = txtRegisterEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (UserName, Password, Email) VALUES (@UserName, @Password, @Email)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //OpenLoginForm(); // Switch to login form after successful registration
                        }
                        else
                        {
                            MessageBox.Show("Registration Failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void OpenLoginForm()
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide(); // Hide the current form
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void lblCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtRegisterPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
