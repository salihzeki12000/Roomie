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
    
    public partial class MessageBoard
    {
        public string SenderID { get; set; }
        public string RecieverID { get; set; }
        public int ProfileLinkerID { get; set; }
        public Nullable<int> MessageID { get; set; }
    
        public virtual SingleMessage SingleMessage { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual UserProfile UserProfile1 { get; set; }
        public virtual ProfileLinker ProfileLinker { get; set; }
    }
}