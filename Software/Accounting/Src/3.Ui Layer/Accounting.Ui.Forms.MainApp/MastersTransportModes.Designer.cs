namespace Accounting.Ui.Forms.MainApp
{
    partial class MastersTransportModes
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
            this.idBtnClose = new System.Windows.Forms.Button();
            this.idBtnDelete = new System.Windows.Forms.Button();
            this.idBtnAdd = new System.Windows.Forms.Button();
            this.idTxtTransportMode = new System.Windows.Forms.TextBox();
            this.idDgvMasterTransportMode = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.idDgvMasterTransportMode)).BeginInit();
            this.SuspendLayout();
            // 
            // idBtnClose
            // 
            this.idBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnClose.Location = new System.Drawing.Point(238, 68);
            this.idBtnClose.Name = "idBtnClose";
            this.idBtnClose.Size = new System.Drawing.Size(92, 35);
            this.idBtnClose.TabIndex = 9;
            this.idBtnClose.Text = "Close";
            this.idBtnClose.UseVisualStyleBackColor = true;
            this.idBtnClose.Click += new System.EventHandler(this.idBtnClose_Click);
            // 
            // idBtnDelete
            // 
            this.idBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnDelete.Location = new System.Drawing.Point(136, 68);
            this.idBtnDelete.Name = "idBtnDelete";
            this.idBtnDelete.Size = new System.Drawing.Size(89, 35);
            this.idBtnDelete.TabIndex = 8;
            this.idBtnDelete.Text = "Delete";
            this.idBtnDelete.UseVisualStyleBackColor = true;
            this.idBtnDelete.Click += new System.EventHandler(this.idBtnDelete_Click);
            // 
            // idBtnAdd
            // 
            this.idBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnAdd.Location = new System.Drawing.Point(33, 68);
            this.idBtnAdd.Name = "idBtnAdd";
            this.idBtnAdd.Size = new System.Drawing.Size(90, 35);
            this.idBtnAdd.TabIndex = 7;
            this.idBtnAdd.Text = "Add";
            this.idBtnAdd.UseVisualStyleBackColor = true;
            this.idBtnAdd.Click += new System.EventHandler(this.idBtnAdd_Click);
            // 
            // idTxtTransportMode
            // 
            this.idTxtTransportMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtTransportMode.Location = new System.Drawing.Point(34, 34);
            this.idTxtTransportMode.Name = "idTxtTransportMode";
            this.idTxtTransportMode.Size = new System.Drawing.Size(297, 28);
            this.idTxtTransportMode.TabIndex = 6;
            // 
            // idDgvMasterTransportMode
            // 
            this.idDgvMasterTransportMode.AllowUserToAddRows = false;
            this.idDgvMasterTransportMode.AllowUserToDeleteRows = false;
            this.idDgvMasterTransportMode.AllowUserToResizeRows = false;
            this.idDgvMasterTransportMode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.idDgvMasterTransportMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idDgvMasterTransportMode.Location = new System.Drawing.Point(34, 109);
            this.idDgvMasterTransportMode.Name = "idDgvMasterTransportMode";
            this.idDgvMasterTransportMode.RowHeadersVisible = false;
            this.idDgvMasterTransportMode.RowTemplate.Height = 24;
            this.idDgvMasterTransportMode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.idDgvMasterTransportMode.Size = new System.Drawing.Size(297, 303);
            this.idDgvMasterTransportMode.TabIndex = 5;
            // 
            // MastersTransportModes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 447);
            this.Controls.Add(this.idBtnClose);
            this.Controls.Add(this.idBtnDelete);
            this.Controls.Add(this.idBtnAdd);
            this.Controls.Add(this.idTxtTransportMode);
            this.Controls.Add(this.idDgvMasterTransportMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MastersTransportModes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masters - Transport Modes";
            this.Load += new System.EventHandler(this.MastersTransportModes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idDgvMasterTransportMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button idBtnClose;
        private System.Windows.Forms.Button idBtnDelete;
        private System.Windows.Forms.Button idBtnAdd;
        private System.Windows.Forms.TextBox idTxtTransportMode;
        private System.Windows.Forms.DataGridView idDgvMasterTransportMode;
    }
}