namespace Accounting.Ui.Forms.MainApp
{
    partial class MastersVehicle
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
            this.idBtnRefresh = new System.Windows.Forms.Button();
            this.idCmbSearchParam = new System.Windows.Forms.ComboBox();
            this.idBtnSearch = new System.Windows.Forms.Button();
            this.idTxtSearch = new System.Windows.Forms.TextBox();
            this.idBtnClose = new System.Windows.Forms.Button();
            this.idBtnDelete = new System.Windows.Forms.Button();
            this.idBtnEdit = new System.Windows.Forms.Button();
            this.idBtnAdd = new System.Windows.Forms.Button();
            this.idDgvMastersVehicle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.idDgvMastersVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // idBtnRefresh
            // 
            this.idBtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnRefresh.Location = new System.Drawing.Point(713, 23);
            this.idBtnRefresh.Name = "idBtnRefresh";
            this.idBtnRefresh.Size = new System.Drawing.Size(114, 31);
            this.idBtnRefresh.TabIndex = 28;
            this.idBtnRefresh.Text = "Refresh";
            this.idBtnRefresh.UseVisualStyleBackColor = true;
            this.idBtnRefresh.Click += new System.EventHandler(this.idBtnRefresh_Click);
            // 
            // idCmbSearchParam
            // 
            this.idCmbSearchParam.DisplayMember = "dfdf";
            this.idCmbSearchParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCmbSearchParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCmbSearchParam.FormattingEnabled = true;
            this.idCmbSearchParam.Items.AddRange(new object[] {
            "VehicleNum",
            "VehicleBrand",
            "DriverName",
            "ContactNum"});
            this.idCmbSearchParam.Location = new System.Drawing.Point(29, 23);
            this.idCmbSearchParam.Name = "idCmbSearchParam";
            this.idCmbSearchParam.Size = new System.Drawing.Size(230, 28);
            this.idCmbSearchParam.TabIndex = 27;
            // 
            // idBtnSearch
            // 
            this.idBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnSearch.Location = new System.Drawing.Point(586, 23);
            this.idBtnSearch.Name = "idBtnSearch";
            this.idBtnSearch.Size = new System.Drawing.Size(114, 31);
            this.idBtnSearch.TabIndex = 26;
            this.idBtnSearch.Text = "Search";
            this.idBtnSearch.UseVisualStyleBackColor = true;
            this.idBtnSearch.Click += new System.EventHandler(this.idBtnSearch_Click);
            // 
            // idTxtSearch
            // 
            this.idTxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtSearch.Location = new System.Drawing.Point(279, 24);
            this.idTxtSearch.Name = "idTxtSearch";
            this.idTxtSearch.Size = new System.Drawing.Size(293, 28);
            this.idTxtSearch.TabIndex = 25;
            // 
            // idBtnClose
            // 
            this.idBtnClose.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Back1;
            this.idBtnClose.Location = new System.Drawing.Point(849, 399);
            this.idBtnClose.Name = "idBtnClose";
            this.idBtnClose.Size = new System.Drawing.Size(105, 110);
            this.idBtnClose.TabIndex = 24;
            this.idBtnClose.Text = "Close";
            this.idBtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idBtnClose.UseVisualStyleBackColor = true;
            this.idBtnClose.Click += new System.EventHandler(this.idBtnClose_Click);
            // 
            // idBtnDelete
            // 
            this.idBtnDelete.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Delete1;
            this.idBtnDelete.Location = new System.Drawing.Point(849, 273);
            this.idBtnDelete.Name = "idBtnDelete";
            this.idBtnDelete.Size = new System.Drawing.Size(105, 110);
            this.idBtnDelete.TabIndex = 23;
            this.idBtnDelete.Text = "Delete";
            this.idBtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idBtnDelete.UseVisualStyleBackColor = true;
            this.idBtnDelete.Click += new System.EventHandler(this.idBtnDelete_Click);
            // 
            // idBtnEdit
            // 
            this.idBtnEdit.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Edit2;
            this.idBtnEdit.Location = new System.Drawing.Point(849, 149);
            this.idBtnEdit.Name = "idBtnEdit";
            this.idBtnEdit.Size = new System.Drawing.Size(105, 110);
            this.idBtnEdit.TabIndex = 22;
            this.idBtnEdit.Text = "Edit";
            this.idBtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idBtnEdit.UseVisualStyleBackColor = true;
            this.idBtnEdit.Click += new System.EventHandler(this.idBtnEdit_Click);
            // 
            // idBtnAdd
            // 
            this.idBtnAdd.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.AddCustomer3;
            this.idBtnAdd.Location = new System.Drawing.Point(849, 24);
            this.idBtnAdd.Name = "idBtnAdd";
            this.idBtnAdd.Size = new System.Drawing.Size(105, 110);
            this.idBtnAdd.TabIndex = 21;
            this.idBtnAdd.Text = "Add";
            this.idBtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idBtnAdd.UseVisualStyleBackColor = true;
            this.idBtnAdd.Click += new System.EventHandler(this.idBtnAdd_Click);
            // 
            // idDgvMastersVehicle
            // 
            this.idDgvMastersVehicle.AllowUserToAddRows = false;
            this.idDgvMastersVehicle.AllowUserToDeleteRows = false;
            this.idDgvMastersVehicle.AllowUserToResizeRows = false;
            this.idDgvMastersVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.idDgvMastersVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idDgvMastersVehicle.Location = new System.Drawing.Point(30, 67);
            this.idDgvMastersVehicle.Name = "idDgvMastersVehicle";
            this.idDgvMastersVehicle.ReadOnly = true;
            this.idDgvMastersVehicle.RowHeadersVisible = false;
            this.idDgvMastersVehicle.RowTemplate.Height = 24;
            this.idDgvMastersVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.idDgvMastersVehicle.Size = new System.Drawing.Size(798, 442);
            this.idDgvMastersVehicle.TabIndex = 20;
            // 
            // MastersVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 533);
            this.Controls.Add(this.idBtnRefresh);
            this.Controls.Add(this.idCmbSearchParam);
            this.Controls.Add(this.idBtnSearch);
            this.Controls.Add(this.idTxtSearch);
            this.Controls.Add(this.idBtnClose);
            this.Controls.Add(this.idBtnDelete);
            this.Controls.Add(this.idBtnEdit);
            this.Controls.Add(this.idBtnAdd);
            this.Controls.Add(this.idDgvMastersVehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MastersVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masters - Vehicle";
            this.Load += new System.EventHandler(this.MastersVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idDgvMastersVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button idBtnRefresh;
        private System.Windows.Forms.ComboBox idCmbSearchParam;
        private System.Windows.Forms.Button idBtnSearch;
        private System.Windows.Forms.TextBox idTxtSearch;
        private System.Windows.Forms.Button idBtnClose;
        private System.Windows.Forms.Button idBtnDelete;
        private System.Windows.Forms.Button idBtnEdit;
        private System.Windows.Forms.Button idBtnAdd;
        private System.Windows.Forms.DataGridView idDgvMastersVehicle;


    }
}