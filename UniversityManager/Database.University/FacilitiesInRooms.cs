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
    
    public partial class FacilitiesInRooms
    {
        public int Id { get; set; }
        public int IdFacility { get; set; }
        public int IdRoom { get; set; }
    
        public virtual Facilities Facilities { get; set; }
        public virtual Rooms Rooms { get; set; }
    }
}
