using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;
using System.Data;
using System.ComponentModel;
using Microsoft.Win32;

namespace Database.Backup.Core
{
    public static class Helper
    {

        public static class ApplicationInfo
        {
            public const string Version = "1.0.*";
            public const string Company = "";
            public const string ProductName = "Database Backup Utility";
            public const string ServiceName = "Database Backup Utility";
            public const string Copyright = "Open Source";
            public const string Description = ProductName + " is an application used to take backup of SQL database.";
        }

        public static ILog Log
        {
            get
            {
                return log4net.LogManager.GetLogger(Assembly.GetCallingAssembly(), "DefaultLoggger");
            }
        }

        public static double Add24HrsInterval
        {
            get
            {
                return (24 * 60 * 60) * 1000;
            }
        }

        public static string TimeStamp
        {
            get
            {
                return DateTime.Now.ToString("yyyyMMddHHmmssffff");
            }
        }

        public static string GetLogPathForUi
        {
            get
            {
                var LogPath = "";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\DBU\Database Backup Utility"))
                {
                    if (key != null)
                    {
                        Object o = key.GetValue("InstalledPath");
                        LogPath = o.ToString();
                    }
                }
                LogPath += @"\Applications\Database.Backup.Service\BackupLogs";
                return LogPath;
            }
        }

        public static string GetBackupConfigPathForService
        {
            get
            {
                var CurrentDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                var BackupConfigPath = "";
                var ArrayCurrentDirectory = CurrentDirectory.Split(new char[] { '\\' });
                
                for (var i = 0; i < ArrayCurrentDirectory.Count(); i++)
                {
                    if (i != ArrayCurrentDirectory.Count() - 2)
                        BackupConfigPath += ArrayCurrentDirectory[i] + "\\";
                }
                BackupConfigPath += "Database.Backup.Ui\\App_Data\\" + Helper.AppConstants.BackupConfigFileName;

#if DEBUG
                BackupConfigPath = "";
                CurrentDirectory = Environment.CurrentDirectory;
                ArrayCurrentDirectory = CurrentDirectory.Split(new char[] { '\\' });

                for (var i = 0; i < ArrayCurrentDirectory.Count(); i++)
                {
                    if (i != ArrayCurrentDirectory.Count() - 1)
                        BackupConfigPath += ArrayCurrentDirectory[i] + "\\";
                }
                BackupConfigPath += "Database.Backup.Ui\\App_Data\\" + Helper.AppConstants.BackupConfigFileName;
#endif
                return BackupConfigPath;
            }
        }

        public static string GetMailConfigPathForService
        {
            get
            {
                var CurrentDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                var BackupConfigPath = "";
                var ArrayCurrentDirectory = CurrentDirectory.Split(new char[] { '\\' });

                for (var i = 0; i < ArrayCurrentDirectory.Count(); i++)
                {
                    if (i != ArrayCurrentDirectory.Count() - 2)
                        BackupConfigPath += ArrayCurrentDirectory[i] + "\\";
                }
                BackupConfigPath += "Database.Backup.Ui\\App_Data\\" + Helper.AppConstants.MailConfigFileName;

#if DEBUG
                BackupConfigPath = "";
                CurrentDirectory = Environment.CurrentDirectory;
                ArrayCurrentDirectory = CurrentDirectory.Split(new char[] { '\\' });

                for (var i = 0; i < ArrayCurrentDirectory.Count(); i++)
                {
                    if (i != ArrayCurrentDirectory.Count() - 1)
                        BackupConfigPath += ArrayCurrentDirectory[i] + "\\";
                }
                BackupConfigPath += "Database.Backup.Ui\\App_Data\\" + Helper.AppConstants.MailConfigFileName;
#endif
                return BackupConfigPath;
            }
        }


        public static MailConfig GetMailConfig()
        {
            var MailConfigPath = Helper.GetMailConfigPathForService;
            if (File.Exists(MailConfigPath))
            {
                if (File.Exists(MailConfigPath))
                {
                    var EncryptedXml = File.ReadAllText(MailConfigPath);
                    var DecryptedXml = CipherUtil.Decrypt(EncryptedXml, Helper.AppConstants.CipherKey);
                    var ObjBackConfig = Helper.XmlStringToObject<MailConfig>(DecryptedXml);
                    return ObjBackConfig;
                }
                else
                    return new MailConfig();
            }
            else
            {
                Log.Error("Mail config file does not exist or corrupted.");
                return new MailConfig();
            }
        }

        public static BackupConfig GetBackupConfig()
        {

            if (File.Exists(Helper.AppConstants.UiConfigSavedPath +
                   Helper.AppConstants.BackupConfigFileName))
            {
                var EncryptedXml = File.ReadAllText(Helper.AppConstants.UiConfigSavedPath +
                    Helper.AppConstants.BackupConfigFileName);
                var DecryptedXml = CipherUtil.Decrypt(EncryptedXml, Helper.AppConstants.CipherKey);
                var ObjBackConfig = Helper.XmlStringToObject<BackupConfig>(DecryptedXml);
                return ObjBackConfig;
            }
            else
            {
                return new BackupConfig();
            }
        }

        public static class AppConstants
        {
            public static string DateTimeFormat = "dd-MMM-yyy HH:mm:ss";

            public static string SelectDatabase = "SelectDatabase";
            public static string NoMessageBox = "NoMessageBox";

            public static string Full = "Full";
            public static string Differential = "Differential";

            public static string BackupFileBak = "BackupFileBak";
            public static string BackupFileScript = "BackupFileScript";

            public static string CipherKey = "Database.Backup.Utility";

            public static string UiConfigSavedPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\App_Data\";
            public static string ServiceConfigSavedPath = System.AppDomain.CurrentDomain.BaseDirectory + @"\BackupLogs\";

            public static string BackupConfigFileName = "BackUpConfig.dat";
            public static string MailConfigFileName = "MailConfig.dat";

        }

        public static string ToXml(object obj)
        {
            XmlSerializer s = new XmlSerializer(obj.GetType(), "");
            using (StringWriter writer = new StringWriter())
            {
                s.Serialize(writer, obj);
                return writer.ToString();
            }
        }

        public static T XmlStringToObject<T>(string xmlData) where T : class
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var stringReader = new StringReader(xmlData))
            {
                var sp = serializer.Deserialize(stringReader) as T;
                return sp;
            }
        }

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
            
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

    }
}
