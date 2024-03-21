namespace Stock_Tracker
{
    partial class HardwareSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardwareSoftware));
            rtbEULA = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // rtbEULA
            // 
            rtbEULA.Location = new System.Drawing.Point(12, 12);
            rtbEULA.Name = "rtbEULA";
            rtbEULA.ReadOnly = true;
            rtbEULA.Size = new System.Drawing.Size(643, 293);
            rtbEULA.TabIndex = 3;
            rtbEULA.Text = resources.GetString("rtbEULA.Text");
            // 
            // HardwareSoftware
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(668, 318);
            Controls.Add(rtbEULA);
            Name = "HardwareSoftware";
            Text = "Hardware and Software";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEULA;
    }
}