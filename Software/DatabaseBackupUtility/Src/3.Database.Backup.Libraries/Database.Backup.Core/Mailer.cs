using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace Database.Backup.Core
{
    public class Mailer
    {

        private static string MailSignature =  "<div style='font-family: Arial ; background-color: #F5F5F5; padding: 10 10 10 10; font-size: 13px'>"+
                                        "With Regards,</br>"+
                                        "<div style='font-size: 12px; margin-top:5px'>"+
                                        "<b>Database Backup Utility</b> | Open Source Tool."+
                                        "</div></div>";

        public static void SendBackupStatusMail(MailConfig objMailConfig, BackupSuccessLog objBackupSuccessLog)
        {
            foreach (var EmailTo in objMailConfig.Receipients.Receiver)
            {
                var MessageBody = FormMessageBody(objBackupSuccessLog);
                ExecuteBackupStatusMail(EmailTo, objMailConfig, MessageBody);
            }
        }


        private static string FormMessageBody(BackupSuccessLog objBackupSuccessLog)
        {
            string StatusTable = "";
            StatusTable += "<style type='text/css'>#StatusTable{ border-collapse: collapse !important;} #StatusTable td "+
                            "{border: 1px solid #cccccc !important; padding:5px;} #StatusTable thead{font-weight:bold; background-color:#fafafa;}</style>" +
                            "<table id='StatusTable' style='font-family: Arial !important; font-size: 13px !important'><thead>"+
                            "<tr><td>Database Name</td><td>Backup Date/Time</td><td style='width:200px'>Backup Location</td><td>Backup Type</td>"+
                            "<td>Backup Status</td></tr></thead>";

            for (var i = 0; i < objBackupSuccessLog.DatabaseName.Count; i++)
            {
                StatusTable += "<tr><td>" + objBackupSuccessLog.DatabaseName[i] + "</td><td> " + objBackupSuccessLog.DateTime[i] + "</td><td style='width:200px'>" + objBackupSuccessLog.Location[i] +
                                "</td><td>" + objBackupSuccessLog.BackupType[i] + "</td><td>" + objBackupSuccessLog.Status[i] + "</td></tr>";
            }
            StatusTable += "</table>";
            return StatusTable;
        }



        public static void ExecuteBackupStatusMail(string EmailTo, MailConfig objMailConfig, string MessageBody)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(EmailTo);
            mail.From = new MailAddress(objMailConfig.MailFrom, "Database Backup Status Mail.", System.Text.Encoding.UTF8);

            mail.Subject = Helper.ApplicationInfo.ProductName;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;

            string message = "<div style='font-family: Arial !important; font-size: 13px !important'>Hello User, </br></br>" +
                                "Following is the database backup status : </br></br>" + MessageBody +"</br></br>"+ MailSignature +"</div>";
            mail.Body = message;

            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();

            client.Credentials = new System.Net.NetworkCredential(objMailConfig.MailFrom, objMailConfig.Password);
            client.Port = int.Parse(objMailConfig.Port);
            client.Host = objMailConfig.Host;
            client.EnableSsl = bool.Parse(objMailConfig.EnableSsl);
            client.Send(mail);
        }

        public static void SendTestMail(MailConfig objMailConfig)
        {
            foreach (var EmailTo in objMailConfig.Receipients.Receiver)
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add(EmailTo);
                mail.From = new MailAddress(objMailConfig.MailFrom, "Test Mail", System.Text.Encoding.UTF8);

                mail.Subject = Helper.ApplicationInfo.ProductName;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;

                string message = "<div style='font-family: Arial; font-size: 13px'>Hello User, </br></br>This is a test mail sent from Database Backup Utility application at <b>" +
                                    DateTime.Now.ToString(Helper.AppConstants.DateTimeFormat) + "</b>.</br> Please do not respond. </br></br></div>" + MailSignature;
                
                mail.Body = message;

                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                SmtpClient client = new SmtpClient();

                client.Credentials = new System.Net.NetworkCredential(objMailConfig.MailFrom, objMailConfig.Password);
                client.Port = int.Parse(objMailConfig.Port);
                client.Host = objMailConfig.Host;
                client.EnableSsl = bool.Parse(objMailConfig.EnableSsl);
                client.Send(mail);
            }
        }

        public static void SendZipPassword(MailConfig objMailConfig,string ZipPassword)
        {
            foreach (var EmailTo in objMailConfig.Receipients.Receiver)
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add(EmailTo);
                mail.From = new MailAddress(objMailConfig.MailFrom, "Zip Password", System.Text.Encoding.UTF8);

                mail.Subject = Helper.ApplicationInfo.ProductName;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;

                string message = "<div style='font-family: Arial; font-size: 13px'>Hello User, </br></br>The password for your database zip file is as follows. <b>" +
                                    "</b></br></br> <b>" + ZipPassword + "</b> </br></br></div>" + MailSignature;

                mail.Body = message;

                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                SmtpClient client = new SmtpClient();

                client.Credentials = new System.Net.NetworkCredential(objMailConfig.MailFrom, objMailConfig.Password);
                client.Port = int.Parse(objMailConfig.Port);
                client.Host = objMailConfig.Host;
                client.EnableSsl = bool.Parse(objMailConfig.EnableSsl);
                client.Send(mail);
            }
        }
    }
}
