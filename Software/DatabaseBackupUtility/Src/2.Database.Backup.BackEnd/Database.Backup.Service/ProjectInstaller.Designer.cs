namespace Database.Backup.Service
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DatabaseBackupProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.DatabaseBackupServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // DatabaseBackupProcessInstaller
            // 
            this.DatabaseBackupProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.DatabaseBackupProcessInstaller.Password = null;
            this.DatabaseBackupProcessInstaller.Username = null;
            // 
            // DatabaseBackupServiceInstaller
            // 
            this.DatabaseBackupServiceInstaller.Description = "Takes database backup in timely fashion";
            this.DatabaseBackupServiceInstaller.DisplayName = "Database Backup Utility";
            this.DatabaseBackupServiceInstaller.ServiceName = "Database Backup Utility";
            this.DatabaseBackupServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.DatabaseBackupProcessInstaller,
            this.DatabaseBackupServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller DatabaseBackupProcessInstaller;
        private System.ServiceProcess.ServiceInstaller DatabaseBackupServiceInstaller;
    }
}