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
    public partial class Vehicle : Form
    {
        bool FormCancelButton = false;
        VehicleInfo GlobalObjVehicleInfo;
        bool? InitFromMenu = null;

        public Vehicle(VehicleInfo objVehicleInfo = null, bool? MenuEdit = null)
        {
            InitFromMenu = MenuEdit;
            InitializeComponent();
            GlobalObjVehicleInfo = objVehicleInfo;
        }

        private void idBtnSave_Click(object sender, EventArgs e)
        {
            var objVehicleInfo = GetValueFromTextBox();
            var ErrorCounter = 0;
            var ErrorMessage = "Following fields should not be empty \n\n";
            if (string.IsNullOrEmpty(objVehicleInfo.VehicleNum))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please Enter Vehicle Number \n";
            }
            if (string.IsNullOrEmpty(objVehicleInfo.VehicleBrand))
            {
                ErrorCounter++;
                ErrorMessage += ErrorCounter.ToString() + "] " + "Please enter Vehicle Brand / Type\n";
            }
            if (ErrorCounter > 0)
            {
                MessageBox.Show(ErrorMessage, "Warning !...");
                return;
            }

            if (string.IsNullOrEmpty(objVehicleInfo.ID))
            {
                var IsPresent = VehicleBl.IsVehicleAlreadyPresent(objVehicleInfo.VehicleNum);
                if (IsPresent == true)
                {
                    MessageBox.Show("Item already Exist with Name : " + objVehicleInfo.VehicleNum, "Warning !...");
                    return;
                }
                VehicleBl.SaveVehicle(objVehicleInfo);
            }
            else
                VehicleBl.UpdateVehicle(objVehicleInfo);

            FormCancelButton = true;
            if (InitFromMenu != true)
            {
                MastersVehicle obj = new MastersVehicle();
                obj.Show();
            }
            this.Close();
        }

        private void idBtnCancel_Click(object sender, EventArgs e)
        {
            FormCancelButton = true;
            if (InitFromMenu != true)
            {
                var obj = new MastersVehicle();
                obj.Show();
            }
            this.Close();
        }

        private void Vehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FormCancelButton == false)
            {
                if (InitFromMenu != true)
                {
                    var obj = new MastersVehicle();
                    obj.Show();
                }
            }
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            if (GlobalObjVehicleInfo != null)
                SetValueToTextBox();
        }

        public void SetValueToTextBox()
        {
            idTxtVehicleNumber.Text = GlobalObjVehicleInfo.VehicleNum;
            idTxtVehicleBrand.Text = GlobalObjVehicleInfo.VehicleBrand;
            idTxtDriverName.Text = GlobalObjVehicleInfo.DriverName;
            idTxtContactNumber.Text = GlobalObjVehicleInfo.ContactNum;
        }

        public VehicleInfo GetValueFromTextBox()
        {
            var id = "";
            var ObjVehicleInfo = new VehicleInfo();
            if (GlobalObjVehicleInfo != null)
                id = GlobalObjVehicleInfo.ID;
            ObjVehicleInfo.ID = id;
            ObjVehicleInfo.VehicleNum = idTxtVehicleNumber.Text;
            ObjVehicleInfo.VehicleBrand = idTxtVehicleBrand.Text;
            ObjVehicleInfo.DriverName = idTxtDriverName.Text;
            ObjVehicleInfo.ContactNum = idTxtContactNumber.Text;
            return ObjVehicleInfo;
        }

    }
}
