namespace Accounting.Ui.Forms.MainApp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.transportModeMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransportModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idBtnNewInvoice = new System.Windows.Forms.Button();
            this.idBtnAddCustomer = new System.Windows.Forms.Button();
            this.idBtnAddItems = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyMasterToolStripMenuItem,
            this.customerMasterToolStripMenuItem,
            this.taxMasterToolStripMenuItem,
            this.itemMasterToolStripMenuItem,
            this.unitMasterToolStripMenuItem,
            this.vehicleMasterToolStripMenuItem,
            this.transportModeMasterToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // companyMasterToolStripMenuItem
            // 
            this.companyMasterToolStripMenuItem.Name = "companyMasterToolStripMenuItem";
            this.companyMasterToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.companyMasterToolStripMenuItem.Text = "Company Master";
            this.companyMasterToolStripMenuItem.Click += new System.EventHandler(this.companyMasterToolStripMenuItem_Click);
            // 
            // customerMasterToolStripMenuItem
            // 
            this.customerMasterToolStripMenuItem.Name = "customerMasterToolStripMenuItem";
            this.customerMasterToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.customerMasterToolStripMenuItem.Text = "Customer Master";
            this.customerMasterToolStripMenuItem.Click += new System.EventHandler(this.customerMasterToolStripMenuItem_Click);
            // 
            // taxMasterToolStripMenuItem
            // 
            this.taxMasterToolStripMenuItem.Name = "taxMasterToolStripMenuItem";
            this.taxMasterToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.taxMasterToolStripMenuItem.Text = "Tax Master";
            this.taxMasterToolStripMenuItem.Click += new System.EventHandler(this.taxMasterToolStripMenuItem_Click);
            // 
            // itemMasterToolStripMenuItem
            // 
            this.itemMasterToolStripMenuItem.Name = "itemMasterToolStripMenuItem";
            this.itemMasterToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.itemMasterToolStripMenuItem.Text = "Item Master";
            this.itemMasterToolStripMenuItem.Click += new System.EventHandler(this.itemMasterToolStripMenuItem_Click);
            // 
            // unitMasterToolStripMenuItem
            // 
            this.unitMasterToolStripMenuItem.Name = "unitMasterToolStripMenuItem";
            this.unitMasterToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.unitMasterToolStripMenuItem.Text = "Unit Master";
            this.unitMasterToolStripMenuItem.Click += new System.EventHandler(this.unitMasterToolStripMenuItem_Click);
            // 
            // vehicleMasterToolStripMenuItem
            // 
            this.vehicleMasterToolStripMenuItem.Name = "vehicleMasterToolStripMenuItem";
            this.vehicleMasterToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.vehicleMasterToolStripMenuItem.Text = "Vehicle  Master";
            this.vehicleMasterToolStripMenuItem.Click += new System.EventHandler(this.vehicleMasterToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.idBtnNewInvoice);
            this.panel1.Controls.Add(this.idBtnAddCustomer);
            this.panel1.Controls.Add(this.idBtnAddItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 100);
            this.panel1.TabIndex = 1;
            // 
            // transportModeMasterToolStripMenuItem
            // 
            this.transportModeMasterToolStripMenuItem.Name = "transportModeMasterToolStripMenuItem";
            this.transportModeMasterToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.transportModeMasterToolStripMenuItem.Text = "Transport Mode Master";
            this.transportModeMasterToolStripMenuItem.Click += new System.EventHandler(this.transportModeMasterToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.addCustomerToolStripMenuItem,
            this.addVehicleToolStripMenuItem,
            this.addUnitToolStripMenuItem,
            this.addTransportModeToolStripMenuItem,
            this.addTaxToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.addVehicleToolStripMenuItem_Click);
            // 
            // addUnitToolStripMenuItem
            // 
            this.addUnitToolStripMenuItem.Name = "addUnitToolStripMenuItem";
            this.addUnitToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.addUnitToolStripMenuItem.Text = "Add Unit";
            this.addUnitToolStripMenuItem.Click += new System.EventHandler(this.addUnitToolStripMenuItem_Click);
            // 
            // addTransportModeToolStripMenuItem
            // 
            this.addTransportModeToolStripMenuItem.Name = "addTransportModeToolStripMenuItem";
            this.addTransportModeToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.addTransportModeToolStripMenuItem.Text = "Add Transport Mode";
            this.addTransportModeToolStripMenuItem.Click += new System.EventHandler(this.addTransportModeToolStripMenuItem_Click);
            // 
            // addTaxToolStripMenuItem
            // 
            this.addTaxToolStripMenuItem.Name = "addTaxToolStripMenuItem";
            this.addTaxToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.addTaxToolStripMenuItem.Text = "Add Tax";
            this.addTaxToolStripMenuItem.Click += new System.EventHandler(this.addTaxToolStripMenuItem_Click);
            // 
            // idBtnNewInvoice
            // 
            this.idBtnNewInvoice.BackgroundImage = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Invoice1;
            this.idBtnNewInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.idBtnNewInvoice.Location = new System.Drawing.Point(274, 9);
            this.idBtnNewInvoice.Name = "idBtnNewInvoice";
            this.idBtnNewInvoice.Size = new System.Drawing.Size(110, 80);
            this.idBtnNewInvoice.TabIndex = 2;
            this.toolTip1.SetToolTip(this.idBtnNewInvoice, "New Invoice");
            this.idBtnNewInvoice.UseVisualStyleBackColor = true;
            this.idBtnNewInvoice.Click += new System.EventHandler(this.idBtnNewInvoice_Click);
            // 
            // idBtnAddCustomer
            // 
            this.idBtnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("idBtnAddCustomer.BackgroundImage")));
            this.idBtnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.idBtnAddCustomer.Location = new System.Drawing.Point(143, 9);
            this.idBtnAddCustomer.Name = "idBtnAddCustomer";
            this.idBtnAddCustomer.Size = new System.Drawing.Size(110, 80);
            this.idBtnAddCustomer.TabIndex = 1;
            this.toolTip1.SetToolTip(this.idBtnAddCustomer, "Customer Master");
            this.idBtnAddCustomer.UseVisualStyleBackColor = true;
            this.idBtnAddCustomer.Click += new System.EventHandler(this.idBtnAddCustomer_Click);
            // 
            // idBtnAddItems
            // 
            this.idBtnAddItems.BackColor = System.Drawing.SystemColors.Control;
            this.idBtnAddItems.BackgroundImage = global::Accounting.Ui.Forms.MainApp.Properties.Resources.Items4;
            this.idBtnAddItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.idBtnAddItems.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.idBtnAddItems.Location = new System.Drawing.Point(12, 9);
            this.idBtnAddItems.Name = "idBtnAddItems";
            this.idBtnAddItems.Size = new System.Drawing.Size(110, 80);
            this.idBtnAddItems.TabIndex = 0;
            this.idBtnAddItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.idBtnAddItems, "Item Master");
            this.idBtnAddItems.UseVisualStyleBackColor = false;
            this.idBtnAddItems.Click += new System.EventHandler(this.idBtnAddItems_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button idBtnAddItems;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button idBtnAddCustomer;
        private System.Windows.Forms.Button idBtnNewInvoice;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportModeMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransportModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaxToolStripMenuItem;
    }
}

