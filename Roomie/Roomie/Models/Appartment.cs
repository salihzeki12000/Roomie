//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Roomie.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appartment()
        {
            this.ProfileLinkers = new HashSet<ProfileLinker>();
        }
    
        public int ID { get; set; }
        public decimal RentCost { get; set; }
        public string Description { get; set; }
        public int ProfileLinkerID { get; set; }
        public Nullable<int> PhotoID { get; set; }
    
        public virtual Photo Photo { get; set; }
        public virtual ProfileLinker ProfileLinker { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileLinker> ProfileLinkers { get; set; }
    }
}
