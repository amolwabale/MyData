using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace IncubXpertInvoicing.Dl.Context
{
    [MetadataTypeAttribute(typeof(MasterCustomer.MasterCustomerEmd))]
    public partial class MasterCustomer
    {
        
        internal sealed class MasterCustomerEmd
        {
            [Obsolete]
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

            [Required]
            public string Address { get; set; }
            public string City { get; set; }
            public string Pincode { get; set; }

            [Required]
            public string ContactNo { get; set; }

            [Required]
            public string EmailId { get; set; }
        }
    }
}
