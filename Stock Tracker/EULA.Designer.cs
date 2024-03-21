namespace Stock_Tracker
{
    partial class EULA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EULA));
            rtbEULA = new System.Windows.Forms.RichTextBox();
            btnAccept = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // rtbEULA
            // 
            rtbEULA.Location = new System.Drawing.Point(12, 12);
            rtbEULA.Name = "rtbEULA";
            rtbEULA.ReadOnly = true;
            rtbEULA.Size = new System.Drawing.Size(776, 360);
            rtbEULA.TabIndex = 0;
            rtbEULA.Text = resources.GetString("rtbEULA.Text");
            // 
            // btnAccept
            // 
            btnAccept.Location = new System.Drawing.Point(12, 378);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(115, 60);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(133, 378);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(115, 60);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EULA
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(rtbEULA);
            Name = "EULA";
            Text = "EULA";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEULA;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}