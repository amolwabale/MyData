namespace Database.Backup.Ui
{
    partial class Help
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
            this.idWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // idWebBrowser
            // 
            this.idWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.idWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.idWebBrowser.Name = "idWebBrowser";
            this.idWebBrowser.Size = new System.Drawing.Size(610, 330);
            this.idWebBrowser.TabIndex = 0;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 330);
            this.Controls.Add(this.idWebBrowser);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Help_FormClosing);
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser idWebBrowser;
    }
}