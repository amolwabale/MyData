namespace Accounting.Ui.Forms.MainApp
{
    partial class Invoice
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
            this.idDpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idCmbBilledTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idCmbShippedTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idTxtOtherCharges = new System.Windows.Forms.TextBox();
            this.idDgvInvoice = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.idCmbAddItem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idTxtQty = new System.Windows.Forms.TextBox();
            this.idBtnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.idCmbTransportMode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.idCmbVehicleNum = new System.Windows.Forms.ComboBox();
            this.idTxtPoNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.idDpPoDate = new System.Windows.Forms.DateTimePicker();
            this.idBtnRemoveItem = new System.Windows.Forms.Button();
            this.idBtnPrintPreview = new System.Windows.Forms.Button();
            this.idBtnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idDgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // idDpInvoiceDate
            // 
            this.idDpInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDpInvoiceDate.Location = new System.Drawing.Point(48, 68);
            this.idDpInvoiceDate.Name = "idDpInvoiceDate";
            this.idDpInvoiceDate.Size = new System.Drawing.Size(311, 24);
            this.idDpInvoiceDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Billed to Customer";
            // 
            // idCmbBilledTo
            // 
            this.idCmbBilledTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCmbBilledTo.FormattingEnabled = true;
            this.idCmbBilledTo.Location = new System.Drawing.Point(48, 134);
            this.idCmbBilledTo.Name = "idCmbBilledTo";
            this.idCmbBilledTo.Size = new System.Drawing.Size(311, 26);
            this.idCmbBilledTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shipped To";
            // 
            // idCmbShippedTo
            // 
            this.idCmbShippedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCmbShippedTo.FormattingEnabled = true;
            this.idCmbShippedTo.Location = new System.Drawing.Point(48, 204);
            this.idCmbShippedTo.Name = "idCmbShippedTo";
            this.idCmbShippedTo.Size = new System.Drawing.Size(311, 26);
            this.idCmbShippedTo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Discount ( Rs )";
            // 
            // idTxtDiscount
            // 
            this.idTxtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtDiscount.Location = new System.Drawing.Point(48, 274);
            this.idTxtDiscount.Name = "idTxtDiscount";
            this.idTxtDiscount.Size = new System.Drawing.Size(311, 24);
            this.idTxtDiscount.TabIndex = 7;
            this.idTxtDiscount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Other Charges ( Rs )";
            // 
            // idTxtOtherCharges
            // 
            this.idTxtOtherCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtOtherCharges.Location = new System.Drawing.Point(48, 334);
            this.idTxtOtherCharges.Name = "idTxtOtherCharges";
            this.idTxtOtherCharges.Size = new System.Drawing.Size(311, 24);
            this.idTxtOtherCharges.TabIndex = 9;
            this.idTxtOtherCharges.Text = "0";
            // 
            // idDgvInvoice
            // 
            this.idDgvInvoice.AllowUserToAddRows = false;
            this.idDgvInvoice.AllowUserToDeleteRows = false;
            this.idDgvInvoice.AllowUserToResizeRows = false;
            this.idDgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.idDgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idDgvInvoice.Location = new System.Drawing.Point(410, 110);
            this.idDgvInvoice.Name = "idDgvInvoice";
            this.idDgvInvoice.ReadOnly = true;
            this.idDgvInvoice.RowHeadersVisible = false;
            this.idDgvInvoice.RowTemplate.Height = 24;
            this.idDgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.idDgvInvoice.Size = new System.Drawing.Size(674, 439);
            this.idDgvInvoice.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Add Item";
            // 
            // idCmbAddItem
            // 
            this.idCmbAddItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.idCmbAddItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.idCmbAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCmbAddItem.FormattingEnabled = true;
            this.idCmbAddItem.Location = new System.Drawing.Point(410, 69);
            this.idCmbAddItem.Name = "idCmbAddItem";
            this.idCmbAddItem.Size = new System.Drawing.Size(362, 26);
            this.idCmbAddItem.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(788, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Qty";
            // 
            // idTxtQty
            // 
            this.idTxtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtQty.Location = new System.Drawing.Point(792, 68);
            this.idTxtQty.Name = "idTxtQty";
            this.idTxtQty.Size = new System.Drawing.Size(167, 27);
            this.idTxtQty.TabIndex = 16;
            // 
            // idBtnAdd
            // 
            this.idBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnAdd.Location = new System.Drawing.Point(979, 66);
            this.idBtnAdd.Name = "idBtnAdd";
            this.idBtnAdd.Size = new System.Drawing.Size(105, 30);
            this.idBtnAdd.TabIndex = 17;
            this.idBtnAdd.Text = "Add";
            this.idBtnAdd.UseVisualStyleBackColor = true;
            this.idBtnAdd.Click += new System.EventHandler(this.idBtnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Transport Mode";
            // 
            // idCmbTransportMode
            // 
            this.idCmbTransportMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCmbTransportMode.FormattingEnabled = true;
            this.idCmbTransportMode.Location = new System.Drawing.Point(48, 396);
            this.idCmbTransportMode.Name = "idCmbTransportMode";
            this.idCmbTransportMode.Size = new System.Drawing.Size(311, 26);
            this.idCmbTransportMode.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Vehicle No";
            // 
            // idCmbVehicleNum
            // 
            this.idCmbVehicleNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCmbVehicleNum.FormattingEnabled = true;
            this.idCmbVehicleNum.Location = new System.Drawing.Point(48, 460);
            this.idCmbVehicleNum.Name = "idCmbVehicleNum";
            this.idCmbVehicleNum.Size = new System.Drawing.Size(311, 26);
            this.idCmbVehicleNum.TabIndex = 21;
            // 
            // idTxtPoNo
            // 
            this.idTxtPoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtPoNo.Location = new System.Drawing.Point(48, 522);
            this.idTxtPoNo.Name = "idTxtPoNo";
            this.idTxtPoNo.Size = new System.Drawing.Size(311, 27);
            this.idTxtPoNo.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "PO. No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "PO Date";
            // 
            // idDpPoDate
            // 
            this.idDpPoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDpPoDate.Location = new System.Drawing.Point(48, 587);
            this.idDpPoDate.Name = "idDpPoDate";
            this.idDpPoDate.Size = new System.Drawing.Size(311, 24);
            this.idDpPoDate.TabIndex = 24;
            // 
            // idBtnRemoveItem
            // 
            this.idBtnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnRemoveItem.Location = new System.Drawing.Point(410, 572);
            this.idBtnRemoveItem.Name = "idBtnRemoveItem";
            this.idBtnRemoveItem.Size = new System.Drawing.Size(125, 39);
            this.idBtnRemoveItem.TabIndex = 26;
            this.idBtnRemoveItem.Text = "Remove Item";
            this.idBtnRemoveItem.UseVisualStyleBackColor = true;
            this.idBtnRemoveItem.Click += new System.EventHandler(this.idBtnRemoveItem_Click);
            // 
            // idBtnPrintPreview
            // 
            this.idBtnPrintPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnPrintPreview.Location = new System.Drawing.Point(561, 572);
            this.idBtnPrintPreview.Name = "idBtnPrintPreview";
            this.idBtnPrintPreview.Size = new System.Drawing.Size(179, 39);
            this.idBtnPrintPreview.TabIndex = 27;
            this.idBtnPrintPreview.Text = "Preview / Print Invoice";
            this.idBtnPrintPreview.UseVisualStyleBackColor = true;
            this.idBtnPrintPreview.Click += new System.EventHandler(this.button2_Click);
            // 
            // idBtnSave
            // 
            this.idBtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtnSave.Location = new System.Drawing.Point(765, 572);
            this.idBtnSave.Name = "idBtnSave";
            this.idBtnSave.Size = new System.Drawing.Size(125, 39);
            this.idBtnSave.TabIndex = 28;
            this.idBtnSave.Text = "Save Invoice";
            this.idBtnSave.UseVisualStyleBackColor = true;
            this.idBtnSave.Click += new System.EventHandler(this.idBtnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(198, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 29);
            this.label12.TabIndex = 44;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(188, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 29);
            this.label13.TabIndex = 45;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(123, 497);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 29);
            this.label14.TabIndex = 46;
            this.label14.Text = "*";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 654);
            this.Controls.Add(this.idBtnSave);
            this.Controls.Add(this.idBtnPrintPreview);
            this.Controls.Add(this.idBtnRemoveItem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.idDpPoDate);
            this.Controls.Add(this.idTxtPoNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.idCmbVehicleNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idCmbTransportMode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idBtnAdd);
            this.Controls.Add(this.idTxtQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idCmbAddItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idDgvInvoice);
            this.Controls.Add(this.idTxtOtherCharges);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idTxtDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idCmbShippedTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idCmbBilledTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idDpInvoiceDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idDgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker idDpInvoiceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox idCmbBilledTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox idCmbShippedTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTxtOtherCharges;
        private System.Windows.Forms.DataGridView idDgvInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox idCmbAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idTxtQty;
        private System.Windows.Forms.Button idBtnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox idCmbTransportMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox idCmbVehicleNum;
        private System.Windows.Forms.TextBox idTxtPoNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker idDpPoDate;
        private System.Windows.Forms.Button idBtnRemoveItem;
        private System.Windows.Forms.Button idBtnPrintPreview;
        private System.Windows.Forms.Button idBtnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}