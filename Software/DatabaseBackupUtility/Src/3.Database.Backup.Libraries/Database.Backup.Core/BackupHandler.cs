using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using log4net;
using Ionic.Zip;

namespace Database.Backup.Core
{
    public class BackupHandler
    {
        static ILog log = Helper.Log;

        public static string GetBackupType(BackupConfig ObjBackupConfig)
        {
            try
            {
                var BackupType = "";
                var SystemDay = DateTime.Now.DayOfWeek;
                var type = ObjBackupConfig.BackupSchedule.GetType();
                foreach (var property in type.GetProperties())
                {
                    if (property.Name.ToLower().Contains(SystemDay.ToString().ToLower()))
                    {
                        Type myType = ObjBackupConfig.BackupSchedule.GetType();
                        PropertyInfo pinfo = myType.GetProperty(property.Name);
                        BackupType = pinfo.GetValue(ObjBackupConfig.BackupSchedule, null).ToString();
                    }
                }
                return BackupType;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;
            }
        }

        public static void BackupDatabase(BackupConfig objBackupConfig)
        {
            try
            {
                var StatusObject = new BackupSuccessLog();
                string filename = "Database Backup Utility";
                string ConnectionString = "server=" + objBackupConfig.ServerCredentials.ServerName + ";uid=" +
                                                        objBackupConfig.ServerCredentials.UserId + ";password=" +
                                                        objBackupConfig.ServerCredentials.Password + ";";

                string BackUpType = GetBackupType(objBackupConfig);
                string zipPath = objBackupConfig.BackupLocation + @"\" + DateTime.Now.ToString("yyyyMMdd") + "_" + BackUpType; ;
                foreach (var databaseName in objBackupConfig.BackupDatabase.DatabaseName)
                {
                    try
                    {
                        StatusObject.DatabaseName.Add(databaseName);
                        StatusObject.DateTime.Add(DateTime.Now.ToString(Helper.AppConstants.DateTimeFormat));
                        StatusObject.BackupType.Add(BackUpType);
                        string BackUpPath = objBackupConfig.BackupLocation + @"\" + DateTime.Now.ToString("yyyyMMdd") + "_" + BackUpType;

                        if (!Directory.Exists(BackUpPath))
                            Directory.CreateDirectory(BackUpPath);
                        BackUpPath += @"\" + databaseName + ".bak";
                        StatusObject.Location.Add(BackUpPath);
                        using (var connection = new SqlConnection(ConnectionString))
                        {
                            var query = "";
                            if (BackUpType == Helper.AppConstants.Full)
                            {
                                query = String.Format("BACKUP DATABASE {0} TO DISK = '{1}' WITH INIT, NAME= '[{2}]', NOSKIP, NOFORMAT ", databaseName, BackUpPath, filename);
                            }
                            else if (BackUpType == Helper.AppConstants.Differential)
                            {
                                query = String.Format(" select  database_name,type,backup_finish_date from  msdb.dbo.backupset where database_name='{0}' and type ='D'" +
                                                        "  if  @@ROWCOUNT > 0 " +
                                                        "BACKUP DATABASE {0} TO DISK = '{1}' WITH DIFFERENTIAL, NAME= '[{2}]', NOSKIP, NOFORMAT " +
                                                            " else " +
                                                        "BACKUP DATABASE {0} TO DISK = '{3}' WITH INIT, NAME= '[{2}]', NOSKIP, NOFORMAT ", databaseName, BackUpPath, filename, BackUpPath.Replace(".DIFF", ".FULL"));
                            }

                            using (var command = new SqlCommand(query, connection))
                            {
                                command.CommandTimeout = 0;
                                connection.Open();
                                command.ExecuteNonQuery();

                            }
                        }
                        
                        log.Info("Backup Successfull.  Database : " + databaseName + ", Type : " + BackUpType + ", Backup Path : " + BackUpPath + " @ " + DateTime.Now.ToString(Helper.AppConstants.DateTimeFormat));
                        StatusObject.Status.Add("SuccessFull");
                        
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex);
                        StatusObject.Status.Add("Failed");
                    }
                }
                var objMailConfig = Helper.GetMailConfig();
                if (!string.IsNullOrEmpty(objBackupConfig.BackupPassword))
                {
                    CreatePasswordProtectedZip(zipPath, objBackupConfig.BackupPassword);
                }
                Mailer.SendBackupStatusMail(objMailConfig, StatusObject);
                DatabaseBackupLog(StatusObject);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }


        public static void CreatePasswordProtectedZip(string path, string pwd)
        {
            using (ZipFile zip = new ZipFile())
            {
                zip.Password = pwd;
                zip.AddDirectory(path);
                zip.Save(path + ".zip");
                Directory.Delete(path,true);
            }
        }

        public static void DatabaseBackupLog(BackupSuccessLog objBackupSuccessLog)
        {
            try
            {
                var CurrentDirectory = Helper.AppConstants.ServiceConfigSavedPath + DateTime.Now.ToString("MMMM") + "\\";
                if (!Directory.Exists(CurrentDirectory))
                    Directory.CreateDirectory(CurrentDirectory);
                var XmlString = Helper.ToXml(objBackupSuccessLog);
                var EncryptedXml = CipherUtil.Encrypt(XmlString, Helper.AppConstants.CipherKey);
                File.WriteAllText(CurrentDirectory + Helper.TimeStamp + ".dat", EncryptedXml);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
           
        }
    }
}
