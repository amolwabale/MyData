using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Configuration.Install;
using System.Reflection;
using log4net;
using Database.Backup.Core;

namespace Database.Backup.Service
{
    public partial class BackupService : ServiceBase
    {
        ILog log = Helper.Log;

        public BackupService()
        {
            InitializeComponent();
        }

        public void Run(string[] args)
        {
            if (Environment.UserInteractive)
            {
                log.Info("Run");
                string parameter = string.Concat(args);
                switch (parameter)
                {
                    case "-i":
                        {
                            this.InstallOrUninstallService("-u");
                            this.InstallOrUninstallService("-i");
                            break;
                        }
                    case "-u":
                        {
                            this.InstallOrUninstallService(parameter);
                            break;
                        }
                    default:
                        {
                            this.OnStart(args);
                            Console.WriteLine("Press any key to stop program");
                            Console.Read();
                            this.OnStop();
                            break;
                        }
                }
            }
            else
            {
                // Run as windows service
                ServiceBase.Run(this);
            }
        }

        protected void InstallOrUninstallService(string parameter)
        {
            try
            {
                if (parameter == "-i")
                {
                    // Install Service
                    ManagedInstallerClass.InstallHelper(new string[] { Assembly.GetExecutingAssembly().Location });
                }
                else if (parameter == "-u")
                {
                    // Uninstall service
                    ManagedInstallerClass.InstallHelper(new string[] { "/u", Assembly.GetExecutingAssembly().Location });
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        protected override void OnStart(string[] args)
        {
            log.Info("OnStart");
            BackupProcessor objBackupProcessor = new BackupProcessor();
            objBackupProcessor.Init();
        }

        protected override void OnStop()
        {
        }

    }
}
