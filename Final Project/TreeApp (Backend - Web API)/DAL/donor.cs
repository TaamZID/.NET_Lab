//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class donor
    {
        public donor()
        {
            this.donations = new HashSet<donation>();
        }
    
        public int d_id { get; set; }
        public string d_name { get; set; }
        public string d_email { get; set; }
        public Nullable<int> d_phone { get; set; }
        public string d_address { get; set; }
        public string d_image { get; set; }
    
        public virtual ICollection<donation> donations { get; set; }
    }
}
