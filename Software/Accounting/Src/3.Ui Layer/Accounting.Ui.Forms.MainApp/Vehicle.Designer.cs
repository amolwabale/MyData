namespace Accounting.Ui.Forms.MainApp
{
    partial class Vehicle
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
            this.idTxtContactNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idTxtDriverName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idTxtVehicleBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtVehicleNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idBtnCancel = new System.Windows.Forms.Button();
            this.idBtnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idTxtContactNumber
            // 
            this.idTxtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtContactNumber.Location = new System.Drawing.Point(51, 269);
            this.idTxtContactNumber.Name = "idTxtContactNumber";
            this.idTxtContactNumber.Size = new System.Drawing.Size(331, 24);
            this.idTxtContactNumber.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contact Number";
            // 
            // idTxtDriverName
            // 
            this.idTxtDriverName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtDriverName.Location = new System.Drawing.Point(51, 198);
            this.idTxtDriverName.Name = "idTxtDriverName";
            this.idTxtDriverName.Size = new System.Drawing.Size(331, 24);
            this.idTxtDriverName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Driver Name";
            // 
            // idTxtVehicleBrand
            // 
            this.idTxtVehicleBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtVehicleBrand.Location = new System.Drawing.Point(51, 130);
            this.idTxtVehicleBrand.Name = "idTxtVehicleBrand";
            this.idTxtVehicleBrand.Size = new System.Drawing.Size(331, 24);
            this.idTxtVehicleBrand.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vehicle Brand / Type";
            // 
            // idTxtVehicleNumber
            // 
            this.idTxtVehicleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtVehicleNumber.Location = new System.Drawing.Point(51, 63);
            this.idTxtVehicleNumber.Name = "idTxtVehicleNumber";
            this.idTxtVehicleNumber.Size = new System.Drawing.Size(331, 24);
            this.idTxtVehicleNumber.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vehicle Number";
            // 
            // idBtnCancel
            // 
            this.idBtnCancel.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.back32;
            this.idBtnCancel.Location = new System.Drawing.Point(404, 39);
            this.idBtnCancel.Name = "idBtnCancel";
            this.idBtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idBtnCancel.Size = new System.Drawing.Size(81, 115);
            this.idBtnCancel.TabIndex = 41;
            this.idBtnCancel.Text = "Back";
            this.idBtnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idBtnCancel.UseVisualStyleBackColor = true;
            this.idBtnCancel.Click += new System.EventHandler(this.idBtnCancel_Click);
            // 
            // idBtnSave
            // 
            this.idBtnSave.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.save32;
            this.idBtnSave.Location = new System.Drawing.Point(404, 174);
            this.idBtnSave.Name = "idBtnSave";
            this.idBtnSave.Size = new System.Drawing.Size(81, 119);
            this.idBtnSave.TabIndex = 40;
            this.idBtnSave.Text = "Save";
            this.idBtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idBtnSave.UseVisualStyleBackColor = true;
            this.idBtnSave.Click += new System.EventHandler(this.idBtnSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(181, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 29);
            this.label10.TabIndex = 42;
            this.label10.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(227, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "*";
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 328);
            this.Controls.Add(this.idBtnCancel);
            this.Controls.Add(this.idBtnSave);
            this.Controls.Add(this.idTxtContactNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTxtDriverName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTxtVehicleBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTxtVehicleNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vehicle_FormClosing);
            this.Load += new System.EventHandler(this.Vehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxtContactNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTxtDriverName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTxtVehicleBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtVehicleNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button idBtnCancel;
        private System.Windows.Forms.Button idBtnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
    }
}