//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TerminalApp.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class IncidenceStatusTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IncidenceStatusTbl()
        {
            this.Incidence = new HashSet<Incidence>();
        }
    
        public int Id { get; set; }
        public string IncidenceStatusName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidence> Incidence { get; set; }
    }
}
