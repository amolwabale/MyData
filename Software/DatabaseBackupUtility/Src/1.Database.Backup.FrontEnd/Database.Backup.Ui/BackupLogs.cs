using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Database.Backup.Core;
using System.IO;
using log4net;

namespace Database.Backup.Ui
{
    public partial class BackupLogs : Form
    {
        ILog log = Helper.Log;
        BackgroundWorker LoadDataGridWorker = new BackgroundWorker();

        public delegate void EnableButton();
        public event EnableButton EnableBackupLogButtons;

        bool CmbReady = false;

        public BackupLogs()
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

        private void idBtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadDataGrid()
        {
            try
            {
                var logPath = Helper.GetLogPathForUi;
                var CurrentMonth = DateTime.Now.ToString("MMMM");
                logPath = logPath + "\\" + idCmbSelectMonth.Text;
                var files = Directory.GetFiles(logPath);
                files.OrderByDescending(m=> Name);
                List<BackupSuccessLog> objListBackupSuccessLog = new List<BackupSuccessLog>();

                foreach (var item in files)
                {
                    var EncryptedXml = File.ReadAllText(item);
                    var DecryptedXml = CipherUtil.Decrypt(EncryptedXml, Helper.AppConstants.CipherKey);
                    var ObjBackupSuccessLog = Helper.XmlStringToObject<BackupSuccessLog>(DecryptedXml);
                    objListBackupSuccessLog.Add(ObjBackupSuccessLog);
                }

                List<DataTableBackupSuccessLog> objDtLogs = new List<DataTableBackupSuccessLog>();
                foreach (var item in objListBackupSuccessLog)
                {
                    
                    for (var i = 0; i < item.DatabaseName.Count; i++)
                    {
                        DataTableBackupSuccessLog obj = new DataTableBackupSuccessLog();
                        obj.DatabaseName = item.DatabaseName[i];
                        obj.DateTime = item.DateTime[i];
                        obj.BackupType = item.BackupType[i];
                        obj.Status = item.Status[i];
                        obj.Location = item.Location[i];
                        objDtLogs.Add(obj);
                    }
                }
                var dt = Helper.ToDataTable<DataTableBackupSuccessLog>(objDtLogs);
                idDataGridViewBackupLog.DataSource = dt;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void BackupLogs_Load(object sender, EventArgs e)
        {
            ImageVisibility(false);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            LoadDataGridWorker.DoWork += new DoWorkEventHandler(LoadDataGridWorker_DoWork);
            LoadDataGridWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(LoadDataGridWorker_RunWorkerCompleted);
            List<string> names = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();;
            names.RemoveAll(m => string.IsNullOrEmpty(m));
            var CurrentMonth = DateTime.Now.ToString("MMMM");
            idCmbSelectMonth.DataSource = names;
            idCmbSelectMonth.SelectedItem = CurrentMonth;
            CmbReady = true; // Always write this syntax to las of load, this is written bcoz insex change event is triggered on setting data source and backgroud worker becomes busy
            LoadDataGridWorker.RunWorkerAsync(idCmbSelectMonth.Text);
            idGridViewPanel.Height = this.Height - 170;
        }

        void LoadDataGridWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            idDataGridViewBackupLog.DataSource = e.Result;
        }

        void LoadDataGridWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ImageVisibility(true);
            ProcessingStatus("Loading backup logs...");

            try
            {
                var logPath = Helper.GetLogPathForUi;
                var CurrentMonth = DateTime.Now.ToString("MMMM");
                logPath = logPath + "\\" + e.Argument.ToString();
                List<string> files = new List<string>();
                if (Directory.Exists(logPath))
                {
                    files = Directory.GetFiles(logPath).ToList();
                    files.OrderByDescending(m => Name);
                }
                List<BackupSuccessLog> objListBackupSuccessLog = new List<BackupSuccessLog>();

                foreach (var item in files)
                {
                    var EncryptedXml = File.ReadAllText(item);
                    var DecryptedXml = CipherUtil.Decrypt(EncryptedXml, Helper.AppConstants.CipherKey);
                    var ObjBackupSuccessLog = Helper.XmlStringToObject<BackupSuccessLog>(DecryptedXml);
                    objListBackupSuccessLog.Add(ObjBackupSuccessLog);
                }

                List<DataTableBackupSuccessLog> objDtLogs = new List<DataTableBackupSuccessLog>();
                foreach (var item in objListBackupSuccessLog)
                {
                    for (var i = 0; i < item.DatabaseName.Count; i++)
                    {
                        DataTableBackupSuccessLog obj = new DataTableBackupSuccessLog();
                        obj.DatabaseName = item.DatabaseName[i];
                        obj.DateTime = item.DateTime[i];
                        obj.BackupType = item.BackupType[i];
                        obj.Status = item.Status[i];
                        obj.Location = item.Location[i];
                        objDtLogs.Add(obj);
                    }
                }

                var dt = Helper.ToDataTable<DataTableBackupSuccessLog>(objDtLogs);
                e.Result = dt;
                ImageVisibility(false);
            }
            catch (Exception ex)
            {
                ImageVisibility(false);
                log.Error(ex);
            }
            idLabelLogMonth.Text = idCmbSelectMonth.Text + " Logs";
        }

        private void idCmbSelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbReady == false)
                    return;
                while (LoadDataGridWorker.IsBusy)
                {
                    ImageVisibility(true);
                    ProcessingStatus("Loading Logs...");
                    LoadDataGridWorker.WorkerSupportsCancellation = false;
                    LoadDataGridWorker.CancelAsync();
                }
                ImageVisibility(false);
                LoadDataGridWorker.RunWorkerAsync(idCmbSelectMonth.Text);
            }
            catch (Exception ex)
            {
                ImageVisibility(false);
            }
        }

        private void BackupLogs_SizeChanged(object sender, EventArgs e)
        {
            idGridViewPanel.Height = this.Height - 170;
        }

        private void BackupLogs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnableBackupLogButtons != null)
            {
                EnableBackupLogButtons();
            }
        }

       
    }
}
