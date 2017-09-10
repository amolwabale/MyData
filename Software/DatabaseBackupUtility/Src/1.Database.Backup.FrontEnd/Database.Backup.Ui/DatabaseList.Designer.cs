namespace Database.Backup.Ui
{
    partial class DatabaseList
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
            this.idListMasterDatabase = new System.Windows.Forms.ListBox();
            this.idBtnSaveDatabaseList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idListMasterDatabase
            // 
            this.idListMasterDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idListMasterDatabase.FormattingEnabled = true;
            this.idListMasterDatabase.ItemHeight = 15;
            this.idListMasterDatabase.Location = new System.Drawing.Point(12, 12);
            this.idListMasterDatabase.Name = "idListMasterDatabase";
            this.idListMasterDatabase.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.idListMasterDatabase.Size = new System.Drawing.Size(220, 214);
            this.idListMasterDatabase.TabIndex = 0;
            // 
            // idBtnSaveDatabaseList
            // 
            this.idBtnSaveDatabaseList.Location = new System.Drawing.Point(157, 253);
            this.idBtnSaveDatabaseList.Name = "idBtnSaveDatabaseList";
            this.idBtnSaveDatabaseList.Size = new System.Drawing.Size(75, 23);
            this.idBtnSaveDatabaseList.TabIndex = 1;
            this.idBtnSaveDatabaseList.Text = "Save";
            this.idBtnSaveDatabaseList.UseVisualStyleBackColor = true;
            this.idBtnSaveDatabaseList.Click += new System.EventHandler(this.idBtnSaveDatabaseList_Click);
            // 
            // DatabaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 288);
            this.Controls.Add(this.idBtnSaveDatabaseList);
            this.Controls.Add(this.idListMasterDatabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DatabaseList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database List";
            this.Load += new System.EventHandler(this.DatabaseList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox idListMasterDatabase;
        private System.Windows.Forms.Button idBtnSaveDatabaseList;
    }
}