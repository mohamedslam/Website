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
    
    public partial class Safe_AllData
    {
        public long Id { get; set; }
        public long Idcode { get; set; }
        public string SafeBoxName { get; set; }
        public string SafeDepartment { get; set; }
        public Nullable<bool> IsDefult { get; set; }
        public Nullable<float> Debit { get; set; }
        public Nullable<float> Credit { get; set; }
        public string Declaration { get; set; }
        public string Descrip { get; set; }
        public Nullable<System.DateTime> InDate { get; set; }
        public string Type { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public string Notic { get; set; }
        public Nullable<long> EmplId { get; set; }
    }
}