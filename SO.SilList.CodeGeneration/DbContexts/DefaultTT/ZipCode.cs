//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SO.LocalClub.CodeGeneration.Model.DefaultTT
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZipCode
    {
        public ZipCode()
        {
            this.Cities = new HashSet<City>();
        }
    
        public int zip { get; set; }
        public Nullable<double> latitude { get; set; }
        public Nullable<double> longitude { get; set; }
        public System.DateTime modified { get; set; }
        public System.DateTime created { get; set; }
    
        public virtual ICollection<City> Cities { get; set; }
    }
}