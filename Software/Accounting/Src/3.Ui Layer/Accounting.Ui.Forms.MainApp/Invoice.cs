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
    public partial class Invoice : Form
    {
        InvoiceMasterInfo GlobalObjInvoiceMasterInfo;
        List<InvoiceItemInfo> GlobalObjInvoiceItemInfo;

        public Invoice(InvoiceMasterInfo objInvoiceMasterInfo = null, List<InvoiceItemInfo> ObjInvoiceItemInfo = null)
        {
            GlobalObjInvoiceMasterInfo = objInvoiceMasterInfo;
            GlobalObjInvoiceItemInfo = ObjInvoiceItemInfo;
            InitializeComponent();
        }

        public void FillBilledToCustomerCmb()
        {
            var dt = MastersBl.GetMasterCustomerList();
            Dictionary<string, string> ListUnit = new Dictionary<string, string>();
            ListUnit.Add("", "");
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var id = dt.Rows[i]["ID"].ToString();
                var name = dt.Rows[i]["CompanyName"].ToString();
                ListUnit.Add(id, name);
            }
            idCmbBilledTo.DataSource = new BindingSource(ListUnit, null);
            idCmbBilledTo.DisplayMember = "Value";
            idCmbBilledTo.ValueMember = "Key";
            idCmbShippedTo.DataSource = new BindingSource(ListUnit, null);
            idCmbShippedTo.DisplayMember = "Value";
            idCmbShippedTo.ValueMember = "Key";
        }

        public void FillItemsCmb()
        {
            var dt = MastersBl.GetMasterItemList();
            Dictionary<string, string> ListUnit = new Dictionary<string, string>();
            ListUnit.Add("", "");
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var id = dt.Rows[i]["ID"].ToString();
                var name = dt.Rows[i]["Name"].ToString();
                ListUnit.Add(id, name);
            }
            idCmbAddItem.DataSource = new BindingSource(ListUnit, null);
            idCmbAddItem.DisplayMember = "Value";
            idCmbAddItem.ValueMember = "Key";
        }

        public void FillTransportModeCmb()
        {
            var dt = MastersBl.GetMasterTransportModeList();
            Dictionary<string, string> ListUnit = new Dictionary<string, string>();
            ListUnit.Add("", "");
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var id = dt.Rows[i]["ID"].ToString();
                var name = dt.Rows[i]["Mode"].ToString();
                ListUnit.Add(id, name);
            }
            idCmbTransportMode.DataSource = new BindingSource(ListUnit, null);
            idCmbTransportMode.DisplayMember = "Value";
            idCmbTransportMode.ValueMember = "Key";
        }

        public void FillVehicleCmb()
        {
            var dt = MastersBl.GetMasterVehicleList();
            Dictionary<string, string> ListUnit = new Dictionary<string, string>();
            ListUnit.Add("", "");
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var id = dt.Rows[i]["ID"].ToString();
                var name = dt.Rows[i]["VehicleNum"].ToString();
                ListUnit.Add(id, name);
            }
            idCmbVehicleNum.DataSource = new BindingSource(ListUnit, null);
            idCmbVehicleNum.DisplayMember = "Value";
            idCmbVehicleNum.ValueMember = "Key";
        }


        public void InitDgv()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Sr.no");
            dt.Columns.Add("Item");
            dt.Columns.Add("HSN");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("UOM");
            dt.Columns.Add("TaxableAmount");
            dt.Columns.Add("SGST(Rs)");
            dt.Columns.Add("CGST(Rs)");
            dt.Columns.Add("IGST(Rs)");
            dt.Columns.Add("TotalAmount");
            idDgvInvoice.DataSource = dt;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            InitDgv();
            FillBilledToCustomerCmb();
            FillItemsCmb();
            FillTransportModeCmb();
            FillVehicleCmb();
        }

        private void idBtnAdd_Click(object sender, EventArgs e)
        {
            if (idCmbAddItem.SelectedValue != null)
            {
                var itemId = idCmbAddItem.SelectedValue.ToString();
                var Qty = idTxtQty.Text;
                UpdateInvoiceDgv(itemId, Qty);
            }
            else
            {
                MessageBox.Show("Please select value from list", "Warning ! ...");
            }
        }

        public void UpdateInvoiceDgv(string ItemId, string Qty)
        {
            var GstInfo = MastersBl.GetTaxInfo();
            var ObjItemInfo = ItemsBl.GetItemPerId(ItemId);
            DataTable dt = new DataTable();
            dt = idDgvInvoice.DataSource as DataTable;
            DataRow dtr = dt.NewRow();

            var ErrorCounter = 0;
            var ErrorMessage = "Following fields should not be empty \n\n";
            if (string.IsNullOrEmpty(ItemId))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Select Item \n";
            }

            if (string.IsNullOrEmpty(Qty))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter Qty \n";
            }

            if (!string.IsNullOrEmpty(Qty))
            {
                var temp = 0;
                var result = int.TryParse(Qty, out temp);
                if (result == false)
                {
                    ErrorCounter++;
                    ErrorMessage += ErrorCounter.ToString() + "] " + "Please enter quantity in numeric format \n";
                }
            }

            var rowCount = dt.Rows.Count;
            for (var i = 0; i < rowCount; i++)
            {
                var ExistingValue = dt.Rows[i]["Item"].ToString().Trim();
                if (ExistingValue == ObjItemInfo.Name)
                {
                    ErrorCounter++;
                    ErrorMessage += ErrorCounter.ToString() + "] " + "Item already added. \n";
                }
            }

            if (ErrorCounter > 0)
            {
                MessageBox.Show(ErrorMessage, "Warning !...");
                return;
            }

            var SrNo = dt.Rows.Count;
            dtr["Sr.no"] = SrNo + 1;

            var ItemName = ObjItemInfo.Name;
            if (!string.IsNullOrEmpty(ObjItemInfo.PartNumber))
                ItemName += " [ " + ObjItemInfo.PartNumber + " ]";
            dtr["Item"] = ItemName;
            dtr["Quantity"] = Qty;
            dtr["UOM"] = ObjItemInfo.Unit;
            dtr["HSN"] = ObjItemInfo.Hsn;

            double PerPrice = double.Parse(ObjItemInfo.Rate);
            var TaxableAmount = PerPrice * double.Parse(Qty);
            dtr["TaxableAmount"] = TaxableAmount;

            if (ObjItemInfo.SGST == "true")
            {
                double sgstTaxAmount = 0;
                double sgstRate = double.Parse(GstInfo.SGST);
                if (sgstRate > 0)
                {
                    sgstTaxAmount = TaxableAmount * (sgstRate / 100);
                    dtr["SGST(Rs)"] = sgstTaxAmount;
                }
                else
                {
                    dtr["SGST(Rs)"] = "0";
                }
            }
            else
            {
                dtr["CGST(Rs)"] = "0";
            }

            if (ObjItemInfo.CGST == "true")
            {
                double cgstTaxAmount = 0;
                double cgstRate = double.Parse(GstInfo.CGST);
                if (cgstRate > 0)
                {
                    cgstTaxAmount = TaxableAmount * (cgstRate / 100);
                    dtr["CGST(Rs)"] = cgstTaxAmount;
                }
                else
                {
                    dtr["CGST(Rs)"] = "0";
                }
            }
            else
            {
                dtr["CGST(Rs)"] = "0";
            }

            if (ObjItemInfo.IGST == "true")
            {
                double igstTaxAmount = 0;
                double igstRate = double.Parse(GstInfo.CGST);
                if (igstRate > 0)
                {
                    igstTaxAmount = TaxableAmount * (igstRate / 100);
                    dtr["IGST(Rs)"] = igstTaxAmount;
                }
                else
                {
                    dtr["IGST(Rs)"] = "0";
                }
            }
            else
            {
                dtr["IGST(Rs)"] = "0";
            }

            double totalAmount = TaxableAmount + double.Parse(dtr["IGST(Rs)"].ToString()) +
                                    double.Parse(dtr["CGST(Rs)"].ToString()) +
                                    double.Parse(dtr["SGST(Rs)"].ToString());
            dtr["TotalAmount"] = totalAmount;
            dt.Rows.Add(dtr);

            idTxtQty.Text = "";
            idCmbAddItem.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public bool IsDgvRowsPresent()
        {
            bool Present = true;
            if (idDgvInvoice.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No record selected.", "Information");
                Present = false;
            }
            return Present;
        }

        private void idBtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (IsDgvRowsPresent())
            {
                var rowIndex = idDgvInvoice.SelectedCells[0].RowIndex;
                idDgvInvoice.Rows.RemoveAt(rowIndex);

                for (var i = 0; i < idDgvInvoice.Rows.Count; i++)
                {
                    var id = idDgvInvoice.Rows[i].Cells["Sr.no"].Value = i + 1;
                }
            }
        }

        private void idBtnSave_Click(object sender, EventArgs e)
        {
            

            var ObjInvoiceMaster = GetValueFromTextBoxInvoiceMaster();
            var ObjInvoiceItem = GetInvoiceItems();

            InvoiceBl.SaveCustomer(ObjInvoiceMaster);


            var ErrorCounter = 0;
            var ErrorMessage = "Following fields should not be empty \n\n";
            if (string.IsNullOrEmpty(ObjInvoiceMaster.BilledTo))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please selecct Billed To \n";
            }
            if (string.IsNullOrEmpty(ObjInvoiceMaster.TransportMode))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please select Transport Mode \n";
            }

            if (string.IsNullOrEmpty(ObjInvoiceMaster.PoNum))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please enter Po. No. \n";
            }

            if (idDgvInvoice.Rows.Count == 0)
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please add items\n";
            }

            if (ErrorCounter > 0)
            {
                MessageBox.Show(ErrorMessage, "Warning !...");
                return;
            }

            //if(string.IsNullOrEmpty(ObjInvoiceMaster.ID))

        }

        private InvoiceMasterInfo GetValueFromTextBoxInvoiceMaster()
        {
            var objInvoiceMasterInfo = new InvoiceMasterInfo();
            var id = "";
            var ObjItemInfo = new ItemInfo();
            if (GlobalObjInvoiceMasterInfo != null)
                id = GlobalObjInvoiceMasterInfo.ID;
            objInvoiceMasterInfo.ID = id;
            objInvoiceMasterInfo.InvoiceDate = idDpInvoiceDate.Text;
            objInvoiceMasterInfo.BilledTo = idCmbBilledTo.Text;
            objInvoiceMasterInfo.ShippedTo = idCmbShippedTo.Text;
            objInvoiceMasterInfo.Discount = idTxtDiscount.Text;
            objInvoiceMasterInfo.OtherCharges = idTxtOtherCharges.Text;
            objInvoiceMasterInfo.TransportMode = idCmbTransportMode.Text;
            objInvoiceMasterInfo.VehicleNumber = idCmbVehicleNum.Text;
            objInvoiceMasterInfo.PoNum = idTxtPoNo.Text;
            objInvoiceMasterInfo.PoDate = idDpPoDate.Text;
            return objInvoiceMasterInfo;
        }

        private List<InvoiceItemInfo> GetInvoiceItems()
        {
            var a = GlobalObjInvoiceItemInfo;
            var ListObjInvoiceItemInfo = new List<InvoiceItemInfo>();
            DataTable dt = new DataTable();
            dt = idDgvInvoice.DataSource as DataTable;

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var tempList = new InvoiceItemInfo();
                if (GlobalObjInvoiceItemInfo != null)
                {
                    if (i < GlobalObjInvoiceItemInfo.Count)
                    {
                        tempList.InvoiceId = GlobalObjInvoiceItemInfo[i].Id;
                    }
                }

                tempList.Item = dt.Rows[i]["Item"].ToString();
                tempList.HSN = dt.Rows[i]["HSN"].ToString();
                tempList.Quantity = dt.Rows[i]["Quantity"].ToString();
                tempList.UOM = dt.Rows[i]["UOM"].ToString();
                tempList.TaxableAmount = dt.Rows[i]["TaxableAmount"].ToString();
                tempList.SGST = dt.Rows[i]["SGST(Rs)"].ToString();
                tempList.CGST = dt.Rows[i]["CGST(Rs)"].ToString();
                tempList.IGST = dt.Rows[i]["IGST(Rs)"].ToString();
                tempList.TotalAmount = dt.Rows[i]["TotalAmount"].ToString();
                ListObjInvoiceItemInfo.Add(tempList);
            }
            return ListObjInvoiceItemInfo;
        }

    }
}
