//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cqs.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public System.DateTime PlacedOn { get; set; }
        public Nullable<System.DateTime> DispatchedOn { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
