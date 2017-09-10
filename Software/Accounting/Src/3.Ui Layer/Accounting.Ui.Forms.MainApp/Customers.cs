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
    public partial class Customers : Form
    {

        CustomerInfo GlobalObjCustomerInfo;
        bool FormCancelButton = false;
        bool? InitFromMenu = null;

        public Customers(CustomerInfo objCustomerInfo = null, bool? MenuInit = null)
        {
            GlobalObjCustomerInfo = objCustomerInfo;
            InitFromMenu = MenuInit;
            InitializeComponent();
        }

        private void idBtnCancel_Click(object sender, EventArgs e)
        {
            FormCancelButton = true;
            if (InitFromMenu != true)
            {
                MastersCustomers obj = new MastersCustomers();
                obj.Show();
            }
            this.Close();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            FillTextBox();
        }

        public CustomerInfo GetCustomerInfoFromTextBox()
        {
            var id="";
            if(GlobalObjCustomerInfo != null)
                id = GlobalObjCustomerInfo.Id;
            var objCustInfo = new CustomerInfo();
            objCustInfo.Id = id;
            objCustInfo.CompanyName = idTxtCompanyName.Text;
            objCustInfo.CompanyOwnerName = idTxtCompanyOwnerName.Text;
            objCustInfo.Address = idRtbAddress.Text;
            objCustInfo.Contact = idTxtContact.Text;
            objCustInfo.GST = idTxtGst.Text;
            objCustInfo.CIN = idTxtCin.Text;
            objCustInfo.PAN = idTxtPan.Text;
            objCustInfo.StateName = idTxtStateName.Text;
            objCustInfo.StateCode = idTxtStateCode.Text;
            return objCustInfo;
        }

        private void idBtnSave_Click(object sender, EventArgs e)
        {
            var objCustInfo = GetCustomerInfoFromTextBox();
            var ErrorCounter = 0;
            var ErrorMessage = "Following fields should not be empty \n\n";
            if (string.IsNullOrEmpty(objCustInfo.CompanyName))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter Company Name \n";
            }

            if (string.IsNullOrEmpty(objCustInfo.Address))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter Address \n";
            }

            if (string.IsNullOrEmpty(objCustInfo.Contact))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter Contact \n";
            }

            if (string.IsNullOrEmpty(objCustInfo.StateName))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter State Name \n";
            }

            if (ErrorCounter > 0)
            {
                MessageBox.Show(ErrorMessage, "Warning !...");
                return;
            }

            

            if (string.IsNullOrEmpty(objCustInfo.Id))
            {
                var dt = MastersBl.GetFilteredCustomerList("CompanyName", idTxtCompanyName.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Customer with company name '" + idTxtCompanyName.Text.Trim() + "' already exist.");
                    return;
                }
                CustomerBl.SaveCustomer(objCustInfo);
            }
            else
                CustomerBl.UpdateCustomer(objCustInfo);
            FormCancelButton = true;
            if (InitFromMenu != true)
            {
                MastersCustomers obj = new MastersCustomers();
                obj.Show();
            }
            this.Close();
        }

        public void FillTextBox()
        {
            if (GlobalObjCustomerInfo != null)
            {
                idTxtCompanyName.Text = GlobalObjCustomerInfo.CompanyName;
                idTxtCompanyOwnerName.Text = GlobalObjCustomerInfo.CompanyOwnerName;
                idRtbAddress.Text = GlobalObjCustomerInfo.Address;
                idTxtContact.Text = GlobalObjCustomerInfo.Contact;
                idTxtGst.Text = GlobalObjCustomerInfo.GST;
                idTxtCin.Text = GlobalObjCustomerInfo.CIN;
                idTxtPan.Text = GlobalObjCustomerInfo.PAN;
                idTxtStateName.Text = GlobalObjCustomerInfo.StateName;
                idTxtStateCode.Text = GlobalObjCustomerInfo.StateCode;
            }
        }

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormCancelButton == false)
            {
                if (InitFromMenu != true)
                {
                    MastersCustomers obj = new MastersCustomers();
                    obj.Show();
                }
            }
        }


    }
}
