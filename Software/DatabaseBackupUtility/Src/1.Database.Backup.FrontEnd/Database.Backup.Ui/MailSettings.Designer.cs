namespace Database.Backup.Ui
{
    partial class MailSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTxtPort = new System.Windows.Forms.TextBox();
            this.idTxtHost = new System.Windows.Forms.TextBox();
            this.idCmbEnableSsl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idTxtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxtMailFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idBtnDeleteMail = new System.Windows.Forms.Button();
            this.idListReceipient = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idBtnAddReceipient = new System.Windows.Forms.Button();
            this.idTxtReceipient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idLabelProcessing = new System.Windows.Forms.Label();
            this.idBtnTest = new System.Windows.Forms.Button();
            this.idBtnSaveSettings = new System.Windows.Forms.Button();
            this.idPicLoading = new System.Windows.Forms.PictureBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.idBtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idPicLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idTxtPort);
            this.groupBox1.Controls.Add(this.idTxtHost);
            this.groupBox1.Controls.Add(this.idCmbEnableSsl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.idTxtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.idTxtMailFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idBtnDeleteMail);
            this.groupBox1.Controls.Add(this.idListReceipient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idBtnAddReceipient);
            this.groupBox1.Controls.Add(this.idTxtReceipient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(895, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Backup Mail";
            // 
            // idTxtPort
            // 
            this.idTxtPort.Location = new System.Drawing.Point(199, 366);
            this.idTxtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTxtPort.Name = "idTxtPort";
            this.idTxtPort.Size = new System.Drawing.Size(639, 24);
            this.idTxtPort.TabIndex = 13;
            // 
            // idTxtHost
            // 
            this.idTxtHost.Location = new System.Drawing.Point(199, 322);
            this.idTxtHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTxtHost.Name = "idTxtHost";
            this.idTxtHost.Size = new System.Drawing.Size(639, 24);
            this.idTxtHost.TabIndex = 11;
            // 
            // idCmbEnableSsl
            // 
            this.idCmbEnableSsl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCmbEnableSsl.FormattingEnabled = true;
            this.idCmbEnableSsl.Items.AddRange(new object[] {
            "True",
            "False"});
            this.idCmbEnableSsl.Location = new System.Drawing.Point(199, 409);
            this.idCmbEnableSsl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idCmbEnableSsl.Name = "idCmbEnableSsl";
            this.idCmbEnableSsl.Size = new System.Drawing.Size(639, 26);
            this.idCmbEnableSsl.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 418);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Enable SSL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Host";
            // 
            // idTxtPassword
            // 
            this.idTxtPassword.Location = new System.Drawing.Point(199, 278);
            this.idTxtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTxtPassword.Name = "idTxtPassword";
            this.idTxtPassword.Size = new System.Drawing.Size(639, 24);
            this.idTxtPassword.TabIndex = 9;
            this.idTxtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // idTxtMailFrom
            // 
            this.idTxtMailFrom.Location = new System.Drawing.Point(199, 234);
            this.idTxtMailFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTxtMailFrom.Name = "idTxtMailFrom";
            this.idTxtMailFrom.Size = new System.Drawing.Size(639, 24);
            this.idTxtMailFrom.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mail From";
            // 
            // idBtnDeleteMail
            // 
            this.idBtnDeleteMail.Location = new System.Drawing.Point(739, 96);
            this.idBtnDeleteMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBtnDeleteMail.Name = "idBtnDeleteMail";
            this.idBtnDeleteMail.Size = new System.Drawing.Size(100, 28);
            this.idBtnDeleteMail.TabIndex = 5;
            this.idBtnDeleteMail.Text = "Delete";
            this.idBtnDeleteMail.UseVisualStyleBackColor = true;
            this.idBtnDeleteMail.Click += new System.EventHandler(this.idBtnDeleteMail_Click);
            // 
            // idListReceipient
            // 
            this.idListReceipient.FormattingEnabled = true;
            this.idListReceipient.ItemHeight = 18;
            this.idListReceipient.Location = new System.Drawing.Point(199, 96);
            this.idListReceipient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idListReceipient.Name = "idListReceipient";
            this.idListReceipient.Size = new System.Drawing.Size(539, 112);
            this.idListReceipient.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recipient  List";
            // 
            // idBtnAddReceipient
            // 
            this.idBtnAddReceipient.Location = new System.Drawing.Point(739, 47);
            this.idBtnAddReceipient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBtnAddReceipient.Name = "idBtnAddReceipient";
            this.idBtnAddReceipient.Size = new System.Drawing.Size(100, 28);
            this.idBtnAddReceipient.TabIndex = 2;
            this.idBtnAddReceipient.Text = "Add";
            this.idBtnAddReceipient.UseVisualStyleBackColor = true;
            this.idBtnAddReceipient.Click += new System.EventHandler(this.idBtnAddReceipient_Click);
            // 
            // idTxtReceipient
            // 
            this.idTxtReceipient.Location = new System.Drawing.Point(199, 48);
            this.idTxtReceipient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTxtReceipient.Name = "idTxtReceipient";
            this.idTxtReceipient.Size = new System.Drawing.Size(543, 24);
            this.idTxtReceipient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipient";
            // 
            // idLabelProcessing
            // 
            this.idLabelProcessing.AutoSize = true;
            this.idLabelProcessing.Location = new System.Drawing.Point(91, 527);
            this.idLabelProcessing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabelProcessing.Name = "idLabelProcessing";
            this.idLabelProcessing.Size = new System.Drawing.Size(78, 17);
            this.idLabelProcessing.TabIndex = 17;
            this.idLabelProcessing.Text = "Processing";
            // 
            // idBtnTest
            // 
            this.idBtnTest.Image = global::Database.Backup.Ui.Properties.Resources.gears__1_;
            this.idBtnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idBtnTest.Location = new System.Drawing.Point(695, 503);
            this.idBtnTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBtnTest.Name = "idBtnTest";
            this.idBtnTest.Size = new System.Drawing.Size(93, 55);
            this.idBtnTest.TabIndex = 19;
            this.idBtnTest.Text = "Test";
            this.idBtnTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.idBtnTest.UseVisualStyleBackColor = true;
            this.idBtnTest.Click += new System.EventHandler(this.idBtnTest_Click);
            // 
            // idBtnSaveSettings
            // 
            this.idBtnSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.idBtnSaveSettings.Image = global::Database.Backup.Ui.Properties.Resources.save1;
            this.idBtnSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idBtnSaveSettings.Location = new System.Drawing.Point(800, 503);
            this.idBtnSaveSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBtnSaveSettings.Name = "idBtnSaveSettings";
            this.idBtnSaveSettings.Size = new System.Drawing.Size(93, 55);
            this.idBtnSaveSettings.TabIndex = 16;
            this.idBtnSaveSettings.Text = "Save";
            this.idBtnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.idBtnSaveSettings.UseVisualStyleBackColor = true;
            this.idBtnSaveSettings.Click += new System.EventHandler(this.idBtnSaveSettings_Click);
            // 
            // idPicLoading
            // 
            this.idPicLoading.Image = global::Database.Backup.Ui.Properties.Resources.ajax_loader;
            this.idPicLoading.Location = new System.Drawing.Point(33, 508);
            this.idPicLoading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idPicLoading.Name = "idPicLoading";
            this.idPicLoading.Size = new System.Drawing.Size(49, 44);
            this.idPicLoading.TabIndex = 16;
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
            this.shapeContainer1.Size = new System.Drawing.Size(927, 567);
            this.shapeContainer1.TabIndex = 20;
            this.shapeContainer1.TabStop = false;
            // 
            // idBtnBack
            // 
            this.idBtnBack.Image = global::Database.Backup.Ui.Properties.Resources.previous;
            this.idBtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idBtnBack.Location = new System.Drawing.Point(589, 503);
            this.idBtnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBtnBack.Name = "idBtnBack";
            this.idBtnBack.Size = new System.Drawing.Size(93, 55);
            this.idBtnBack.TabIndex = 21;
            this.idBtnBack.Text = "Back";
            this.idBtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.idBtnBack.UseVisualStyleBackColor = true;
            this.idBtnBack.Click += new System.EventHandler(this.idBtnBack_Click);
            // 
            // MailSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 567);
            this.Controls.Add(this.idBtnBack);
            this.Controls.Add(this.idBtnTest);
            this.Controls.Add(this.idBtnSaveSettings);
            this.Controls.Add(this.idLabelProcessing);
            this.Controls.Add(this.idPicLoading);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MailSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MailSettings_FormClosing);
            this.Load += new System.EventHandler(this.MailSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idPicLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button idBtnTest;
        private System.Windows.Forms.Button idBtnSaveSettings;
        private System.Windows.Forms.Label idLabelProcessing;
        private System.Windows.Forms.PictureBox idPicLoading;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button idBtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button idBtnAddReceipient;
        private System.Windows.Forms.TextBox idTxtReceipient;
        private System.Windows.Forms.Button idBtnDeleteMail;
        private System.Windows.Forms.ListBox idListReceipient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxtMailFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTxtPort;
        private System.Windows.Forms.TextBox idTxtHost;
        private System.Windows.Forms.ComboBox idCmbEnableSsl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTxtPassword;
    }
}