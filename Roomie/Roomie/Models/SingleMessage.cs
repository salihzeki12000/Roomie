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
    
    public partial class SingleMessage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SingleMessage()
        {
            this.MessageBoards = new HashSet<MessageBoard>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> TimeOfMessage { get; set; }
        public string MessageText { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageBoard> MessageBoards { get; set; }
    }
}
