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
    
    public partial class HDBalanceForLastPeriod
    {
        public HDBalanceForLastPeriod()
        {
            this.DTLBalanceForLastPeriods = new HashSet<DTLBalanceForLastPeriod>();
        }
    
        public long Id { get; set; }
        public Nullable<System.DateTime> DateHDBalanceForLastPeriod { get; set; }
        public Nullable<long> EmpID { get; set; }
        public Nullable<long> PeridID { get; set; }
        public Nullable<long> StoreID { get; set; }
        public string Notes { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
    
        public virtual ICollection<DTLBalanceForLastPeriod> DTLBalanceForLastPeriods { get; set; }
        public virtual StoresCompany StoresCompany { get; set; }
    }
}