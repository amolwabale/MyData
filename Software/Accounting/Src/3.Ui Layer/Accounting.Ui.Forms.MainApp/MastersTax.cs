using Accounting.Bl;
using Accounting.Dl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounting.Ui.Forms.MainApp
{
    public partial class MastersTax : Form
    {
        TaxInfo GlobalObjTaxInfo;
        public MastersTax()
        {
            InitializeComponent();
        }

        private void MastersTax_Load(object sender, EventArgs e)
        {
            SetModeView();
            GlobalObjTaxInfo = MastersBl.GetTaxInfo();
            SetValueToTextBox();
        }

        public void SetValueToTextBox()
        {
            idTxtSgst.Text = GlobalObjTaxInfo.SGST;
            idTxtCgst.Text = GlobalObjTaxInfo.CGST;
            idTxtIgst.Text = GlobalObjTaxInfo.IGST;
        }

        public void GetValueFromTextBox()
        {
            GlobalObjTaxInfo.SGST = idTxtSgst.Text;
            GlobalObjTaxInfo.CGST = idTxtCgst.Text;
            GlobalObjTaxInfo.IGST = idTxtIgst.Text;
        }

        public void SetModeView()
        {
            DisableAllTextBox();
            idBtnEdit.Enabled = true;
            idBtnSave.Enabled = false;
            idBtnCancel.Enabled = false;
            idBtnBack.Enabled = true;
        }

        public void DisableAllTextBox()
        {
            foreach (Control cont in this.Controls)
            {
                if (cont is TextBox)
                {
                    ((TextBox)cont).Enabled = false;
                }
            }
        }

        public void SetModeEdit()
        {
            EnableAllTextBox();
            idBtnEdit.Enabled = false;
            idBtnSave.Enabled = true;
            idBtnCancel.Enabled = true;
            idBtnBack.Enabled = false;
        }

        public void EnableAllTextBox()
        {
            foreach (Control cont in this.Controls)
            {
                if (cont is TextBox)
                {
                    ((TextBox)cont).Enabled = true;
                }
            }
        }

        private void idBtnEdit_Click(object sender, EventArgs e)
        {
            SetModeEdit();
        }

        private void idBtnSave_Click(object sender, EventArgs e)
        {
            GetValueFromTextBox();
            var ErrorCounter = 0;
            var ErrorMessage = "Following fields should not be empty \n\n";
            if (string.IsNullOrEmpty(GlobalObjTaxInfo.SGST))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter 0 if not SGST applicable \n";
            }
            if (string.IsNullOrEmpty(GlobalObjTaxInfo.CGST))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter 0 if not CGST applicable \n";
            }
            if (string.IsNullOrEmpty(GlobalObjTaxInfo.IGST))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter 0 if not IGST applicable \n";
            }
            if (!string.IsNullOrEmpty(GlobalObjTaxInfo.SGST))
            {
                float temp = 0;
                var str = GlobalObjTaxInfo.SGST.ToString();
                var fValue = float.TryParse(str, out temp);
                if (fValue == false)
                {
                    ErrorCounter++;
                    ErrorMessage += ErrorCounter.ToString() + "] " + "SGST should be numeric value. \n";
                }
            }
            if (!string.IsNullOrEmpty(GlobalObjTaxInfo.CGST))
            {
                float temp = 0;
                var str = GlobalObjTaxInfo.CGST.ToString();
                var fValue = float.TryParse(str, out temp);
                if (fValue == false)
                {
                    ErrorCounter++;
                    ErrorMessage += ErrorCounter.ToString() + "] " + "CGST should be numeric value. \n";
                }
            }
            if (!string.IsNullOrEmpty(GlobalObjTaxInfo.IGST))
            {
                float temp = 0;
                var str = GlobalObjTaxInfo.IGST.ToString();
                var fValue = float.TryParse(str, out temp);
                if (fValue == false)
                {
                    ErrorCounter++;
                    ErrorMessage += ErrorCounter.ToString() + "] " + "IGST should be numeric value. \n";
                }
            }
            if (ErrorCounter > 0)
            {
                MessageBox.Show(ErrorMessage, "Warning !...");
                return;
            }

            if (GlobalObjTaxInfo.ID == "0")
                MastersBl.SaveTaxInfo(GlobalObjTaxInfo);
            else
                MastersBl.UpdateTaxInfo(GlobalObjTaxInfo);

            GlobalObjTaxInfo = MastersBl.GetTaxInfo();
            SetModeView();
        }

        private void idBtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idBtnCancel_Click(object sender, EventArgs e)
        {
            SetValueToTextBox();
            SetModeView();
        }

    }
}
