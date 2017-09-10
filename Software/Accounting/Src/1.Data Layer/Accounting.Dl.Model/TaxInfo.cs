using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Dl.Model
{
    public class TaxInfo
    {
        public TaxInfo()
        {
            ID = "0";
            SGST = "0";
            CGST = "0";
            IGST = "0";
        }
        public string ID { get; set; }
        public string SGST { get; set; }
        public string CGST { get; set; }
        public string IGST { get; set; }
    }
}
