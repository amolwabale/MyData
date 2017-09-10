namespace Accounting.Ui.Forms.MainApp
{
    partial class MastersUnit
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
            this.idDgvMasterUnit = new System.Windows.Forms.DataGridView();
            this.idTxtUnit = new System.Windows.Forms.TextBox();
            this.idBtnDelete = new System.Windows.Forms.Button();
            this.idBtnClose = new System.Windows.Forms.Button();
            this.idBtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idDgvMasterUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // idDgvMasterUnit
            // 
            this.idDgvMasterUnit.AllowUserToAddRows = false;
            this.idDgvMasterUnit.AllowUserToDeleteRows = false;
            this.idDgvMasterUnit.AllowUserToResizeColumns = false;
            this.idDgvMasterUnit.AllowUserToResizeRows = false;
            this.idDgvMasterUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.idDgvMasterUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idDgvMasterUnit.Location = new System.Drawing.Point(36, 113);
            this.idDgvMasterUnit.Name = "idDgvMasterUnit";
            this.idDgvMasterUnit.ReadOnly = true;
            this.idDgvMasterUnit.RowHeadersVisible = false;
            this.idDgvMasterUnit.RowTemplate.Height = 24;
            this.idDgvMasterUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.idDgvMasterUnit.Size = new System.Drawing.Size(297, 303);
            this.idDgvMasterUnit.TabIndex = 0;
            // 
            // idTxtUnit
            // 
            this.idTxtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtUnit.Location = new System.Drawing.Point(36, 38);
            this.idTxtUnit.Name = "idTxtUnit";
            this.idTxtUnit.Size = new System.Drawing.Size(297, 28);
            this.idTxtUnit.TabIndex = 1;
            // 
            // idBtnDelete
            // 
            this.idBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnDelete.Location = new System.Drawing.Point(138, 72);
            this.idBtnDelete.Name = "idBtnDelete";
            this.idBtnDelete.Size = new System.Drawing.Size(89, 35);
            this.idBtnDelete.TabIndex = 3;
            this.idBtnDelete.Text = "Delete";
            this.idBtnDelete.UseVisualStyleBackColor = true;
            this.idBtnDelete.Click += new System.EventHandler(this.idBtnDelete_Click);
            // 
            // idBtnClose
            // 
            this.idBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnClose.Location = new System.Drawing.Point(240, 72);
            this.idBtnClose.Name = "idBtnClose";
            this.idBtnClose.Size = new System.Drawing.Size(92, 35);
            this.idBtnClose.TabIndex = 4;
            this.idBtnClose.Text = "Close";
            this.idBtnClose.UseVisualStyleBackColor = true;
            this.idBtnClose.Click += new System.EventHandler(this.idBtnClose_Click);
            // 
            // idBtnAdd
            // 
            this.idBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnAdd.Location = new System.Drawing.Point(35, 72);
            this.idBtnAdd.Name = "idBtnAdd";
            this.idBtnAdd.Size = new System.Drawing.Size(90, 35);
            this.idBtnAdd.TabIndex = 2;
            this.idBtnAdd.Text = "Add";
            this.idBtnAdd.UseVisualStyleBackColor = true;
            this.idBtnAdd.Click += new System.EventHandler(this.idBtnAdd_Click);
            // 
            // MastersUnit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(365, 447);
            this.Controls.Add(this.idBtnClose);
            this.Controls.Add(this.idBtnDelete);
            this.Controls.Add(this.idBtnAdd);
            this.Controls.Add(this.idTxtUnit);
            this.Controls.Add(this.idDgvMasterUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MastersUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master - Unit";
            this.Load += new System.EventHandler(this.MastersUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idDgvMasterUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView idDgvMasterUnit;
        private System.Windows.Forms.TextBox idTxtUnit;
        private System.Windows.Forms.Button idBtnAdd;
        private System.Windows.Forms.Button idBtnDelete;
        private System.Windows.Forms.Button idBtnClose;
    }
}