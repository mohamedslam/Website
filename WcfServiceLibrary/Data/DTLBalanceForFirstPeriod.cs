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
    
    public partial class DTLBalanceForFirstPeriod
    {
        public long Id { get; set; }
        public Nullable<long> HDID { get; set; }
        public Nullable<long> PurchasesBillID { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<long> UnitId { get; set; }
        public Nullable<double> StockInHand { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Notes { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<long> PeriodId { get; set; }
    
        public virtual HDBalanceForFirstPeriod HDBalanceForFirstPeriod { get; set; }
        public virtual ItemAmount ItemAmount { get; set; }
        public virtual ItemControl ItemControl { get; set; }
    }
}