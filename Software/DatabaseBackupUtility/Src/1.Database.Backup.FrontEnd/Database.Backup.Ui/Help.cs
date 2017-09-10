using Database.Backup.Core;
using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Database.Backup.Ui
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }
        ILog log = Helper.Log;
        public delegate void EnableButton();
        public event EnableButton EnableHelpButtons;


        private void Help_Load(object sender, EventArgs e)
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory + @"Documents\UserManual.pdf";
            log.Info(path);
            idWebBrowser.Navigate(path);
        }

        private void Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EnableHelpButtons != null)
            {
                EnableHelpButtons();
            }
        }
    }
}
