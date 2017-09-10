using Accounting.Bl;
using Accounting.Dl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounting.Ui.Forms.MainApp
{
    public partial class MastersCompany : Form
    {
        CompanyInfo GlobalObjCompanyInfo;
        string AppLogoPath = "";
        public MastersCompany()
        {
            InitializeComponent();
        }

        private void MastersCompany_Load(object sender, EventArgs e)
        {
            GlobalObjCompanyInfo = MastersBl.GetCompanyInfo();
            SetCompanyInfoToTextBox();
            SetViewMode();

        }

        public void SetViewMode()
        {
            DisableAllTextBox();
            idBtnEdit.Enabled = true;
            idBtnBack.Enabled = true;
            idRtbAddress.Enabled = false;
            idBtnSave.Enabled = false;
            idBtnCancel.Enabled = false;
            idBtnBrowse.Enabled = false;

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

        private void idBtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idBtnEdit_Click(object sender, EventArgs e)
        {
            SetEditMode();
        }

        public void SetEditMode()
        {
            EnableAllTextBox();
            idBtnEdit.Enabled = false;
            idBtnBack.Enabled = false;
            idRtbAddress.Enabled = true;
            idBtnSave.Enabled = true;
            idBtnCancel.Enabled = true;
            idBtnBrowse.Enabled = true;
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

        public void GetCompanyInfoFromTextBox()
        {

            GlobalObjCompanyInfo.CompanyName = idTxtCompanyName.Text;
            GlobalObjCompanyInfo.CompanyOwnerName = idTxtCompanyOwnerName.Text;
            GlobalObjCompanyInfo.Address = idRtbAddress.Text;
            GlobalObjCompanyInfo.Contact = idTxtContact.Text;
            GlobalObjCompanyInfo.Gst = idTxtGst.Text;
            GlobalObjCompanyInfo.Cin = idTxtCin.Text;
            GlobalObjCompanyInfo.Pan = IdTxtPan.Text;
            GlobalObjCompanyInfo.StateName = idTxtStateName.Text;
            GlobalObjCompanyInfo.StateCode = idTxtSateCode.Text;
            GlobalObjCompanyInfo.BankName = idTxtBankName.Text;
            GlobalObjCompanyInfo.BankAccountNumber = idTxtBankAccNumber.Text;
            GlobalObjCompanyInfo.BankIfscNumber = idTxtBankIfscCode.Text;
            GlobalObjCompanyInfo.CompanyLogo = AppLogoPath;
        }

        public void SetCompanyInfoToTextBox()
        {
            idTxtCompanyName.Text = GlobalObjCompanyInfo.CompanyName;
            idTxtCompanyOwnerName.Text = GlobalObjCompanyInfo.CompanyOwnerName;
            idRtbAddress.Text = GlobalObjCompanyInfo.Address;
            idTxtContact.Text = GlobalObjCompanyInfo.Contact;
            idTxtGst.Text = GlobalObjCompanyInfo.Gst;
            idTxtCin.Text = GlobalObjCompanyInfo.Cin;
            IdTxtPan.Text = GlobalObjCompanyInfo.Pan;
            idTxtStateName.Text = GlobalObjCompanyInfo.StateName;
            idTxtSateCode.Text = GlobalObjCompanyInfo.StateCode;
            idTxtBankName.Text = GlobalObjCompanyInfo.BankName;
            idTxtBankAccNumber.Text = GlobalObjCompanyInfo.BankAccountNumber;
            idTxtBankIfscCode.Text = GlobalObjCompanyInfo.BankIfscNumber;

            if (!string.IsNullOrEmpty(GlobalObjCompanyInfo.CompanyLogo))
                InitPictureBox(GlobalObjCompanyInfo.CompanyLogo);
        }

        private void idBtnSave_Click(object sender, EventArgs e)
        {
            GetCompanyInfoFromTextBox();
            var ErrorCounter = 0;
            var ErrorMessage = "Following fields should not be empty \n\n";
            if (string.IsNullOrEmpty(GlobalObjCompanyInfo.CompanyName))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter Company Name \n";
            }

            if (string.IsNullOrEmpty(GlobalObjCompanyInfo.Address))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter Company Address \n";
            }

            if (string.IsNullOrEmpty(GlobalObjCompanyInfo.Contact))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter Contact \n";
            }

            if (string.IsNullOrEmpty(GlobalObjCompanyInfo.StateName))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter State Name \n";
            }
            if (ErrorCounter > 0)
            {
                MessageBox.Show(ErrorMessage, "Warning !...");
                return;
            }
            if (GlobalObjCompanyInfo.Id == "0")
                MastersBl.SaveCompanyInfo(GlobalObjCompanyInfo);
            else
                MastersBl.UpdateCompanyInfo(GlobalObjCompanyInfo);
            SetViewMode();
            GlobalObjCompanyInfo = MastersBl.GetCompanyInfo();

        }

        private void idBtnCancel_Click(object sender, EventArgs e)
        {
            GlobalObjCompanyInfo = MastersBl.GetCompanyInfo();
            SetCompanyInfoToTextBox();
            SetViewMode();
        }

        private void idBtnBrowse_Click(object sender, EventArgs e)
        {
            if (idPbCompanyLogo.BackgroundImage != null)
            {
                idPbCompanyLogo.BackgroundImage.Dispose();
                idPbCompanyLogo.BackgroundImage = null;
            }
            string LogoPath = "";
            OpenFileDialog directchoosedlg = new OpenFileDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                LogoPath = directchoosedlg.FileName;
            }
            string ext = Path.GetExtension(LogoPath);
            AppLogoPath = Environment.CurrentDirectory + @"\App_Data\CompanyLogo" + ext;
            File.Copy(LogoPath, AppLogoPath, true);

            InitPictureBox(AppLogoPath);

        }

        public void InitPictureBox(string Path)
        {
            Image img = Image.FromFile(Path);
            idPbCompanyLogo.BackgroundImage = img;
            idPbCompanyLogo.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
