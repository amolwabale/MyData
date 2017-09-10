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
    public partial class MastersUnit : Form
    {
        public MastersUnit()
        {
            InitializeComponent();
          

        }

        public bool IsDgvRowsPresent()
        {
            bool Present = true;
            if (idDgvMasterUnit.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No record selected.", "Information");
                Present = false;
            }
            return Present;
        }

        private void MastersUnit_Load(object sender, EventArgs e)
        {
            DataTable dt = MastersBl.GetMasterUnitList();
            idDgvMasterUnit.DataSource = dt;
        }

        private void idBtnAdd_Click(object sender, EventArgs e)
        {
            var unit = idTxtUnit.Text.Trim();
            if (!string.IsNullOrEmpty(unit))
            {
                if (!MastersBl.IfUnitAlreadyExist(unit))
                {
                    MastersBl.AddNewUnit(unit);
                    DataTable dt = MastersBl.GetMasterUnitList();
                    idDgvMasterUnit.DataSource = dt;
                    idTxtUnit.Text = "";
                }
                else
                {
                    MessageBox.Show("Unit Already Exist.");
                }
            }
            else
            {
                MessageBox.Show("Please enter unit.");
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
                var rowIndex = idDgvMasterUnit.SelectedCells[0].RowIndex;
                var id = idDgvMasterUnit.Rows[rowIndex].Cells[0].Value.ToString();
                MastersBl.DeleteUnit(id);
                DataTable dt = MastersBl.GetMasterUnitList();
                idDgvMasterUnit.DataSource = dt;
            }
        }
    }
}
