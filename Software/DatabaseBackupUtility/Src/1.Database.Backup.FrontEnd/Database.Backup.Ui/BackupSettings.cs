using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using log4net;
using System.IO;
using Database.Backup.Core;
using System.Management;
using System.ServiceProcess;
using Database.Backup.Service;

namespace Database.Backup.Ui
{
    public partial class BackupSettings : Form
    {
        BackgroundWorker CheckDatabaseConnection = new BackgroundWorker();
        BackgroundWorker SaveBackupSettings = new BackgroundWorker();
        BackgroundWorker LoadBackupSettingsWorker = new BackgroundWorker();
        BackgroundWorker TestBackupWorker = new BackgroundWorker();
        ILog log = Helper.Log;

        public delegate void EnableButton();
        public event EnableButton EnableBackupSettingsButtons;

        public BackupSettings()
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

        public bool ValidateServerCredentials()
        {
            string ErrorMessage = "";
            bool IsValid = false;
            if (idTxtServerName.Text.Trim() == "")
                ErrorMessage += "Server Name. \n";
            if (idTxtUserId.Text.Trim() == "")
                ErrorMessage += "User Id. \n";
            if (idTxtPassword.Text.Trim() == "")
                ErrorMessage += "Password. \n";
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

        public bool ValidateBackupDirectory()
        {
            string ErrorMessage = "";
            bool IsValid = false;
            if (idTxtBackupLocation.Text.Trim() == "")
            {
                ErrorMessage += "Backup location. \n";
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

        public bool ValidateBackupPassword()
        {
            string ErrorMessage = "";
            bool IsValid = false;

            if (idChkPasswordProtect.Checked == true)
            {
                if (idTxtBackupPassword.Text.Trim() == "")
                {
                    ErrorMessage += "Backup Password";
                }
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

         public bool IsValidInputDatabase()
        {
            string ErrorMessage = "";
            bool IsValid = false;

            if (idListDatabase.Items.Count == 0)
            {
                ErrorMessage += "Select atleast one database.";
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

        public void LoadBackupSettings()
        {
            if (File.Exists(Helper.AppConstants.UiConfigSavedPath +
                Helper.AppConstants.BackupConfigFileName))
            {
                var EncryptedXml = File.ReadAllText(Helper.AppConstants.UiConfigSavedPath +
                    Helper.AppConstants.BackupConfigFileName);
                var DecryptedXml = CipherUtil.Decrypt(EncryptedXml, Helper.AppConstants.CipherKey);
                var ObjBackConfig = Helper.XmlStringToObject<BackupConfig>(DecryptedXml);
                SetBackupConfig(ObjBackConfig);
            }
        }


        private void BackupSettings_Load(object sender, EventArgs e)
        {
            LoadBackupSettings();
            log.Info("Backup Settings form opened");
            ImageVisibility(false);
            CheckDatabaseConnection.DoWork += new DoWorkEventHandler(CheckDatabaseConnection_DoWork);
            CheckDatabaseConnection.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CheckDatabaseConnection_RunWorkerCompleted);
            SaveBackupSettings.DoWork += new DoWorkEventHandler(SaveBackupSettings_DoWork);
            SaveBackupSettings.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SaveBackupSettings_RunWorkerCompleted);
            TestBackupWorker.DoWork += new DoWorkEventHandler(TestBackupWorker_DoWork);
            TestBackupWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(TestBackupWorker_RunWorkerCompleted);
        }

        





        void SaveBackupSettings_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ImageVisibility(true);
            ProcessingStatus("Saving Settings...");
            if (e.Result is Exception)
                return;
            bool IsValid = true;
            try
            {
                IsValid = ValidateServerCredentials();
                if (IsValid == false)
                {
                    ImageVisibility(false);
                    return;
                }
                IsValid = ValidateBackupDirectory();
                if (IsValid == false)
                {
                    ImageVisibility(false);
                    return;
                }
                IsValid = IsValidInputDatabase();
                if (IsValid == false)
                {
                    ImageVisibility(false);
                    return;
                }
                IsValid = ValidateBackupPassword();
                if (IsValid == false)
                {
                    ImageVisibility(false);
                    return;
                }

                if (!Directory.Exists(idTxtBackupLocation.Text))
                {
                    MessageBox.Show("Backup directory not found.");
                    ImageVisibility(false);
                    return;
                }

                var objBackConfig = GetBackupConfig();
                var XmlString = Helper.ToXml(objBackConfig);

                var EncryptedXml = CipherUtil.Encrypt(XmlString, Helper.AppConstants.CipherKey);
                if (!Directory.Exists(Helper.AppConstants.UiConfigSavedPath))
                    Directory.CreateDirectory(Helper.AppConstants.UiConfigSavedPath);
                File.WriteAllText(Helper.AppConstants.UiConfigSavedPath + Helper.AppConstants.BackupConfigFileName, EncryptedXml);
                log.Info("New backup settings saved");
                try
                {
                    var ServiceList = ServiceController.GetServices();
                    foreach (ServiceController service in ServiceList)
                    {
                        if (service.ServiceName.Contains(Helper.ApplicationInfo.ServiceName))
                        {
                            var ServiceStatus = service.Status.ToString();
                            if (ServiceStatus == "Running")
                            {
                                service.Stop();
                                service.WaitForStatus(ServiceControllerStatus.Stopped);
                                service.Start();
                                service.WaitForStatus(ServiceControllerStatus.Running);
                            }
                            else
                            {
                                service.Start();
                                service.WaitForStatus(ServiceControllerStatus.Running);
                            }
                        }
                    }
                
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
                ImageVisibility(false);
                MessageBox.Show("Back up settings saved successfully");
            }
            catch (Exception ex)
            {
                ImageVisibility(false);
                MessageBox.Show(ex.Message);
                log.Error(ex.Message);
            }
        }

        void SaveBackupSettings_DoWork(object sender, DoWorkEventArgs e)
        {
            ImageVisibility(true);
            ProcessingStatus("Connecting server...");
            SqlConnection myConn = new SqlConnection("Server=" + idTxtServerName.Text.Trim() + ";Initial Catalog=master;User Id=" + idTxtUserId.Text.Trim() + ";Password=" + idTxtPassword.Text.Trim() + "");
            try
            {
                myConn.Open();
                myConn.Close();
                ImageVisibility(false);
                log.Info("Connection successfully tested for server:" + idTxtPassword.Text + ", Uid:" + idTxtUserId.Text + ", Pwd:" + idTxtPassword.Text);

            }
            catch (Exception ex)
            {
                ImageVisibility(false);
                MessageBox.Show("Problem in connection. \n \n" + ex.Message);
                log.Error("Invalid credentials | " + ex.Message);
                e.Result = ex;
            }
        }

        void CheckDatabaseConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            ImageVisibility(true);
            ProcessingStatus("Connecting server...");
            SqlConnection myConn = new SqlConnection("Server=" + idTxtServerName.Text.Trim() + ";Initial Catalog=master;User Id=" + idTxtUserId.Text.Trim() + ";Password=" + idTxtPassword.Text.Trim() + "");
            try
            {
                myConn.Open();
                myConn.Close();
                ImageVisibility(false);
                if (e.Argument != Helper.AppConstants.NoMessageBox)
                {
                    MessageBox.Show("Database connection test successfull.");

                }
                else
                {
                    e.Result = Helper.AppConstants.SelectDatabase;
                }
                log.Info("Connection successfully tested for server:" + idTxtPassword.Text + ", Uid:" + idTxtUserId.Text + ", Pwd:" + idTxtPassword.Text);

            }
            catch (Exception ex)
            {
                ImageVisibility(false);
                MessageBox.Show("Problem in connection. \n \n" + ex.Message);
                log.Error("Invalid credentials | " + ex.Message);
                e.Result = ex;
            }
        }

        private void idBtnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                var Isvalid = ValidateServerCredentials();
                if (Isvalid == false)
                    return;
                CheckDatabaseConnection.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ImageVisibility(false);
                MessageBox.Show(ex.Message);
                log.Error(ex);
            }
        }

        private void idBtnSelectDatabase_Click(object sender, EventArgs e)
        {
            var IsValid = ValidateServerCredentials();
            if (IsValid == false)
                return;

            CheckDatabaseConnection.RunWorkerAsync(Helper.AppConstants.NoMessageBox);
        }

        void CheckDatabaseConnection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result == Helper.AppConstants.SelectDatabase)
            {
                if (e.Result is Exception)
                    return;

                List<string> ParentDatabaseList = new List<string>();
                for (var i = 0; i < idListDatabase.Items.Count; i++)
                {
                    ParentDatabaseList.Add(idListDatabase.Items[i].ToString());
                }


                DatabaseList objDatabaseList = new DatabaseList();
                DatabaseList.SelectedDbList = ParentDatabaseList;
                DatabaseList.ServerCredential.ServerName = idTxtServerName.Text;
                DatabaseList.ServerCredential.UserId = idTxtUserId.Text;
                DatabaseList.ServerCredential.Password = idTxtPassword.Text;
                objDatabaseList.SetDbParentList += new Ui.DatabaseList.setParentDatabase(objDatabaseList_SetDbList);
                


                objDatabaseList.Show(this);
            }

        }

        void objDatabaseList_SetDbList(List<string> lstDb)
        {
            idListDatabase.DataSource = lstDb;
        }

        public List<string> GetSelectedList
        {
            get
            {
                DatabaseList objDbList = new DatabaseList();

                List<string> DatabaseList = new List<string>();
                for (var i = 0; i < idListDatabase.Items.Count; i++)
                {
                    DatabaseList.Add(idListDatabase.Items[i].ToString());
                }
                return DatabaseList;
            }
        }

        private void idBtnCheckLocation_Click(object sender, EventArgs e)
        {
            try
            {
                //var IsValid = ValidateBackupDirectory();
                //if (IsValid == false)
                //    return;
                //if (Directory.Exists(idTxtBackupLocation.Text))
                //{
                //    MessageBox.Show("Backup directory accessible.");
                //}
                //else
                //{
                //    MessageBox.Show("Backup directory not found.");
                //}
                using (var folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {

                        idTxtBackupLocation.Text = folderDialog.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void idChkPasswordProtect_CheckedChanged(object sender, EventArgs e)
        {
            if (idChkPasswordProtect.Checked == true)
            {
                idTxtBackupPassword.Enabled = true;
            }
            else
            {
                idTxtBackupPassword.Enabled = false;
            }
        }

        private void idBtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idBtnSaveSettings_Click(object sender, EventArgs e)
        {
            var ErrorString = "Following fields are required : \n\n";
            var ErrorCount = 0;
            if(string.IsNullOrEmpty(idTxtServerName.Text.Trim()))
            {
                ErrorString += "";
            }
            ImageVisibility(true);
            ProcessingStatus("Saving Settings...");
            SaveBackupSettings.RunWorkerAsync();
        }

        public BackupConfig GetBackupConfig()
        {
            BackupConfig objBackupConfig = new BackupConfig();

            objBackupConfig.ServerCredentials.ServerName = idTxtServerName.Text;
            objBackupConfig.ServerCredentials.UserId = idTxtUserId.Text;
            objBackupConfig.ServerCredentials.Password = idTxtPassword.Text;

            List<string> DatabaseList = new List<string>();
            for (var i = 0; i < idListDatabase.Items.Count; i++)
            {
                DatabaseList.Add(idListDatabase.Items[i].ToString());
            }
            objBackupConfig.BackupDatabase.DatabaseName.AddRange(DatabaseList);

            if (idRdbSundayF.Checked == true)
                objBackupConfig.BackupSchedule.Sunday = Helper.AppConstants.Full;
            else
                objBackupConfig.BackupSchedule.Sunday = Helper.AppConstants.Differential;

            if (idRdbMondayF.Checked == true)
                objBackupConfig.BackupSchedule.Monday = Helper.AppConstants.Full;
            else
                objBackupConfig.BackupSchedule.Monday = Helper.AppConstants.Differential;

            if (idRdbTuesdayF.Checked == true)
                objBackupConfig.BackupSchedule.Tuesday = Helper.AppConstants.Full;
            else
                objBackupConfig.BackupSchedule.Tuesday = Helper.AppConstants.Differential;

            if (idRdbWednesdayF.Checked == true)
                objBackupConfig.BackupSchedule.Wednesday = Helper.AppConstants.Full;
            else
                objBackupConfig.BackupSchedule.Wednesday = Helper.AppConstants.Differential;

            if (idRdbThursdayF.Checked == true)
                objBackupConfig.BackupSchedule.Thursday = Helper.AppConstants.Full;
            else
                objBackupConfig.BackupSchedule.Thursday = Helper.AppConstants.Differential;

            if (idRdbFridayF.Checked == true)
                objBackupConfig.BackupSchedule.Friday = Helper.AppConstants.Full;
            else
                objBackupConfig.BackupSchedule.Friday = Helper.AppConstants.Differential;

            if (idRdbSaturdayF.Checked == true)
                objBackupConfig.BackupSchedule.Saturday = Helper.AppConstants.Full;
            else
                objBackupConfig.BackupSchedule.Saturday = Helper.AppConstants.Differential;

            objBackupConfig.BackupLocation = idTxtBackupLocation.Text;
            objBackupConfig.BackupTime = idDateTimePicker.Text;

            //if (idRdbBak.Checked == true)
            //    objBackupConfig.BackupType = Helper.AppConstants.BackupFileBak;
            //else
            //    objBackupConfig.BackupType = Helper.AppConstants.BackupFileScript;

            objBackupConfig.BackupPassword = idTxtBackupPassword.Text;

            return objBackupConfig;
        }

        public void SetBackupConfig(BackupConfig objBackupConfig)
        {

            idTxtServerName.Text = objBackupConfig.ServerCredentials.ServerName;
            idTxtUserId.Text = objBackupConfig.ServerCredentials.UserId;
            idTxtPassword.Text = objBackupConfig.ServerCredentials.Password;

            idListDatabase.DataSource = objBackupConfig.BackupDatabase.DatabaseName;

            if (objBackupConfig.BackupSchedule.Sunday == Helper.AppConstants.Full)
                idRdbSundayF.Checked = true;
            else
                idRdbSundayD.Checked = true;


            if (objBackupConfig.BackupSchedule.Monday == Helper.AppConstants.Full)
                idRdbMondayF.Checked = true;
            else
                idRdbMondayD.Checked = true;

            if (objBackupConfig.BackupSchedule.Tuesday == Helper.AppConstants.Full)
                idRdbTuesdayF.Checked = true;
            else
                idRdbTuesdayD.Checked = true;

            if (objBackupConfig.BackupSchedule.Wednesday == Helper.AppConstants.Full)
                idRdbWednesdayF.Checked = true;
            else
                idRdbWednesdayD.Checked = true;

            if (objBackupConfig.BackupSchedule.Thursday == Helper.AppConstants.Full)
                idRdbThursdayF.Checked = true;
            else
                idRdbThursdayD.Checked = true;

            if (objBackupConfig.BackupSchedule.Friday == Helper.AppConstants.Full)
                idRdbFridayF.Checked = true;
            else
                idRdbFridayD.Checked = true;

            if (objBackupConfig.BackupSchedule.Saturday == Helper.AppConstants.Full)
                idRdbSaturdayF.Checked = true;
            else
                idRdbSaturdayD.Checked = true;

            idTxtBackupLocation.Text = objBackupConfig.BackupLocation;
            idDateTimePicker.Text = objBackupConfig.BackupTime;

            //if (objBackupConfig.BackupType == Helper.AppConstants.BackupFileBak)
            //    idRdbBak.Checked = true;
            //else
            //    idRdbScript.Checked = true;

            idTxtBackupPassword.Text = objBackupConfig.BackupPassword;

            if (!string.IsNullOrEmpty(objBackupConfig.BackupPassword))
            {
                idChkPasswordProtect.Checked = true;
                idTxtBackupPassword.Enabled = true;
            }
            else
            {
                idTxtBackupPassword.Enabled = false;
            }
        }

        private void idBtnTest_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsValid = true;
                IsValid = ValidateServerCredentials();
                if (IsValid == false)
                {
                    ImageVisibility(false);
                    return;
                }
                IsValid = ValidateBackupDirectory();
                if (IsValid == false)
                {
                    ImageVisibility(false);
                    return;
                }
                IsValid = IsValidInputDatabase();
                if (IsValid == false)
                {
                    ImageVisibility(false);
                    return;
                }
                IsValid = ValidateBackupPassword();
                if (IsValid == false)
                {
                    ImageVisibility(false);
                    return;
                }
                if (!Directory.Exists(idTxtBackupLocation.Text))
                {
                    MessageBox.Show("Backup directory not found.");
                    return;
                }

                idBtnBack.Enabled = false;
                idBtnSaveSettings.Enabled = false;
                idBtnTest.Enabled = false;
                idBtnCheckLocation.Enabled = false;
                idBtnSelectDatabase.Enabled = false;
                idBtnTestConnection.Enabled = false;

                TestBackupWorker.RunWorkerAsync();
            }
            catch (Exception)
            {
                
                throw;
            }
         
        }

        void TestBackupWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ImageVisibility(true);
                var ObjBackupConfig = GetBackupConfig();
                ProcessingStatus("Taking Backup @ " + ObjBackupConfig.BackupLocation);
                BackupHandler.BackupDatabase(ObjBackupConfig);
                ImageVisibility(false);
                MessageBox.Show("Test Backup successfull.","Success");
                
            }
            catch (Exception)
            {
                ImageVisibility(false);
                //
            }
        }

        void TestBackupWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                idBtnBack.Enabled = true;
                idBtnSaveSettings.Enabled = true;
                idBtnTest.Enabled = true;
                idBtnCheckLocation.Enabled = true;
                idBtnSelectDatabase.Enabled = true;
                idBtnTestConnection.Enabled = true;
            }
            catch (Exception)
            {
                
            }
            
        }

        private void BackupSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnableBackupSettingsButtons != null)
            {
                EnableBackupSettingsButtons();
            }
        }



    }
}
