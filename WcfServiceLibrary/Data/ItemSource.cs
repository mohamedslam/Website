//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceLibrary.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemSource
    {
        public long id { get; set; }
        public Nullable<long> IdItemContro { get; set; }
        public Nullable<long> IdSupplier { get; set; }
        public Nullable<int> priority { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public string ItemCode { get; set; }
    
        public virtual ItemControl ItemControl { get; set; }
        public virtual SupplierInfo SupplierInfo { get; set; }
    }
}