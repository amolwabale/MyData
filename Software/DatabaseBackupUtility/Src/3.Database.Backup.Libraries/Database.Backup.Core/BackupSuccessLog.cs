using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Backup.Core
{
    public class BackupSuccessLog
    {
        public List<string> DatabaseName { get; set; }
        public List<string> DateTime { get; set; }
        public List<string> BackupType { get; set; }
        public List<string> Status { get; set; }
        public List<string> Location { get; set; }

        public BackupSuccessLog()
        {
            DatabaseName = new List<string>();
            DateTime = new List<string>();
            BackupType = new List<string>();
            Status = new List<string>();
            Location = new List<string>();
        }
    }

    public class DataTableBackupSuccessLog
    {
        public string DatabaseName { get; set; }
        public string DateTime { get; set; }
        public string BackupType { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }

        public DataTableBackupSuccessLog()
        {
            DatabaseName = "";
            DateTime = "";
            BackupType = "";
            Status = "";
            Location = "";
        }
    }
}
