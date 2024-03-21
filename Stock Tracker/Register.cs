using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace Stock_Tracker
{
    public partial class frmRegister : Form
    {
        //Keeps the creatures away
        private bool allowClose = true;

        //Connection String
        private static MySqlConnection connection;



        public frmRegister()
        {
            InitializeComponent();

        }
        private bool EULAAgreement = false;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string HashedPassword;
            string Password = Sanitize.SanitizeInput(txtPassword.Text);
            //Checking to see if Email already exists
            string query = $"SELECT * FROM users WHERE Email = '" + txtEmail.Text + "'";
            if (txtEmail.Text != "" || Password != "")
            {
                //throwing it in the database
                using (MySqlCommand validation = new MySqlCommand(query, connection))
                {
                    //addwithvalue prevents SQL injections.
                    validation.Parameters.AddWithValue("@Email", txtEmail.Text);
                    using (MySqlDataReader reader = validation.ExecuteReader())
                    {

                        if (reader.HasRows == false)
                        {

                            EULA eULA = new EULA(EULAAgreement);
                            eULA.FormClosed += EULA_FormClosed;
                            DialogResult result = eULA.ShowDialog();


                            if (result == DialogResult.OK)
                            {
                                bool isValid = Password_Regex.IsValid(Password);

                                if (isValid == true)
                                {
                                    if (Password == txtVerify.Text)
                                    {
                                        HashedPassword = HashingAlgorithm.HashPassword(Password);
                                        query = $"INSERT INTO users (Email, Passwords) VALUES ('" + txtEmail.Text + "', '" + HashedPassword + "')";
                                        using (MySqlCommand command = new MySqlCommand(query, connection))
                                        {
                                            reader.Close();
                                            command.Parameters.AddWithValue("@Email", txtEmail.Text);
                                            command.Parameters.AddWithValue("@Passwords", HashedPassword);
                                            int rowsAffected = command.ExecuteNonQuery();

                                            if (rowsAffected > 0)
                                            {
                                                MessageBox.Show("Registered!");
                                                HashedPassword = "";
                                                //Returns user to login screen after registering
                                                Real_Login loginForm = new Real_Login();
                                                loginForm.Show();
                                                allowClose = false;
                                                Close();
                                                allowClose = true;
                                                loginForm.Focus();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Error with input.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //didnt verify password
                                        MessageBox.Show("Retype Password!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Password must contain at least one number and be a length of 7!");
                                }
                            }
                        }
                        else
                        {
                            //email already in use
                            MessageBox.Show("Account Already Created!");
                        }
                    }
                }
            }
            else
            {
                //Nothing is acutally there
                MessageBox.Show("Please Provide Email and Password!");
            }


        }

        private void EULA_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is EULA)
            {
                EULAAgreement = true;
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            connection = Server_Connection.connectToServer(connection);
        }



        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allowClose == true)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            connection.Close();
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtVerify.Text = "";
            EULAAgreement = false;
            //Return to start
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
