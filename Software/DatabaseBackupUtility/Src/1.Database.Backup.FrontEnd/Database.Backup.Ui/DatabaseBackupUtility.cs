using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Database.Backup.Ui
{
    public partial class DatabaseBackupUtility : Form
    {
        public DatabaseBackupUtility()
        {
            InitializeComponent();
        }

        private void idBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idBtnMailSettings_Click(object sender, EventArgs e)
        {
            idBtnMailSettings.Enabled = false;
            MailSettings objMaiLSettings = new MailSettings();
            objMaiLSettings.EnableMailSettingsButtons += new MailSettings.EnableButton(objMaiLSettings_EnableMailSettingsButtons);
            objMaiLSettings.Show();
        }

        void objMaiLSettings_EnableMailSettingsButtons()
        {
            idBtnMailSettings.Enabled = true;   
        }

        private void DatabaseBackupUtility_Load(object sender, EventArgs e)
        {
        }

        void objBackupLogs_EnableBackupLogButtons()
        {
            idBtnBackupLogs.Enabled = true;
        }

        private void idBtnBackupSettings_Click(object sender, EventArgs e)
        {
            idBtnBackupSettings.Enabled = false;
            BackupSettings objBackupSettings = new BackupSettings();
            objBackupSettings.EnableBackupSettingsButtons += new BackupSettings.EnableButton(objBackupSettings_EnableBackupSettingsButtons);
            objBackupSettings.Show();
        }

        void objBackupSettings_EnableBackupSettingsButtons()
        {
            idBtnBackupSettings.Enabled = true;
        }

        private void idBtnBackupLogs_Click(object sender, EventArgs e)
        {
            BackupLogs objBackupLogs = new BackupLogs();
            objBackupLogs.EnableBackupLogButtons += new BackupLogs.EnableButton(objBackupLogs_EnableBackupLogButtons);
            idBtnBackupLogs.Enabled = false;
            objBackupLogs.Show();
        }

        private void idBtnHelp_Click(object sender, EventArgs e)
        {
            idBtnHelp.Enabled = false;
            Help objHelp = new Help();
            objHelp.EnableHelpButtons += new Help.EnableButton(objHelp_EnableHelpButtons);
            objHelp.Show();
        }

        void objHelp_EnableHelpButtons()
        {
            idBtnHelp.Enabled = true;
        }

        private void idBtnDashboard_Click(object sender, EventArgs e)
        {
            idBtnDashboard.Enabled = false;
            Dashboard objDashboard = new Dashboard();
            objDashboard.EnableDashboardButtons += new Dashboard.EnableButton(objDashboard_EnableDashboardButtons);
            objDashboard.Show();
        }

        void objDashboard_EnableDashboardButtons()
        {
            idBtnDashboard.Enabled = true;
        }

    }
}
