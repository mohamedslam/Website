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
    
    public partial class ItemComplex
    {
        public long id { get; set; }
        public long IdItemContro { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Amount { get; set; }
        public Nullable<int> Units { get; set; }
        public string LUU { get; set; }
        public System.DateTime LUD { get; set; }
    }
}