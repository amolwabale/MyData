using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Dl.Model
{
    public class InvoiceMasterInfo
    {
        public string ID { get; set; }
        public string InvoiceDate { get; set; }
        public string BilledTo { get; set; }
        public string ShippedTo { get; set; }
        public string Discount { get; set; }
        public string OtherCharges { get; set; }
        public string TransportMode { get; set; }
        public string VehicleNumber { get; set; }
        public string PoNum { get; set; }
        public string PoDate { get; set; }
    }
}
