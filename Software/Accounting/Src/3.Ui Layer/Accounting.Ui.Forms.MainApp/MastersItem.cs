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
    public partial class MastersItem : Form
    {
        public MastersItem()
        {
            InitializeComponent();
        }

        public void ManipulateDtValue(DataTable dt)
        {
            List<string> TaxList = new List<string>() { "SGST", "CGST", "IGST" };
            for(var i = 0; i< dt.Rows.Count; i++)
            {
                foreach (var item in TaxList)
                {
                    if (dt.Rows[i][item].ToString() == "true")
                        dt.Rows[i][item] = "Applicable";
                    else
                        dt.Rows[i][item] = "Not Applicable";
                }
            }
        }

        public void RefreshDgv()
        {
            DataTable dt = MastersBl.GetMasterItemList();
            ManipulateDtValue(dt);
            idDgvMastersItem.DataSource = dt;
        }

        private void MastersItem_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }

        private void idBtnAdd_Click(object sender, EventArgs e)
        {
            Items obj = new Items();
            obj.Show();
            this.Close();
        }

        private void idBtnEdit_Click(object sender, EventArgs e)
        {
            if (IsDgvRowsPresent())
            {
                var rowIndex = idDgvMastersItem.SelectedCells[0].RowIndex;
                var id = idDgvMastersItem.Rows[rowIndex].Cells[0].Value.ToString();
                var ObjCustInfo = ItemsBl.GetItemPerId(id);

                var obj = new Items(ObjCustInfo);
                obj.Show();
                this.Close();
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
                var rowIndex = idDgvMastersItem.SelectedCells[0].RowIndex;
                var id = idDgvMastersItem.Rows[rowIndex].Cells[0].Value.ToString();
                var item = idDgvMastersItem.Rows[rowIndex].Cells["Name"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete item : " + item + "\nThe item will be permanently deleted", "Delete Warning !...", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ItemsBl.DeleteItem(id);
                    RefreshDgv();
                }
            }
        }

        public bool IsDgvRowsPresent()
        {
            bool Present = true;
            if (idDgvMastersItem.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No record selected.", "Information");
                Present = false;
            }
            return Present;
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
            var dt = MastersBl.GetFilteredItemsList(ColumnName, Val);
            idDgvMastersItem.DataSource = dt;
            if (dt.Rows.Count == 0)
                MessageBox.Show("No record found", "Information");
        }

        private void idBtnRefresh_Click(object sender, EventArgs e)
        {
            idTxtSearch.Text = "";
            idCmbSearchParam.SelectedIndex = -1;
            RefreshDgv();
        }

    }
}
