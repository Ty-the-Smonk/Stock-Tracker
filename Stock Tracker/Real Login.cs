using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Stock_Tracker
{
    public partial class Real_Login : Form
    {
        //Connection String
        private static MySqlConnection connection;


        public Real_Login()
        {
            InitializeComponent();
        }

        private void Real_Login_Load(object sender, EventArgs e)
        {
            connection = Server_Connection.connectToServer(connection);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email;
            string Password;
            email = Sanitize.SanitizeInput(txtEmail.Text);
            Password = Sanitize.SanitizeInput(txtPassword.Text);
            // Retrieve hashed password from the database based on the email
            string query = $"SELECT Passwords FROM users WHERE Email = '" + email + "'";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        // Get the hashed password from the database
                        string hashedPasswordFromDB = reader.GetString("Passwords");

                        // Verify the password
                        if (HashingAlgorithm.VerifyPassword(Password, hashedPasswordFromDB))
                        {
                            MessageBox.Show("Login successful!");
                            Stock_Broker stockBrocker = new Stock_Broker(email);
                            email = "";
                            Password = "";
                            stockBrocker.Show();
                            connection.Close();
                            allowClose = false;
                            Close();
                            allowClose = true;
                            stockBrocker.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }
        }
        private bool allowClose = true;
        private void Stock_Broker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowClose == true)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            connection.Close();
            frmLogin start = new frmLogin();
            start.Show();
            allowClose = false;
            Close();
            allowClose = true;
            start.Focus();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email: Hpr1@pct.edu", "Contact Us");
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAQ fAQ = new FAQ();
            fAQ.Show();
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Guide user_Guide = new User_Guide();
            user_Guide.Show();
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HardwareSoftware software = new HardwareSoftware();
            software.Show();
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start https://sites.google.com/view/stocktrackerproject/home",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            });
        }
    }
}
