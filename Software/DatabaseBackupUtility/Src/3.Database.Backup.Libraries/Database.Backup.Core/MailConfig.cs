using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Database.Backup.Core
{
    [XmlRoot("Receipients", Namespace = "")]
    [Serializable]
    public class ReceipientsNode
    {
        [XmlElement()]
        public List<string> Receiver { get; set; }

        public ReceipientsNode()
        {
            Receiver = new List<string>();
        }
    }


    [XmlRoot("MailConfig", Namespace = "")]
    [Serializable]
    public class MailConfig
    {

        [XmlElement()]
        public string MailFrom { get; set; }

        [XmlElement()]
        public string Password { get; set; }

        [XmlElement()]
        public string Port { get; set; }

        [XmlElement()]
        public string Host { get; set; }

        [XmlElement()]
        public string EnableSsl { get; set; }

        [XmlElement()]
        public ReceipientsNode Receipients { get; set; }

        public MailConfig()
        {
            Receipients = new ReceipientsNode();
        }
    }
}
