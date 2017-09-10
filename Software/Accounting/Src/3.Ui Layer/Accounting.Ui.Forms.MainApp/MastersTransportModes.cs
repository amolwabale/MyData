using Accounting.Bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounting.Ui.Forms.MainApp
{
    public partial class MastersTransportModes : Form
    {
        public MastersTransportModes()
        {
            InitializeComponent();
        }

        public void RefreshDgv()
        {
            DataTable dt = MastersBl.GetMasterTransportModeList();
            idDgvMasterTransportMode.DataSource = dt;
        }

        public bool IsDgvRowsPresent()
        {
            bool Present = true;
            if (idDgvMasterTransportMode.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No record selected.", "Information");
                Present = false;
            }
            return Present;
        }

        private void MastersTransportModes_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void idBtnAdd_Click(object sender, EventArgs e)
        {
            var Mode = idTxtTransportMode.Text.Trim();
            if (!string.IsNullOrEmpty(Mode))
            {
                if (!MastersBl.IfTransportModeAlreadyExist(Mode))
                {
                    MastersBl.AddNewMode(Mode);
                    RefreshDgv();
                    idTxtTransportMode.Text = "";
                }
                else
                {
                    MessageBox.Show("Transport Mode Already Exist.");
                }
            }
            else
            {
                MessageBox.Show("Please enter Transport Mode.");
            }
        }

        private void idBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idBtnDelete_Click(object sender, EventArgs e)
        {
            if (IsDgvRowsPresent())
            {
                var rowIndex = idDgvMasterTransportMode.SelectedCells[0].RowIndex;
                var id = idDgvMasterTransportMode.Rows[rowIndex].Cells[0].Value.ToString();
                MastersBl.DeleteMode(id);
                RefreshDgv();
            }
        }
    }
}
