namespace Stock_Tracker
{
    partial class Real_Login
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
            txtPassword = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnBack = new System.Windows.Forms.Button();
            websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(154, 96);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(116, 23);
            txtPassword.TabIndex = 15;
            toolTip1.SetToolTip(txtPassword, "Enter Password Here");
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(154, 51);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(116, 23);
            txtEmail.TabIndex = 13;
            toolTip1.SetToolTip(txtEmail, "Enter Email Here");
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPassword.Location = new System.Drawing.Point(17, 89);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(112, 25);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblEmail.Location = new System.Drawing.Point(64, 46);
            lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(71, 25);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.Location = new System.Drawing.Point(154, 147);
            btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(111, 40);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            toolTip1.SetToolTip(btnLogin, "Checks Login information");
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { infoToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(299, 24);
            menuStrip1.TabIndex = 16;
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
            userGuideToolStripMenuItem.Click += userGuideToolStripMenuItem_Click;
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
            // btnBack
            // 
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.Location = new System.Drawing.Point(13, 147);
            btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(111, 40);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            toolTip1.SetToolTip(btnBack, "Returns to Start Screen");
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // websiteToolStripMenuItem
            // 
            websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            websiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            websiteToolStripMenuItem.Text = "Website";
            websiteToolStripMenuItem.Click += websiteToolStripMenuItem_Click;
            // 
            // Real_Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(299, 206);
            Controls.Add(btnBack);
            Controls.Add(menuStrip1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnLogin);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Real_Login";
            Text = "Real_Login";
            FormClosing += Stock_Broker_FormClosing;
            Load += Real_Login_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
    }
}