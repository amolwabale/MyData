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
    
    public partial class OrderLineItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Gst { get; set; }
        public int TotalPrice { get; set; }
    
        public virtual MasterProduct MasterProduct { get; set; }
        public virtual Order Order { get; set; }
    }
}