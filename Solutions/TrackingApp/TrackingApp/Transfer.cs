//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrackingApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transfer
    {
        public int Id { get; set; }
        public string TransferType { get; set; }
        public Nullable<System.DateTime> TransferStartDate { get; set; }
        public Nullable<System.DateTime> TransferLastDate { get; set; }
        public string TransferStatus { get; set; }
        public Nullable<int> OrderId { get; set; }
        public int WorkId { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Work Work { get; set; }
    }
}
