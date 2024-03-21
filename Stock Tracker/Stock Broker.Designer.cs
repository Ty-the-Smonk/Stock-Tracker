namespace Stock_Tracker
{
    partial class Stock_Broker
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
            lblEmail = new System.Windows.Forms.Label();
            dgvTracker = new System.Windows.Forms.DataGridView();
            btnTrack = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnBack = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnChangePassword = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTracker).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblEmail.Location = new System.Drawing.Point(13, 24);
            lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(174, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email Goes Here";
            toolTip1.SetToolTip(lblEmail, "Its you!");
            // 
            // dgvTracker
            // 
            dgvTracker.AllowUserToAddRows = false;
            dgvTracker.AllowUserToDeleteRows = false;
            dgvTracker.AllowUserToOrderColumns = true;
            dgvTracker.AllowUserToResizeColumns = false;
            dgvTracker.AllowUserToResizeRows = false;
            dgvTracker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTracker.Location = new System.Drawing.Point(14, 165);
            dgvTracker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvTracker.Name = "dgvTracker";
            dgvTracker.ReadOnly = true;
            dgvTracker.Size = new System.Drawing.Size(482, 279);
            dgvTracker.TabIndex = 3;
            toolTip1.SetToolTip(dgvTracker, "Stocks Currently being tracked are shown here");
            dgvTracker.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTrack
            // 
            btnTrack.Location = new System.Drawing.Point(14, 117);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new System.Drawing.Size(116, 42);
            btnTrack.TabIndex = 4;
            btnTrack.Text = "Track Stock";
            toolTip1.SetToolTip(btnTrack, "Select a stock to track");
            btnTrack.UseVisualStyleBackColor = true;
            btnTrack.Click += btnTrack_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new System.Drawing.Point(136, 117);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(116, 42);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove Stock";
            toolTip1.SetToolTip(btnRemove, "Select a stock to stop tracking");
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(258, 117);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(116, 42);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            toolTip1.SetToolTip(btnRefresh, "Refreshes Stock Prices");
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { infoToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(506, 24);
            menuStrip1.TabIndex = 7;
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
            userToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            userToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            userGuideToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            userGuideToolStripMenuItem.Text = "User Guide";
            userGuideToolStripMenuItem.Click += userGuideToolStripMenuItem_Click;
            // 
            // fAQToolStripMenuItem
            // 
            fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            fAQToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            fAQToolStripMenuItem.Text = "FAQ";
            fAQToolStripMenuItem.Click += fAQToolStripMenuItem_Click;
            // 
            // contactUsToolStripMenuItem
            // 
            contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            contactUsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            contactUsToolStripMenuItem.Text = "Contact Us!";
            contactUsToolStripMenuItem.Click += contactUsToolStripMenuItem_Click;
            // 
            // websiteToolStripMenuItem
            // 
            websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            websiteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            websiteToolStripMenuItem.Text = "Website";
            websiteToolStripMenuItem.Click += websiteToolStripMenuItem_Click;
            // 
            // documentationToolStripMenuItem
            // 
            documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            documentationToolStripMenuItem.Text = "Documentation";
            documentationToolStripMenuItem.Click += documentationToolStripMenuItem_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(380, 117);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(116, 42);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            toolTip1.SetToolTip(btnBack, "Returns to Login Screen");
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new System.Drawing.Point(380, 24);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new System.Drawing.Size(116, 42);
            btnChangePassword.TabIndex = 9;
            btnChangePassword.Text = "Change Password";
            toolTip1.SetToolTip(btnChangePassword, "Lets you change your password");
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(380, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(116, 42);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            toolTip1.SetToolTip(btnSearch, "Search for specific Stock");
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(14, 80);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(360, 23);
            txtSearch.TabIndex = 11;
            // 
            // Stock_Broker
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(506, 458);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnChangePassword);
            Controls.Add(btnBack);
            Controls.Add(menuStrip1);
            Controls.Add(btnRefresh);
            Controls.Add(btnRemove);
            Controls.Add(btnTrack);
            Controls.Add(dgvTracker);
            Controls.Add(lblEmail);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Stock_Broker";
            Text = "Stock Broker";
            FormClosing += Stock_Broker_FormClosing;
            Load += Stock_Broker_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTracker).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dgvTracker;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}