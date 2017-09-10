using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Dl.Model
{
    public class CustomerInfo
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyOwnerName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string GST { get; set; }
        public string CIN { get; set; }
        public string PAN { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
    }
}
