namespace Accounting.Ui.Forms.MainApp
{
    partial class MastersTax
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTxtSgst = new System.Windows.Forms.TextBox();
            this.idTxtCgst = new System.Windows.Forms.TextBox();
            this.idTxtIgst = new System.Windows.Forms.TextBox();
            this.idBtnBack = new System.Windows.Forms.Button();
            this.idBtnCancel = new System.Windows.Forms.Button();
            this.idBtnSave = new System.Windows.Forms.Button();
            this.idBtnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SGST ( % )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CGST ( % )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "IGST ( % )";
            // 
            // idTxtSgst
            // 
            this.idTxtSgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtSgst.Location = new System.Drawing.Point(45, 58);
            this.idTxtSgst.Name = "idTxtSgst";
            this.idTxtSgst.Size = new System.Drawing.Size(487, 28);
            this.idTxtSgst.TabIndex = 3;
            // 
            // idTxtCgst
            // 
            this.idTxtCgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtCgst.Location = new System.Drawing.Point(45, 133);
            this.idTxtCgst.Name = "idTxtCgst";
            this.idTxtCgst.Size = new System.Drawing.Size(487, 28);
            this.idTxtCgst.TabIndex = 4;
            // 
            // idTxtIgst
            // 
            this.idTxtIgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtIgst.Location = new System.Drawing.Point(45, 206);
            this.idTxtIgst.Name = "idTxtIgst";
            this.idTxtIgst.Size = new System.Drawing.Size(487, 28);
            this.idTxtIgst.TabIndex = 5;
            // 
            // idBtnBack
            // 
            this.idBtnBack.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Back1;
            this.idBtnBack.Location = new System.Drawing.Point(432, 261);
            this.idBtnBack.Name = "idBtnBack";
            this.idBtnBack.Size = new System.Drawing.Size(100, 100);
            this.idBtnBack.TabIndex = 40;
            this.idBtnBack.Text = "Back";
            this.idBtnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idBtnBack.UseVisualStyleBackColor = true;
            this.idBtnBack.Click += new System.EventHandler(this.idBtnBack_Click);
            // 
            // idBtnCancel
            // 
            this.idBtnCancel.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Cancel;
            this.idBtnCancel.Location = new System.Drawing.Point(307, 261);
            this.idBtnCancel.Name = "idBtnCancel";
            this.idBtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idBtnCancel.Size = new System.Drawing.Size(100, 100);
            this.idBtnCancel.TabIndex = 39;
            this.idBtnCancel.Text = "Cancel";
            this.idBtnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idBtnCancel.UseVisualStyleBackColor = true;
            this.idBtnCancel.Click += new System.EventHandler(this.idBtnCancel_Click);
            // 
            // idBtnSave
            // 
            this.idBtnSave.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Save;
            this.idBtnSave.Location = new System.Drawing.Point(172, 261);
            this.idBtnSave.Name = "idBtnSave";
            this.idBtnSave.Size = new System.Drawing.Size(100, 100);
            this.idBtnSave.TabIndex = 38;
            this.idBtnSave.Text = "Save";
            this.idBtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idBtnSave.UseVisualStyleBackColor = true;
            this.idBtnSave.Click += new System.EventHandler(this.idBtnSave_Click);
            // 
            // idBtnEdit
            // 
            this.idBtnEdit.Image = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Edit2;
            this.idBtnEdit.Location = new System.Drawing.Point(45, 261);
            this.idBtnEdit.Name = "idBtnEdit";
            this.idBtnEdit.Size = new System.Drawing.Size(100, 100);
            this.idBtnEdit.TabIndex = 37;
            this.idBtnEdit.Text = "Edit";
            this.idBtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.idBtnEdit.UseVisualStyleBackColor = true;
            this.idBtnEdit.Click += new System.EventHandler(this.idBtnEdit_Click);
            // 
            // MastersTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 397);
            this.Controls.Add(this.idBtnBack);
            this.Controls.Add(this.idBtnCancel);
            this.Controls.Add(this.idBtnSave);
            this.Controls.Add(this.idBtnEdit);
            this.Controls.Add(this.idTxtIgst);
            this.Controls.Add(this.idTxtCgst);
            this.Controls.Add(this.idTxtSgst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(593, 448);
            this.MaximumSize = new System.Drawing.Size(593, 448);
            this.Name = "MastersTax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masters Tax";
            this.Load += new System.EventHandler(this.MastersTax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTxtSgst;
        private System.Windows.Forms.TextBox idTxtCgst;
        private System.Windows.Forms.TextBox idTxtIgst;
        private System.Windows.Forms.Button idBtnBack;
        private System.Windows.Forms.Button idBtnCancel;
        private System.Windows.Forms.Button idBtnSave;
        private System.Windows.Forms.Button idBtnEdit;
    }
}