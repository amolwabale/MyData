using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using Database.Backup.Core;
using log4net;
using System.IO;

namespace Database.Backup.Ui
{
    public partial class Dashboard : Form
    {
        public delegate void EnableButton();
        public event EnableButton EnableDashboardButtons;
        ILog log = Helper.Log;
        BackgroundWorker SendZipPasswordWorker = new BackgroundWorker();

        public Dashboard()
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

        public void LoadServiceStatus()
        {
            try
            {
                var ServiceList = ServiceController.GetServices();
                foreach (ServiceController service in ServiceList)
                {
                    if (service.ServiceName.Contains(Helper.ApplicationInfo.ServiceName))
                    {
                        var ServiceStatus = service.Status.ToString();
                        idLabelServiceStatus.Text = ServiceStatus;
                    }
                }

            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ImageVisibility(false);
            LoadServiceStatus();
            SendZipPasswordWorker.DoWork += new DoWorkEventHandler(SendZipPasswordWorker_DoWork);
            SendZipPasswordWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SendZipPasswordWorker_RunWorkerCompleted);
        }

        void SendZipPasswordWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Mail Settings Not configured or Internet not connected.");
            }
            else
            {
                idLabelForgotZipPassword.Enabled = true;
            }
        }

        void SendZipPasswordWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ImageVisibility(true);
                ProcessingStatus("Sending Zip password to registered mail...");
                var MailConfigPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\App_Data\\" + Helper.AppConstants.MailConfigFileName;
                var EncryptedXml = File.ReadAllText(MailConfigPath);
                var DecryptedXml = CipherUtil.Decrypt(EncryptedXml, Helper.AppConstants.CipherKey);
                var ObjMailSettings = Helper.XmlStringToObject<MailConfig>(DecryptedXml);
                var ObjBackupSettings = Helper.GetBackupConfig();
                Mailer.SendZipPassword(ObjMailSettings, ObjBackupSettings.BackupPassword);
                ImageVisibility(false);
                MessageBox.Show("Zip password sent to mail successfully.");
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                ImageVisibility(false);
                log.Error(ex);
            }
           
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnableDashboardButtons != null)
            {
                EnableDashboardButtons();
            }
        }

        private void idBtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idLabelForgotZipPassword_Click(object sender, EventArgs e)
        {
            var ObjBackupSettings = Helper.GetBackupConfig();
            if (!string.IsNullOrEmpty(ObjBackupSettings.BackupPassword))
            {
                idLabelForgotZipPassword.Enabled = false;
                SendZipPasswordWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Backup is not password protected.");
            }
        }

        
    }
}
