using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Database.Backup.Core;
using System.Timers;
using System.Reflection;
using System.IO;

namespace Database.Backup.Service
{
    public class BackupProcessor
    {
        ILog log = Helper.Log;
        Timer timer = new Timer();

        public void Init()
        {
            try
            {
                var Backtime = "";
                var ObjBackupConfig = ProcessHandler.GetBackConfig();
                this.timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
                var EstimatedTime = new TimeSpan(); 
                if (DateTime.Now > DateTime.Parse(ObjBackupConfig.BackupTime))
                {
                    EstimatedTime = DateTime.Now.ToUniversalTime() - DateTime.Parse(ObjBackupConfig.BackupTime).ToUniversalTime();
                    TimeSpan OneDay = new TimeSpan(24, 0, 0);
                    var mSec = (OneDay - EstimatedTime).TotalMilliseconds;
                    Backtime = DateTime.Now.AddMilliseconds(mSec).ToString(Helper.AppConstants.DateTimeFormat);
                    this.timer.Interval = mSec;
                }
                else
                {
                    EstimatedTime = DateTime.Parse(ObjBackupConfig.BackupTime) - DateTime.Now;
                    this.timer.Interval = EstimatedTime.TotalMilliseconds;
                    Backtime = DateTime.Now.AddMilliseconds(EstimatedTime.TotalMilliseconds).ToString(Helper.AppConstants.DateTimeFormat);
                }
                this.timer.Enabled = true;
                this.timer.Start();
                log.Info("Initialized.");
                log.Info("Next backup will be taken on : " + Backtime);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            
          
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                timer.Interval = Helper.Add24HrsInterval;
                log.Info("Next backup will be taken on : " + DateTime.Now.AddMilliseconds(Helper.Add24HrsInterval).ToString(Helper.AppConstants.DateTimeFormat));
                var ObjBackupConfig = ProcessHandler.GetBackConfig();
                BackupHandler.BackupDatabase(ObjBackupConfig);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
           
        }
    }
}
