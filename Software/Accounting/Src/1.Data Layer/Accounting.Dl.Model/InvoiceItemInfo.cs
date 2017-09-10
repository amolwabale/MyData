using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Dl.Model
{
    public class InvoiceItemInfo
    {
        public string Id { get; set; }
        public string InvoiceId { get; set; }
        public string Item { get; set; }
        public string HSN { get; set; }
        public string Quantity { get; set; }
        public string UOM { get; set; }
        public string TaxableAmount { get; set; }
        public string SGST   { get; set; }
        public string CGST { get; set; }
        public string IGST { get; set; }
        public string TotalAmount { get; set; }
    }
}
