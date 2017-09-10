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
    public partial class Items : Form
    {
        ItemInfo GlobalObjItemInfo;
        bool FormCancelButton = false;
        bool? InitFromMenu = null;

        public Items(ItemInfo ObjItemInfo = null, bool? MenuEdit = null)
        {
            InitializeComponent();
            GlobalObjItemInfo = ObjItemInfo;
            InitFromMenu = MenuEdit;
        }

        public void SetValueToTextBox()
        {
            idTxtItemName.Text = GlobalObjItemInfo.Name;
            idRtbDescription.Text = GlobalObjItemInfo.Description;
            idTxtPartNum.Text = GlobalObjItemInfo.PartNumber;
            idCmbUnit.Text = GlobalObjItemInfo.Unit;
            idTxtHsnCode.Text = GlobalObjItemInfo.Hsn;
            idTxtPrice.Text = GlobalObjItemInfo.Rate;
            idTxtWeight.Text = GlobalObjItemInfo.Weight;
            idTxtRemark.Text = GlobalObjItemInfo.Remark;
            idChkSgst.Checked = bool.Parse(GlobalObjItemInfo.SGST);
            idChkCgst.Checked = bool.Parse(GlobalObjItemInfo.CGST);
            idChkIgst.Checked = bool.Parse(GlobalObjItemInfo.IGST);
        }

        public ItemInfo GetValueFromTextBox()
        {
            var id = "";
            var ObjItemInfo = new ItemInfo();
            if (GlobalObjItemInfo != null)
                id = GlobalObjItemInfo.ID;
            ObjItemInfo.ID = id;
            ObjItemInfo.Name = idTxtItemName.Text.Trim();
            ObjItemInfo.Description = idRtbDescription.Text;
            ObjItemInfo.PartNumber = idTxtPartNum.Text.Trim();
            ObjItemInfo.Unit = idCmbUnit.Text;
            ObjItemInfo.Hsn = idTxtHsnCode.Text;
            ObjItemInfo.Rate = idTxtPrice.Text.Trim();
            ObjItemInfo.Weight = idTxtWeight.Text;
            ObjItemInfo.Remark = idTxtRemark.Text;
            ObjItemInfo.SGST = (idChkSgst.Checked)? "true" : "false";
            ObjItemInfo.CGST = (idChkCgst.Checked)? "true" : "false";
            ObjItemInfo.IGST = (idChkIgst.Checked)? "true" : "false";
            return ObjItemInfo;
        }


        private void idBtnCancel_Click(object sender, EventArgs e)
        {
            FormCancelButton = true;
            if (InitFromMenu != true)
            {
                MastersItem obj = new MastersItem();
                obj.Show();
            }
            this.Close();
        }

        public void FillUnitDropdowns()
        {
            List<string> ListUnit = new List<string>();
            ListUnit.Add("");
            DataTable dt = MastersBl.GetMasterUnitList();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var unit = dt.Rows[i][1].ToString();
                ListUnit.Add(unit);
            }
            idCmbUnit.DataSource = ListUnit;
        }

        private void Items_Load(object sender, EventArgs e)
        {
            FillUnitDropdowns();
            if (GlobalObjItemInfo != null)
            SetValueToTextBox();
        }

        private void idBtnSave_Click(object sender, EventArgs e)
        {
            var objItemInfo = GetValueFromTextBox();
            var ErrorCounter = 0;
            var ErrorMessage = "Following fields should not be empty \n\n";
            if (string.IsNullOrEmpty(objItemInfo.Name))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter Item Name \n";
            }
            if (string.IsNullOrEmpty(objItemInfo.Unit))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Select Unit \n";
            }
            if (string.IsNullOrEmpty(objItemInfo.Rate))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please enter price \n";
            }
            if (!string.IsNullOrEmpty(objItemInfo.Rate))
            {
                float temp = 0;
                var str = objItemInfo.Rate.ToString();
                var fValue = float.TryParse(str, out temp);
                if (fValue == false)
                {
                    ErrorCounter++;
                    ErrorMessage += ErrorCounter.ToString() + "] " + "Price should be numeric value. \n";
                }
            }
            if (ErrorCounter > 0)
            {
                MessageBox.Show(ErrorMessage, "Warning !...");
                return;
            }

            

            if (string.IsNullOrEmpty(objItemInfo.ID))
            {
                var IsPresent = ItemsBl.IsItemAlreadyPresent(objItemInfo.Name);
                if (IsPresent == true)
                {
                    MessageBox.Show("Item already Exist with Name : " + objItemInfo.Name, "Warning !...");
                    return;
                }
                ItemsBl.SaveItem(objItemInfo);
            }
            else
                ItemsBl.UpdateItem(objItemInfo);

            FormCancelButton = true;
            if (InitFromMenu != true)
            {
                MastersItem obj = new MastersItem();
                obj.Show();
            }
            this.Close();
        }

        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormCancelButton == false)
            {
                if (InitFromMenu != true)
                {
                    MastersItem obj = new MastersItem();
                    obj.Show();
                }
            }
        }
    }
}
