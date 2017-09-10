using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Database.Backup.Core
{
    [XmlRoot("ServerCredentials", Namespace = "", IsNullable = true)]
    [Serializable]
    public class ServerCredentialsNode
    {
        [XmlAttribute()]
        public string ServerName { get; set; }

        [XmlAttribute()]
        public string UserId { get; set; }

        [XmlAttribute()]
        public string Password { get; set; }
    }

    [XmlRoot("BackupDatabase", Namespace = "", IsNullable = true)]
    [Serializable]
    public class BackupDatabaseNode
    {
        [XmlElement()]
        public List<string> DatabaseName { get; set; }

        public BackupDatabaseNode()
        {
            DatabaseName = new List<string>();
        }
    }

    [XmlRoot("BackupSchedule", Namespace = "", IsNullable = true)]
    [Serializable]
    public class BackupScheduleNode
    {
        [XmlElement()]
        public string Sunday { get; set; }

        [XmlElement()]
        public string Monday { get; set; }

        [XmlElement()]
        public string Tuesday { get; set; }

        [XmlElement()]
        public string Wednesday { get; set; }

        [XmlElement()]
        public string Thursday { get; set; }

        [XmlElement()]
        public string Friday { get; set; }

        [XmlElement()]
        public string Saturday { get; set; }
    }

    [XmlRoot("BackupConfig", Namespace = "")]
    [Serializable]
    public class BackupConfig
    {

        [XmlElement()]
        public ServerCredentialsNode ServerCredentials { get; set; }

        [XmlElement()]
        public BackupDatabaseNode BackupDatabase { get; set; }

        [XmlElement()]
        public BackupScheduleNode BackupSchedule { get; set; }

        [XmlElement()]
        public string BackupLocation { get; set; }

        [XmlElement()]
        public string BackupTime { get; set; }

        [XmlElement()]
        public string BackupType { get; set; }

        [XmlElement()]
        public string BackupPassword { get; set; }

        public BackupConfig()
        {
            ServerCredentials = new ServerCredentialsNode();
            BackupDatabase = new BackupDatabaseNode();
            BackupSchedule = new BackupScheduleNode();
            BackupLocation = "";
            BackupTime = "";
            BackupType = "";
            BackupPassword = "";
        }
    

    }
}
