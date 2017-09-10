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
    public partial class MastersVehicle : Form
    {
        
        public MastersVehicle()
        {
            InitializeComponent();
        }

        private void idBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idBtnAdd_Click(object sender, EventArgs e)
        {
            var obj = new Vehicle();
            obj.Show();
            this.Close();
        }
        public void RefreshDgv()
        {
            var dt = MastersBl.GetMasterVehicleList();
            idDgvMastersVehicle.DataSource = dt;
        }
        private void MastersVehicle_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void idBtnEdit_Click(object sender, EventArgs e)
        {
            if (IsDgvRowsPresent())
            {
                var rowIndex = idDgvMastersVehicle.SelectedCells[0].RowIndex;
                var id = idDgvMastersVehicle.Rows[rowIndex].Cells[0].Value.ToString();
                var ObjVehicleInfo = VehicleBl.GetVehiclePerId(id);
                var obj = new Vehicle(ObjVehicleInfo);
                obj.Show();
                this.Close();
            }
        }

        private void idBtnDelete_Click(object sender, EventArgs e)
        {
            if (IsDgvRowsPresent())
            {
                var rowIndex = idDgvMastersVehicle.SelectedCells[0].RowIndex;
                var id = idDgvMastersVehicle.Rows[rowIndex].Cells[0].Value.ToString();
                var Vehicle = idDgvMastersVehicle.Rows[rowIndex].Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete customer : " + Vehicle + "\nThe record will be permanently deleted", "Delete Warning !...", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    VehicleBl.DeleteVehicle(id);
                    RefreshDgv();
                }
            }
        }

        private void idBtnSearch_Click(object sender, EventArgs e)
        {
            var ColumnName = idCmbSearchParam.Text;
            var Val = idTxtSearch.Text;
            var ErrorMessage = "Folowing inputs are required \n\n";
            var ErrorCounter = 0;

            if (string.IsNullOrEmpty(ColumnName))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Select Filter \n";
            }

            if (string.IsNullOrEmpty(Val))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Enter search parameter";
            }

            if (ErrorCounter > 0)
            {
                MessageBox.Show(ErrorMessage, "Warning !...");
                return;
            }
            var dt = MastersBl.GetFilteredVehicleList(ColumnName, Val);
            idDgvMastersVehicle.DataSource = dt;
            if (dt.Rows.Count == 0)
                MessageBox.Show("No record found", "Information");
        }

        private void idBtnRefresh_Click(object sender, EventArgs e)
        {
            idTxtSearch.Text = "";
            idCmbSearchParam.SelectedIndex = -1;
            RefreshDgv();
        }

        public bool IsDgvRowsPresent()
        {
            bool Present = true;
            if (idDgvMastersVehicle.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No record selected.", "Information");
                Present = false;
            }
            return Present;
        }
    }
}
