//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tank_Platoons
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guns
    {
        public Guns()
        {
            this.Tanks = new HashSet<Tanks>();
        }
    
        public string id { get; set; }
        public Nullable<int> gun_penetration { get; set; }
        public string ammo_type { get; set; }
    
        public virtual ICollection<Tanks> Tanks { get; set; }
    }
}
