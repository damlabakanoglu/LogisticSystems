//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Incidence2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incidence
    {
        public int Id { get; set; }
        public Nullable<int> Sku { get; set; }
        public string BrandName { get; set; }
        public string Quadrant { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string OrderType { get; set; }
        public string IncidenceStatus { get; set; }
        public Nullable<System.DateTime> IncidenceDate { get; set; }
        public Nullable<int> UserCode { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> SkuId { get; set; }
        public Nullable<int> IncıdenceStatusId { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual IncidenceStatusTbl IncidenceStatusTbl { get; set; }
        public virtual Order Order { get; set; }
        public virtual Sku Sku1 { get; set; }
        public virtual Users Users { get; set; }
    }
}
