//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace plthsEntities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clearance
    {
        public int clearance_id { get; set; }
        public Nullable<int> ResidentID { get; set; }
        public string Issued { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    }
}
