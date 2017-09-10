using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using System.Data.SqlClient;
using Database.Backup.Core;

namespace Database.Backup.Ui
{
    public partial class DatabaseList : Form
    {

        BackgroundWorker LoadDatabaseList = new BackgroundWorker();
        ILog log = Helper.Log;
        List<string> DatabaseCustomList = new List<string>();
        public delegate void setParentDatabase(List<string> lstDb);
        public event setParentDatabase SetDbParentList;

        public DatabaseList()
        {
            InitializeComponent();
           
        }

        public static List<string> SelectedDbList = new List<string>();

        public static class ServerCredential 
        {
            public static string ServerName;

            public static string UserId;

            public static string Password;
        }

        public void ShowSelectedDatabase()
        {
            var lst = SelectedDbList;
            idListMasterDatabase.ClearSelected();
            for (var i = 0; i < idListMasterDatabase.Items.Count; i++)
            {
                for (var j = 0; j < lst.Count; j++)
                {
                    if (lst[j].ToString() == idListMasterDatabase.Items[i].ToString())
                    {
                        idListMasterDatabase.SelectedItems.Add(idListMasterDatabase.Items[i]);
                    }
                }
            }
        }

        

        private void DatabaseList_Load(object sender, EventArgs e)
        {
            LoadDatabaseList.DoWork += new DoWorkEventHandler(LoadDatabaseList_DoWork);
            LoadDatabaseList.RunWorkerCompleted += new RunWorkerCompletedEventHandler(LoadDatabaseList_RunWorkerCompleted);
            LoadDatabaseList.RunWorkerAsync();
        }

        void LoadDatabaseList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            idListMasterDatabase.DataSource = DatabaseCustomList;
            ShowSelectedDatabase();
        }

        void LoadDatabaseList_DoWork(object sender, DoWorkEventArgs e)
        {
            SqlConnection myConn = new SqlConnection("Server=" + ServerCredential.ServerName + ";Initial Catalog=master;User Id=" + ServerCredential.UserId + ";Password=" + ServerCredential.Password + "");
            try
            {
                myConn.Open();
                DataSet dt = new DataSet();
                var cmd = "SELECT name FROM master.dbo.sysdatabases";
                SqlDataAdapter sda = new SqlDataAdapter(cmd, myConn);
                sda.Fill(dt);
                myConn.Close();
                DatabaseCustomList = DatasetToList(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in connection. \n \n" + ex.Message);
                log.Error("Invalid credentials | " + ex.Message);
                e.Result = ex;
            }
        }

        public List<string> DatasetToList(DataSet dt)
        {
            var DatabaseList = dt.Tables[0].AsEnumerable().ToList().ConvertAll(m => m.ItemArray[0].ToString());
            return DatabaseList;

        }

        private void idBtnSaveDatabaseList_Click(object sender, EventArgs e)
        {
            List<string> DatabaseList = new List<string>();
            foreach (var item in idListMasterDatabase.SelectedItems)
            {
                DatabaseList.Add(item.ToString());
            }
            if (SetDbParentList != null)
            {
                SetDbParentList(DatabaseList);
            }
            this.Close();
        }

    }
}
