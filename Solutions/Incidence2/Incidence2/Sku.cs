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
    
    public partial class Sku
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sku()
        {
            this.Incidence = new HashSet<Incidence>();
            this.Order = new HashSet<Order>();
            this.Inbound = new HashSet<Inbound>();
        }
    
        public int Id { get; set; }
        public int Sku1 { get; set; }
        public string SkuType { get; set; }
        public string SkuBrand { get; set; }
        public Nullable<int> SkuPiece { get; set; }
        public Nullable<int> SkuTypeId { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidence> Incidence { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inbound> Inbound { get; set; }
        public virtual SkuType SkuType1 { get; set; }
    }
}
