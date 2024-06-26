﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Tracker
{
    public partial class scuffedbox : Form
    {
        public string UserInput { get; private set; }

        public scuffedbox()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool containsNumber = false;
            bool hasMinimumLength = Password.Length >= 7;

            foreach (char character in Password)
            {
                if (char.IsDigit(character))
                {
                    containsNumber = true;
                }
            }

            if (containsNumber == true && hasMinimumLength == true)
            {
                this.DialogResult = DialogResult.OK;
                this.UserInput = txtPassword.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Password must contain at least one number and be a length of 7!");
            }
        }
    }
}
