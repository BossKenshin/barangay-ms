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
    
    public partial class Farm
    {
        public int farmID { get; set; }
        public string Hectares { get; set; }
        public string LandStatus { get; set; }
        public string TypeSharing { get; set; }
        public string TypeCrops { get; set; }
        public Nullable<int> residentID { get; set; }
    }
}
