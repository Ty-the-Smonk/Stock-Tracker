using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using Microsoft.VisualBasic;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;

namespace Stock_Tracker
{

    public partial class Stock_Broker : Form
    {
        private static MySqlConnection connection;
        private string email;
        private int stockID;
        private int userID;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public Stock_Broker()
        {
            InitializeComponent();
        }

        public Stock_Broker(string email)
        {
            InitializeComponent();
            this.email = email;

        }



        private void Stock_Broker_Activated(object sender, EventArgs e)
        {

        }

        private void Stock_Broker_Load(object sender, EventArgs e)
        {
            connection = Server_Connection.connectToServer(connection);
            lblEmail.Text = email;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Refreshes datagridview used to update prices in real time.
            RefreshGrid();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            string symbol = Interaction.InputBox("Input Symbol", "Track", "");
            bool exists = false;
            exists = GetStockInfo(symbol.ToUpper());


            if (exists == true)
            {
                stockID = GetStockID(symbol);
                string query = "SELECT * FROM userstocks WHERE idUsers = @idUsers AND StockID = @StockID";
                //Checking if stock is already being tracked by this user
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idUsers", userID);
                    command.Parameters.AddWithValue("@StockID", stockID);
                    //Only need to see if the rows exist, reader is kinda over kill here
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 0)
                    {
                        //Adding stock to the tracker
                        query = $"INSERT INTO userstocks (idUsers, StockID) VALUES (@idUsers, @StockID)";
                        using (MySqlCommand insertCommand = new MySqlCommand(query, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@idUsers", userID);
                            insertCommand.Parameters.AddWithValue("@StockID", stockID);

                            // Execute the insert query
                            insertCommand.ExecuteNonQuery();
                        }
                        //Refreshes Grid for User
                        RefreshGrid();
                    }
                    else
                    {
                        //Error
                        MessageBox.Show("Already tracking stock!");
                    }
                }
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string symbol = Interaction.InputBox("Input Symbol", "Stop Tracking", "");
            string query = "SELECT * FROM userstocks WHERE idUsers = @idUsers AND StockID = @StockID";
            GetStockInfo(symbol.ToUpper());
            stockID = GetStockID(symbol);

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idUsers", userID);
                command.Parameters.AddWithValue("@StockID", stockID);
                //Only need to see if the rows exist, reader is kinda over kill here
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count != 0)
                {
                    string deleteQuery = "DELETE FROM userstocks WHERE idUsers = @UserID AND StockID = @StockID";

                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@UserID", userID);
                        deleteCommand.Parameters.AddWithValue("@StockID", stockID);

                        // Execute the delete query
                        deleteCommand.ExecuteNonQuery();

                        MessageBox.Show("Stock successfully removed from tracking.");
                        RefreshGrid();
                    }
                }


            }
        }


        private void RefreshGrid()
        {
            //Refreshes datagridview whenever it updates with new informataion
            dgvTracker.DataSource = null;
            string query = "SELECT Stocks.StockSymbol, Stocks.StockPrice FROM UserStocks INNER JOIN Stocks ON UserStocks.StockID = Stocks.StockID WHERE UserStocks.idUsers = @UserID";
            adapter = new MySqlDataAdapter();
            dataTable = new DataTable();
            List<string> trackedStocks = new List<string>();
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        string stockSymbol = reader.GetString("StockSymbol");


                        trackedStocks.Add(stockSymbol);

                    }
                    reader.Close();
                    foreach (string stockSymbol in trackedStocks)
                    {
                        GetStockInfo(stockSymbol);
                    }


                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView.
                        dgvTracker.DataSource = dataTable;
                    }
                }
            }
        }

        private int GetUserID(string userEmail)
        {
            string query = "SELECT idUsers FROM users WHERE Email = @Email";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", userEmail);

                // ExecuteScalar returns the first column of the first row in the result set
                object result = command.ExecuteScalar();

                // Convert the result to an integer (you might need error handling here)
                int userID = Convert.ToInt32(result);

                return userID;
            }
        }

        private int GetStockID(string stockSymbol)
        {
            string query = "SELECT StockID FROM Stocks WHERE StockSymbol = @StockSymbol";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StockSymbol", stockSymbol);

                // ExecuteScalar returns the first column of the first row in the result set
                object result = command.ExecuteScalar();

                // Convert the result to an integer (you might need error handling here)
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private static bool GetStockInfo(string symbol)
        {
            symbol = Sanitize.SanitizeInput(symbol);
            string query = $"SELECT * FROM stocks WHERE StockSymbol = '" + symbol + "'";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StockSymbol", symbol);
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    string stockSymbol = symbol;

                    string url = $"https://finance.yahoo.com/quote/{stockSymbol}";
                    WebClient client = new WebClient();
                    string html = client.DownloadString(url);

                    HtmlDocument htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(html);

                    // Extracting the stock price using symbol
                    HtmlNode priceNode = htmlDocument.DocumentNode.SelectSingleNode("//*[@id=\"quote-header-info\"]/div[3]/div[1]/div[1]/fin-streamer[1]");
                    if (priceNode != null)
                    {


                        string stockPrice = priceNode.GetAttributeValue("value", "");
                        //Checks if stock is already in the database, if its not it adds it to the stock table. Reasoning: We only need stocks we know our users are tracking.
                        if (reader.HasRows)
                        {
                            reader.Close();
                            query = $"UPDATE stocks SET StockPrice= " + stockPrice + "WHERE StockSymbol='" + stockSymbol + "'";
                            using (MySqlCommand updateCommand = new MySqlCommand(query, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@StockSymbol", stockSymbol);
                                updateCommand.Parameters.AddWithValue("@StockPrice", stockPrice);

                                // Execute the update or insert query
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            reader.Close();
                            query = $"INSERT INTO stocks (StockSymbol, StockPrice) VALUES ('" + stockSymbol + "', '" + stockPrice + "')";
                            using (MySqlCommand insertCommand = new MySqlCommand(query, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@StockSymbol", stockSymbol);
                                insertCommand.Parameters.AddWithValue("@StockPrice", stockPrice);

                                // Execute the update or insert query
                                insertCommand.ExecuteNonQuery();
                            }

                        }
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Stock Does not Exist!");
                        return false;
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
            email = "";
            userID = 0;
            stockID = 0;
            connection.Close();
            Real_Login loginForm = new Real_Login();
            loginForm.Show();
            allowClose = false;
            Close();
            allowClose = true;
            loginForm.Focus();
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string NewPassword;
            //I created an entire inputbox from scratch because the one imported from VB cant use a password Char its 3 AM good lord
            using (scuffedbox Input = new scuffedbox())
            {
                string result = Convert.ToString(Input.ShowDialog());
                //If they input nothing its also a cancel
                if (result == Convert.ToString(DialogResult.OK) && Input.UserInput != "")
                {

                    NewPassword = Sanitize.SanitizeInput(Input.UserInput);
                    string hashedPassword = HashingAlgorithm.HashPassword(NewPassword);
                    string updateQuery = "UPDATE users SET Passwords = @Passwords WHERE idUsers = @idUsers";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Passwords", hashedPassword);
                        command.Parameters.AddWithValue("@idUsers", userID);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Password Changed", "Notification");
                }
            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                // Perform a search based on the entered keyword
                string searchQuery = "SELECT Stocks.StockSymbol, Stocks.StockPrice FROM UserStocks INNER JOIN Stocks ON UserStocks.StockID = Stocks.StockID WHERE UserStocks.idUsers = @UserID AND Stocks.StockSymbol LIKE @SearchKeyword";

                using (MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection))
                {
                    searchCommand.Parameters.AddWithValue("@UserID", userID);
                    searchCommand.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");

                    using (MySqlDataAdapter searchDataAdapter = new MySqlDataAdapter(searchCommand))
                    {
                        searchDataAdapter.Fill(dataTable);

                        // Bind the search results DataTable to the DataGridView
                        dgvTracker.DataSource = dataTable;
                    }
                }
            }
            else
            {
                MessageBox.Show("Not currently tracking stock!");
            }
        }
    }
}
