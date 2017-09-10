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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void idBtnAddItems_Click(object sender, EventArgs e)
        {
            MastersItem objmi = new MastersItem();
            objmi.Show();
        }

        private void unitMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MastersUnit objmu = new MastersUnit();
            objmu.Show();
        }

        private void idBtnAddCustomer_Click(object sender, EventArgs e)
        {
            MastersCustomers objmc = new MastersCustomers();
            objmc.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MastersItem objmi = new MastersItem();
            objmi.Show();
        }

        private void companyMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MastersCompany objmc = new MastersCompany();
            objmc.Show();
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MastersCustomers objmc = new MastersCustomers();
            objmc.Show();
        }

        private void taxMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MastersTax objt = new MastersTax();
            objt.Show();
        }

        private void vehicleMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new MastersVehicle();
            obj.Show();
        }

        private void transportModeMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new MastersTransportModes();
            obj.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items obj = new Items(null,true);
            obj.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers objCust = new Customers(null, true);
            objCust.Show();
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new Vehicle(null, true);
            obj.Show();
        }

        private void addUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MastersUnit objmu = new MastersUnit();
            objmu.Show();
        }

        private void addTransportModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new MastersTransportModes();
            obj.Show();
        }

        private void addTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MastersTax objt = new MastersTax();
            objt.Show();
        }

        private void idBtnNewInvoice_Click(object sender, EventArgs e)
        {
            var obj = new Invoice();
            obj.Show();
        }
    }
}
