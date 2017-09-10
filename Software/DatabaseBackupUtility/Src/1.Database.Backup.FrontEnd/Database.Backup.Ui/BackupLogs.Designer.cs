namespace Database.Backup.Ui
{
    partial class BackupLogs
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
            this.idBtnBack = new System.Windows.Forms.Button();
            this.idLabelProcessing = new System.Windows.Forms.Label();
            this.idPicLoading = new System.Windows.Forms.PictureBox();
            this.idDataGridViewBackupLog = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idCmbSelectMonth = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idGridViewPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.idLabelLogMonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idPicLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idDataGridViewBackupLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.idGridViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // idBtnBack
            // 
            this.idBtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idBtnBack.Image = global::Database.Backup.Ui.Properties.Resources.previous;
            this.idBtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idBtnBack.Location = new System.Drawing.Point(590, 8);
            this.idBtnBack.Name = "idBtnBack";
            this.idBtnBack.Size = new System.Drawing.Size(70, 45);
            this.idBtnBack.TabIndex = 24;
            this.idBtnBack.Text = "Back";
            this.idBtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.idBtnBack.UseVisualStyleBackColor = true;
            this.idBtnBack.Click += new System.EventHandler(this.idBtnBack_Click);
            // 
            // idLabelProcessing
            // 
            this.idLabelProcessing.AutoSize = true;
            this.idLabelProcessing.Location = new System.Drawing.Point(68, 27);
            this.idLabelProcessing.Name = "idLabelProcessing";
            this.idLabelProcessing.Size = new System.Drawing.Size(59, 13);
            this.idLabelProcessing.TabIndex = 23;
            this.idLabelProcessing.Text = "Processing";
            // 
            // idPicLoading
            // 
            this.idPicLoading.Image = global::Database.Backup.Ui.Properties.Resources.ajax_loader;
            this.idPicLoading.Location = new System.Drawing.Point(25, 12);
            this.idPicLoading.Name = "idPicLoading";
            this.idPicLoading.Size = new System.Drawing.Size(37, 36);
            this.idPicLoading.TabIndex = 22;
            this.idPicLoading.TabStop = false;
            // 
            // idDataGridViewBackupLog
            // 
            this.idDataGridViewBackupLog.AllowUserToResizeColumns = false;
            this.idDataGridViewBackupLog.AllowUserToResizeRows = false;
            this.idDataGridViewBackupLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.idDataGridViewBackupLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idDataGridViewBackupLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idDataGridViewBackupLog.Location = new System.Drawing.Point(0, 0);
            this.idDataGridViewBackupLog.Name = "idDataGridViewBackupLog";
            this.idDataGridViewBackupLog.RowHeadersVisible = false;
            this.idDataGridViewBackupLog.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.idDataGridViewBackupLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.idDataGridViewBackupLog.Size = new System.Drawing.Size(635, 323);
            this.idDataGridViewBackupLog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Month";
            // 
            // idCmbSelectMonth
            // 
            this.idCmbSelectMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idCmbSelectMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCmbSelectMonth.FormattingEnabled = true;
            this.idCmbSelectMonth.Location = new System.Drawing.Point(534, 26);
            this.idCmbSelectMonth.Name = "idCmbSelectMonth";
            this.idCmbSelectMonth.Size = new System.Drawing.Size(111, 21);
            this.idCmbSelectMonth.TabIndex = 0;
            this.idCmbSelectMonth.SelectedIndexChanged += new System.EventHandler(this.idCmbSelectMonth_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idBtnBack);
            this.panel1.Controls.Add(this.idPicLoading);
            this.panel1.Controls.Add(this.idLabelProcessing);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 60);
            this.panel1.TabIndex = 26;
            // 
            // idGridViewPanel
            // 
            this.idGridViewPanel.Controls.Add(this.idDataGridViewBackupLog);
            this.idGridViewPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.idGridViewPanel.Location = new System.Drawing.Point(25, 68);
            this.idGridViewPanel.Name = "idGridViewPanel";
            this.idGridViewPanel.Size = new System.Drawing.Size(635, 323);
            this.idGridViewPanel.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 391);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(660, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 391);
            this.panel4.TabIndex = 29;
            // 
            // idLabelLogMonth
            // 
            this.idLabelLogMonth.AutoSize = true;
            this.idLabelLogMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabelLogMonth.Location = new System.Drawing.Point(22, 24);
            this.idLabelLogMonth.Name = "idLabelLogMonth";
            this.idLabelLogMonth.Size = new System.Drawing.Size(48, 20);
            this.idLabelLogMonth.TabIndex = 30;
            this.idLabelLogMonth.Text = "Logs";
            // 
            // BackupLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 451);
            this.Controls.Add(this.idLabelLogMonth);
            this.Controls.Add(this.idGridViewPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idCmbSelectMonth);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "BackupLogs";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Logs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackupLogs_FormClosing);
            this.Load += new System.EventHandler(this.BackupLogs_Load);
            this.SizeChanged += new System.EventHandler(this.BackupLogs_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.idPicLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idDataGridViewBackupLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.idGridViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button idBtnBack;
        private System.Windows.Forms.Label idLabelProcessing;
        private System.Windows.Forms.PictureBox idPicLoading;
        private System.Windows.Forms.ComboBox idCmbSelectMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView idDataGridViewBackupLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel idGridViewPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label idLabelLogMonth;
    }
}