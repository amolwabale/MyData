using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Dl.Model
{
    public class ItemInfo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public string Unit { get; set; }
        public string Hsn { get; set; }
        public string Rate { get; set; }
        public string Weight { get; set; }
        public string Remark { get; set; }
        public string SGST { get; set; }
        public string CGST { get; set; }
        public string IGST { get; set; }
    }
}
