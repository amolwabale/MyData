using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Dl.Model
{
    public class CompanyInfo
    {
        public CompanyInfo()
        {
            Id = "0";
        }
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyOwnerName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Gst { get; set; }
        public string Cin { get; set; }
        public string Pan { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public string BankName { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankIfscNumber { get; set; }
        public string CompanyLogo { get; set; }
    }
}
