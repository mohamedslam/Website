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
    
    public partial class SafeInfo
    {
        public SafeInfo()
        {
            this.Payment_Data = new HashSet<Payment_Data>();
        }
    
        public long Idcode { get; set; }
        public string SafeBoxName { get; set; }
        public string SafeDepartment { get; set; }
        public Nullable<decimal> FirstAccount { get; set; }
        public Nullable<long> EmplId { get; set; }
        public Nullable<bool> IsDefult { get; set; }
        public string notic { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
    
        public virtual ICollection<Payment_Data> Payment_Data { get; set; }
    }
}