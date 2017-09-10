using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Database.Backup.Core;
using log4net;

namespace Database.Backup.Service
{
    public class ProcessHandler
    {

        static ILog log = Helper.Log;

        public static BackupConfig GetBackConfig()
        {
            var BackupConfigPath = Helper.GetBackupConfigPathForService;
            if (File.Exists(BackupConfigPath))
            {
                if (File.Exists(BackupConfigPath))
                {
                    var EncryptedXml = File.ReadAllText(BackupConfigPath);
                    var DecryptedXml = CipherUtil.Decrypt(EncryptedXml, Helper.AppConstants.CipherKey);
                    var ObjBackConfig = Helper.XmlStringToObject<BackupConfig>(DecryptedXml);
                    return ObjBackConfig;
                }
                else
                    return new BackupConfig();
            }
            else
            {
                log.Error("Backup config file does not exist or corrupted.");
                return new BackupConfig();
            }
        }

       
    }
}
