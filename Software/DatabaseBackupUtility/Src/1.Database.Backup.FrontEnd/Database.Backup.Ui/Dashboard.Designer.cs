namespace Database.Backup.Ui
{
    partial class Dashboard
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
            this.idLabelProcessing = new System.Windows.Forms.Label();
            this.idBtnBack = new System.Windows.Forms.Button();
            this.idPicLoading = new System.Windows.Forms.PictureBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idLabelForgotZipPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idLabelServiceStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idPicLoading)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabelProcessing
            // 
            this.idLabelProcessing.AutoSize = true;
            this.idLabelProcessing.Location = new System.Drawing.Point(64, 430);
            this.idLabelProcessing.Name = "idLabelProcessing";
            this.idLabelProcessing.Size = new System.Drawing.Size(59, 13);
            this.idLabelProcessing.TabIndex = 18;
            this.idLabelProcessing.Text = "Processing";
            // 
            // idBtnBack
            // 
            this.idBtnBack.Image = global::Database.Backup.Ui.Properties.Resources.previous;
            this.idBtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idBtnBack.Location = new System.Drawing.Point(613, 410);
            this.idBtnBack.Name = "idBtnBack";
            this.idBtnBack.Size = new System.Drawing.Size(70, 45);
            this.idBtnBack.TabIndex = 19;
            this.idBtnBack.Text = "Back";
            this.idBtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.idBtnBack.UseVisualStyleBackColor = true;
            this.idBtnBack.Click += new System.EventHandler(this.idBtnBack_Click);
            // 
            // idPicLoading
            // 
            this.idPicLoading.Image = global::Database.Backup.Ui.Properties.Resources.ajax_loader;
            this.idPicLoading.Location = new System.Drawing.Point(21, 414);
            this.idPicLoading.Name = "idPicLoading";
            this.idPicLoading.Size = new System.Drawing.Size(37, 36);
            this.idPicLoading.TabIndex = 17;
            this.idPicLoading.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 696;
            this.lineShape1.Y1 = 400;
            this.lineShape1.Y2 = 400;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(695, 461);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idLabelForgotZipPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idLabelServiceStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 375);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application State";
            // 
            // idLabelForgotZipPassword
            // 
            this.idLabelForgotZipPassword.AutoSize = true;
            this.idLabelForgotZipPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idLabelForgotZipPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabelForgotZipPassword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.idLabelForgotZipPassword.Location = new System.Drawing.Point(196, 73);
            this.idLabelForgotZipPassword.Name = "idLabelForgotZipPassword";
            this.idLabelForgotZipPassword.Size = new System.Drawing.Size(249, 15);
            this.idLabelForgotZipPassword.TabIndex = 3;
            this.idLabelForgotZipPassword.Text = "Click here to send Zip password to your mail.\r\n";
            this.idLabelForgotZipPassword.Click += new System.EventHandler(this.idLabelForgotZipPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forgot Zip Password :";
            // 
            // idLabelServiceStatus
            // 
            this.idLabelServiceStatus.AutoSize = true;
            this.idLabelServiceStatus.Location = new System.Drawing.Point(196, 39);
            this.idLabelServiceStatus.Name = "idLabelServiceStatus";
            this.idLabelServiceStatus.Size = new System.Drawing.Size(332, 15);
            this.idLabelServiceStatus.TabIndex = 1;
            this.idLabelServiceStatus.Text = "Backup service not present, Please re install the application.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database backup Service :";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idBtnBack);
            this.Controls.Add(this.idLabelProcessing);
            this.Controls.Add(this.idPicLoading);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idPicLoading)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button idBtnBack;
        private System.Windows.Forms.Label idLabelProcessing;
        private System.Windows.Forms.PictureBox idPicLoading;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idLabelServiceStatus;
        private System.Windows.Forms.Label idLabelForgotZipPassword;
        private System.Windows.Forms.Label label2;
    }
}