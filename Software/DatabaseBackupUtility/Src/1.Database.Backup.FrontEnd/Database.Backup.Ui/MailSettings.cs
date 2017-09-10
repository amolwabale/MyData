using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using log4net;
using System.IO;
using Database.Backup.Core;

namespace Database.Backup.Ui
{
    public partial class MailSettings : Form
    {
        ILog log = Helper.Log;
        BackgroundWorker SendMailWorker = new BackgroundWorker();

        public delegate void EnableButton();
        public event EnableButton EnableMailSettingsButtons;

        public MailSettings()
        {
            InitializeComponent();
        }

        public void ImageVisibility(bool status)
        {
            setState(idPicLoading, status);
            setState_Label(idLabelProcessing, status);
        }


        public delegate void setCheckboxStateCallback(PictureBox pb, bool state);

        public void setState(PictureBox pb, bool state)
        {
            if (pb.InvokeRequired)
            {
                setCheckboxStateCallback delSetState = new setCheckboxStateCallback(setState);
                this.Invoke(delSetState, new object[] { pb, state });
            }
            else
            {
                pb.Visible = state;
            }
        }

        public delegate void setLabelStateCallback(Label lb, bool state);

        public void setState_Label(Label lb, bool state)
        {
            if (lb.InvokeRequired)
            {
                setLabelStateCallback delSetState = new setLabelStateCallback(setState_Label);
                this.Invoke(delSetState, new object[] { lb, state });
            }
            else
            {
                lb.Visible = state;
            }
        }

        public delegate void setLabelTextStateCallback(string state);

        public void ProcessingStatus(string state)
        {
            if (idLabelProcessing.InvokeRequired)
            {
                setLabelTextStateCallback delSetState = new setLabelTextStateCallback(ProcessingStatus);
                this.Invoke(delSetState, new object[] { state });
            }
            else
            {
                idLabelProcessing.Text = state;
            }
        }

        private void MailSettings_Load(object sender, EventArgs e)
        {
            ImageVisibility(false);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            LoadMailSettings();
            log.Info("Mail settings form opened");
            SendMailWorker.DoWork += new DoWorkEventHandler(SendMailWorker_DoWork);
            SendMailWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SendMailWorker_RunWorkerCompleted);
        }

        

       

        private void idBtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidateMailForm()
        {
            string ErrorMessage = "";
            bool IsValid = false;

            if (idListReceipient.Items.Count == 0)
            {
                ErrorMessage += "Atleast one receipient.\n";
            }

            if (idTxtMailFrom.Text.Trim() == "")
            {
                ErrorMessage += "Mail from.\n";
            }

            if (idTxtHost.Text.Trim() == "")
            {
                ErrorMessage += "Host.\n";
            }

            if (idTxtPort.Text.Trim() == "")
            {
                ErrorMessage += "Port.\n";
            }

            if (idCmbEnableSsl.Text.Trim() == "")
            {
                ErrorMessage += "Enable Ssl.\n";
            }

            try
            {
                int port = int.Parse(idTxtPort.Text.Trim());
            }
            catch (Exception)
            {
                ErrorMessage += "Port numer should only have numeric value.";
            }

            if (ErrorMessage != "")
            {
                ErrorMessage = "Following fields are required : \n" + ErrorMessage;
                MessageBox.Show(ErrorMessage, ErrorMessage);
                IsValid = false;
            }
            else
                IsValid = true;
            return IsValid;
        }

        public static bool IsEmailValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void idBtnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {

           
            var Isvalid = ValidateMailForm();

            if (Isvalid == false)
            {
                return;
            }

            if (!IsEmailValid(idTxtMailFrom.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address [Mail From]");
                return;
            }

            ImageVisibility(true);
            ProcessingStatus("Saving Settings...");
            var objMailConfig = GetMailSettings();

            var XmlString = Helper.ToXml(objMailConfig);

            var EncryptedXml = CipherUtil.Encrypt(XmlString, Helper.AppConstants.CipherKey);
            if (!Directory.Exists(Helper.AppConstants.UiConfigSavedPath))
                Directory.CreateDirectory(Helper.AppConstants.UiConfigSavedPath);
            File.WriteAllText(Helper.AppConstants.UiConfigSavedPath + Helper.AppConstants.MailConfigFileName, EncryptedXml);
            log.Info("New Mail settings saved");
            ImageVisibility(false);
            MessageBox.Show("Mail Settings saved");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Error(ex.Message);
            }
        }

        public void LoadMailSettings()
        {
            if (File.Exists(Helper.AppConstants.UiConfigSavedPath +
                Helper.AppConstants.MailConfigFileName))
            {
                var EncryptedXml = File.ReadAllText(Helper.AppConstants.UiConfigSavedPath +
                    Helper.AppConstants.MailConfigFileName);
                var DecryptedXml = CipherUtil.Decrypt(EncryptedXml, Helper.AppConstants.CipherKey);
                var ObjBackConfig = Helper.XmlStringToObject<MailConfig>(DecryptedXml);
                SetMailSettings(ObjBackConfig);
            }
        }

        public void SetMailSettings(MailConfig objMailConfig)
        {
            idTxtMailFrom.Text = objMailConfig.MailFrom;
            idTxtPassword.Text = objMailConfig.Password;
            idTxtHost.Text = objMailConfig.Host;
            idTxtPort.Text = objMailConfig.Port;
            idCmbEnableSsl.Text = objMailConfig.EnableSsl;

            foreach (var item in objMailConfig.Receipients.Receiver)
            {
                idListReceipient.Items.Add(item);
            }
        }

        public MailConfig GetMailSettings()
        {
            MailConfig objMailConfig = new MailConfig();

            objMailConfig.MailFrom = idTxtMailFrom.Text.Trim();
            objMailConfig.Password = idTxtPassword.Text.Trim();
            objMailConfig.Host = idTxtHost.Text.Trim();
            objMailConfig.Port = idTxtPort.Text.Trim();
            objMailConfig.EnableSsl = idCmbEnableSsl.Text.Trim();

            List<string> EmailList = new List<string>();
            for (var i = 0; i < idListReceipient.Items.Count; i++)
            {
                EmailList.Add(idListReceipient.Items[i].ToString());
            }
            objMailConfig.Receipients.Receiver.AddRange(EmailList);

            return objMailConfig;
        }

        private void idBtnAddReceipient_Click(object sender, EventArgs e)
        {
            if (idTxtReceipient.Text.Trim() == "")
                return;

            if (!IsEmailValid(idTxtReceipient.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address");
                idTxtReceipient.Focus();
                return;
            }
            idListReceipient.Items.Add(idTxtReceipient.Text);
            idTxtReceipient.Text = "";
        }

        private void idBtnDeleteMail_Click(object sender, EventArgs e)
        {
            for(var i = 0; i<idListReceipient.SelectedItems.Count; i++)
            {
                idListReceipient.Items.Remove(idListReceipient.SelectedItems[i]);
            }
            idListReceipient.ClearSelected();
        }

        private void idBtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                var IsValid = ValidateMailForm();
                if (IsValid == false)
                    return;
                idBtnBack.Enabled = false;
                idBtnTest.Enabled = false;
                idBtnSaveSettings.Enabled = false;
                idBtnAddReceipient.Enabled = false;
                idBtnDeleteMail.Enabled = false;
                SendMailWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ImageVisibility(false);
                MessageBox.Show(ex.Message);
                log.Error(ex.Message);
            }
           
        }

        void SendMailWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ImageVisibility(true);
                ProcessingStatus("Sending test mail...");
                
                var objMailConfig = GetMailSettings();
                Mailer.SendTestMail(objMailConfig);
                ImageVisibility(false);
                MessageBox.Show("Test Mail Sent Successfully.");
            }
            catch (Exception ex)
            {
                ImageVisibility(false);
                MessageBox.Show(ex.Message);
                log.Error(ex.Message);
            }
        }

        void SendMailWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                idBtnBack.Enabled = true;
                idBtnTest.Enabled = true;
                idBtnSaveSettings.Enabled = true;
                idBtnAddReceipient.Enabled = true;
                idBtnDeleteMail.Enabled = true;
            }
            catch (Exception)
            {
                //
            }
           
        }

        private void MailSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnableMailSettingsButtons != null)
            {
                EnableMailSettingsButtons();
            }
        }

    }
}
