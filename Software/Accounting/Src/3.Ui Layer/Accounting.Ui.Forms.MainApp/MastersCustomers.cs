using Accounting.Bl;
using Accounting.Dl.Model;
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
    public partial class MastersCustomers : Form
    {
        public delegate void SetEditModeCallBack(CustomerInfo objCustomerInfo);
        public SetEditModeCallBack ObjDelEditMode;
        public MastersCustomers()
        {
            InitializeComponent();
        }

        private void MastersCustomers_Load(object sender, EventArgs e)
        {

            RefreshDgv();
        }

        private void idBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idBtnAdd_Click(object sender, EventArgs e)
        {
            Customers objCust = new Customers();
            objCust.Show();
            this.Close();
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
            var dt = MastersBl.GetFilteredCustomerList(ColumnName, Val);
            idDgvMastersCustomer.DataSource = dt;
            if (dt.Rows.Count == 0)
                MessageBox.Show("No record found", "Information");
        }

        private void idBtnRefresh_Click(object sender, EventArgs e)
        {
            idTxtSearch.Text = "";
            idCmbSearchParam.SelectedIndex = -1;
            RefreshDgv();
        }

        private void idTxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                idBtnSearch_Click(sender, e);
            }
        }

        public void RefreshDgv()
        {
            var dt = MastersBl.GetMasterCustomerList();
            idDgvMastersCustomer.DataSource = dt;
        }

        private void idBtnEdit_Click(object sender, EventArgs e)
        {
            if (IsDgvRowsPresent())
            {
                var rowIndex = idDgvMastersCustomer.SelectedCells[0].RowIndex;
                var id = idDgvMastersCustomer.Rows[rowIndex].Cells[0].Value.ToString();
                var ObjCustInfo = CustomerBl.GetCustomerPerId(id);

                Customers obj = new Customers(ObjCustInfo);
                obj.Show();
                this.Close();
            }
        }
        public bool IsDgvRowsPresent()
        {
            bool Present = true;
            if (idDgvMastersCustomer.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No record selected.", "Information");
                Present = false;
            }
            return Present;
        }
        private void idBtnDelete_Click(object sender, EventArgs e)
        {
            if (IsDgvRowsPresent())
            {
                var rowIndex = idDgvMastersCustomer.SelectedCells[0].RowIndex;
                var id = idDgvMastersCustomer.Rows[rowIndex].Cells[0].Value.ToString();
                var Customer = idDgvMastersCustomer.Rows[rowIndex].Cells[1].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure to delete customer : " + Customer + "\nThe record will be permanently deleted", "Delete Warning !...", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CustomerBl.DeleteCustomer(id);
                    RefreshDgv();
                }
            }
        }

    }
}
