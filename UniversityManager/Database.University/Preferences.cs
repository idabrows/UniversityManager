//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database.University
{
    using System;
    using System.Collections.Generic;
    
    public partial class Preferences
    {
        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public int IdCoworker { get; set; }
        public decimal PreferencePoints { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Employees Employees1 { get; set; }
    }
}
