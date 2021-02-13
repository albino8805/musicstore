//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicStoreApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<decimal> PriceSale { get; set; }
        public int SingerFK { get; set; }
        public int CategoryFK { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> Updated { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Singer Singer { get; set; }
    }
}