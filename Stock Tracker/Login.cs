using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Tracker
{
    public partial class frmLogin : Form
    {
        private bool allowClose = true;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Opens Window for Register
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
            allowClose = false;
            Close();
            allowClose = true;
            registerForm.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Opens Window for Login
            Real_Login loginForm = new Real_Login();
            loginForm.Show();
            allowClose = false;
            Close();
            allowClose = true;
            loginForm.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //This looks weird but let me explain. In the Program.cs I have changed it so that when I close a form, it does NOT close the application. So I have a check when I go
            //from form to form where if the user exits by any other means than going to another form then it end the application.
            if (allowClose == true)
            {
                Application.Exit();
            }
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
