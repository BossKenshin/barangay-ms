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
    
    public partial class business_permit
    {
        public int permit_id { get; set; }
        public string name { get; set; }
        public Nullable<int> ResidentID { get; set; }
        public string business_name { get; set; }
        public string location { get; set; }
        public int issuedPlace_id { get; set; }
        public Nullable<int> amount { get; set; }
        public Nullable<System.DateTime> expiration { get; set; }
        public string date { get; set; }
        public string businessPermitStatus { get; set; }
    }
}