namespace Stock_Tracker
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnRegister = new System.Windows.Forms.Button();
            lblEmail = new System.Windows.Forms.Label();
            lblRepeatPassword = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtVerify = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnBack = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegister.Location = new System.Drawing.Point(239, 206);
            btnRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(111, 40);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            toolTip1.SetToolTip(btnRegister, "Register's User");
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblEmail.Location = new System.Drawing.Point(125, 68);
            lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(71, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblRepeatPassword
            // 
            lblRepeatPassword.AutoSize = true;
            lblRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRepeatPassword.Location = new System.Drawing.Point(9, 133);
            lblRepeatPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRepeatPassword.Name = "lblRepeatPassword";
            lblRepeatPassword.Size = new System.Drawing.Size(187, 25);
            lblRepeatPassword.TabIndex = 4;
            lblRepeatPassword.Text = "Repeat Password:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPassword.Location = new System.Drawing.Point(84, 96);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(112, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(215, 68);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(116, 23);
            txtEmail.TabIndex = 6;
            toolTip1.SetToolTip(txtEmail, "Enter Email Here");
            // 
            // txtVerify
            // 
            txtVerify.Location = new System.Drawing.Point(215, 138);
            txtVerify.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtVerify.Name = "txtVerify";
            txtVerify.PasswordChar = '*';
            txtVerify.Size = new System.Drawing.Size(116, 23);
            txtVerify.TabIndex = 7;
            toolTip1.SetToolTip(txtVerify, "Verify your password");
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(215, 101);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(116, 23);
            txtPassword.TabIndex = 8;
            toolTip1.SetToolTip(txtPassword, "Enter Password here");
            // 
            // btnBack
            // 
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.Location = new System.Drawing.Point(13, 206);
            btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(111, 40);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            toolTip1.SetToolTip(btnBack, "Returns to Start Screen");
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { infoToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(380, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { userToolStripMenuItem, documentationToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            infoToolStripMenuItem.Text = " Info";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { userGuideToolStripMenuItem, fAQToolStripMenuItem, contactUsToolStripMenuItem, websiteToolStripMenuItem });
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            userToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            userGuideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // fAQToolStripMenuItem
            // 
            fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            fAQToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            fAQToolStripMenuItem.Text = "FAQ";
            fAQToolStripMenuItem.Click += fAQToolStripMenuItem_Click;
            // 
            // contactUsToolStripMenuItem
            // 
            contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            contactUsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            contactUsToolStripMenuItem.Text = "Contact Us!";
            contactUsToolStripMenuItem.Click += contactUsToolStripMenuItem_Click;
            // 
            // documentationToolStripMenuItem
            // 
            documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            documentationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            documentationToolStripMenuItem.Text = "Documentation";
            documentationToolStripMenuItem.Click += documentationToolStripMenuItem_Click;
            // 
            // websiteToolStripMenuItem
            // 
            websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            websiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            websiteToolStripMenuItem.Text = "Website";
            websiteToolStripMenuItem.Click += websiteToolStripMenuItem_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(380, 255);
            Controls.Add(menuStrip1);
            Controls.Add(btnBack);
            Controls.Add(txtPassword);
            Controls.Add(txtVerify);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblRepeatPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnRegister);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmRegister";
            Text = "Register";
            FormClosing += Register_FormClosing;
            Load += frmRegister_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtVerify;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
    }
}