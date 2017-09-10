using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using log4net;
using Database.Backup.Core;

namespace Database.Backup.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            ILog log = Helper.Log;
            BackupService objService = new BackupService();
            objService.Run(args);
        }
    }
}
