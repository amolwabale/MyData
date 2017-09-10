﻿namespace Accounting.Ui.Forms.MainApp
{
    partial class MastersCustomers
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
            this.components = new System.ComponentModel.Container();
            this.idDgvMastersCustomer = new System.Windows.Forms.DataGridView();
            this.idBtnSearch = new System.Windows.Forms.Button();
            this.idTxtSearch = new System.Windows.Forms.TextBox();
            this.idCmbSearchParam = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.idBtnRefresh = new System.Windows.Forms.Button();
            this.idBtnClose = new System.Windows.Forms.Button();
            this.idBtnDelete = new System.Windows.Forms.Button();
            this.idBtnEdit = new System.Windows.Forms.Button();
            this.idBtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idDgvMastersCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // idDgvMastersCustomer
            // 
            this.idDgvMastersCustomer.AllowUserToAddRows = false;
            this.idDgvMastersCustomer.AllowUserToDeleteRows = false;
            this.idDgvMastersCustomer.AllowUserToResizeRows = false;
            this.idDgvMastersCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.idDgvMastersCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idDgvMastersCustomer.Location = new System.Drawing.Point(28, 65);
            this.idDgvMastersCustomer.Name = "idDgvMastersCustomer";
            this.idDgvMastersCustomer.ReadOnly = true;
            this.idDgvMastersCustomer.RowHeadersVisible = false;
            this.idDgvMastersCustomer.RowTemplate.Height = 24;
            this.idDgvMastersCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.idDgvMastersCustomer.Size = new System.Drawing.Size(798, 442);
            this.idDgvMastersCustomer.TabIndex = 11;
            // 
            // idBtnSearch
            // 
            this.idBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnSearch.Location = new System.Drawing.Point(585, 19);
            this.idBtnSearch.Name = "idBtnSearch";
            this.idBtnSearch.Size = new System.Drawing.Size(114, 31);
            this.idBtnSearch.TabIndex = 13;
            this.idBtnSearch.Text = "Search";
            this.idBtnSearch.UseVisualStyleBackColor = true;
            this.idBtnSearch.Click += new System.EventHandler(this.idBtnSearch_Click);
            // 
            // idTxtSearch
            // 
            this.idTxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtSearch.Location = new System.Drawing.Point(278, 20);
            this.idTxtSearch.Name = "idTxtSearch";
            this.idTxtSearch.Size = new System.Drawing.Size(293, 28);
            this.idTxtSearch.TabIndex = 12;
            this.idTxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTxtSearch_KeyPress);
            // 
            // idCmbSearchParam
            // 
            this.idCmbSearchParam.DisplayMember = "dfdf";
            this.idCmbSearchParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCmbSearchParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCmbSearchParam.FormattingEnabled = true;
            this.idCmbSearchParam.Items.AddRange(new object[] {
            "CompanyName",
            "CompanyOwnerName",
            "Address",
            "Contact",
            "GST",
            "CIN",
            "PAN",
            "StateName",
            "StateCode"});
            this.idCmbSearchParam.Location = new System.Drawing.Point(28, 19);
            this.idCmbSearchParam.Name = "idCmbSearchParam";
            this.idCmbSearchParam.Size = new System.Drawing.Size(230, 28);
            this.idCmbSearchParam.TabIndex = 14;
            // 
            // idBtnRefresh
            // 
            this.idBtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnRefresh.Location = new System.Drawing.Point(712, 19);
            this.idBtnRefresh.Name = "idBtnRefresh";
            this.idBtnRefresh.Size = new System.Drawing.Size(114, 31);
            this.idBtnRefresh.TabIndex = 15;
            this.idBtnRefresh.Text = "Refresh";
            this.idBtnRefresh.UseVisualStyleBackColor = true;
            this.idBtnRefresh.Click += new System.EventHandler(this.idBtnRefresh_Click);
            // 
            // idBtnClose
            // 
            this.idBtnClose.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Back1;
            this.idBtnClose.Location = new System.Drawing.Point(855, 397);
            this.idBtnClose.Name = "idBtnClose";
            this.idBtnClose.Size = new System.Drawing.Size(105, 110);
            this.idBtnClose.TabIndex = 10;
            this.idBtnClose.Text = "Close";
            this.idBtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.idBtnClose, "Close / Back");
            this.idBtnClose.UseVisualStyleBackColor = true;
            this.idBtnClose.Click += new System.EventHandler(this.idBtnClose_Click);
            // 
            // idBtnDelete
            // 
            this.idBtnDelete.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Delete1;
            this.idBtnDelete.Location = new System.Drawing.Point(855, 271);
            this.idBtnDelete.Name = "idBtnDelete";
            this.idBtnDelete.Size = new System.Drawing.Size(105, 110);
            this.idBtnDelete.TabIndex = 9;
            this.idBtnDelete.Text = "Delete";
            this.idBtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.idBtnDelete, "Delete Customer");
            this.idBtnDelete.UseVisualStyleBackColor = true;
            this.idBtnDelete.Click += new System.EventHandler(this.idBtnDelete_Click);
            // 
            // idBtnEdit
            // 
            this.idBtnEdit.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Edit2;
            this.idBtnEdit.Location = new System.Drawing.Point(855, 147);
            this.idBtnEdit.Name = "idBtnEdit";
            this.idBtnEdit.Size = new System.Drawing.Size(105, 110);
            this.idBtnEdit.TabIndex = 8;
            this.idBtnEdit.Text = "Edit";
            this.idBtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.idBtnEdit, "Edit Customer");
            this.idBtnEdit.UseVisualStyleBackColor = true;
            this.idBtnEdit.Click += new System.EventHandler(this.idBtnEdit_Click);
            // 
            // idBtnAdd
            // 
            this.idBtnAdd.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.AddCustomer3;
            this.idBtnAdd.Location = new System.Drawing.Point(855, 22);
            this.idBtnAdd.Name = "idBtnAdd";
            this.idBtnAdd.Size = new System.Drawing.Size(105, 110);
            this.idBtnAdd.TabIndex = 7;
            this.idBtnAdd.Text = "Add";
            this.idBtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.idBtnAdd, "Add Customer");
            this.idBtnAdd.UseVisualStyleBackColor = true;
            this.idBtnAdd.Click += new System.EventHandler(this.idBtnAdd_Click);
            // 
            // MastersCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 537);
            this.Controls.Add(this.idBtnRefresh);
            this.Controls.Add(this.idCmbSearchParam);
            this.Controls.Add(this.idBtnSearch);
            this.Controls.Add(this.idTxtSearch);
            this.Controls.Add(this.idDgvMastersCustomer);
            this.Controls.Add(this.idBtnClose);
            this.Controls.Add(this.idBtnDelete);
            this.Controls.Add(this.idBtnEdit);
            this.Controls.Add(this.idBtnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1004, 584);
            this.MinimumSize = new System.Drawing.Size(1004, 584);
            this.Name = "MastersCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master - Customer";
            this.Load += new System.EventHandler(this.MastersCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idDgvMastersCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button idBtnClose;
        private System.Windows.Forms.Button idBtnDelete;
        private System.Windows.Forms.Button idBtnEdit;
        private System.Windows.Forms.Button idBtnAdd;
        private System.Windows.Forms.DataGridView idDgvMastersCustomer;
        private System.Windows.Forms.Button idBtnSearch;
        private System.Windows.Forms.TextBox idTxtSearch;
        private System.Windows.Forms.ComboBox idCmbSearchParam;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button idBtnRefresh;
    }
}