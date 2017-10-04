//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IncubXpertInvoicing.Dl.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderLineItems = new HashSet<OrderLineItem>();
        }
    
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string OrderDate { get; set; }
        public string ScheduledDeliveryDate { get; set; }
        public int TotalOrderPrice { get; set; }
        public int TotalGst { get; set; }
    
        public virtual MasterCustomer MasterCustomer { get; set; }
        public virtual ICollection<OrderLineItem> OrderLineItems { get; set; }
    }
}
