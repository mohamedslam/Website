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
    
    public partial class SalesMain
    {
        public long Idcode { get; set; }
        public Nullable<long> CustId { get; set; }
        public Nullable<long> EmplId { get; set; }
        public Nullable<long> EditorId { get; set; }
        public Nullable<long> StoreId { get; set; }
        public Nullable<System.DateTime> DateBill { get; set; }
        public Nullable<System.DateTime> DateRecord { get; set; }
        public Nullable<System.DateTime> DateStatement { get; set; }
        public Nullable<decimal> CashPay { get; set; }
        public Nullable<decimal> delayedPay { get; set; }
        public Nullable<decimal> Checkpay { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public Nullable<decimal> DiscountRate { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public Nullable<bool> IsInStore { get; set; }
        public Nullable<bool> IsInExpendture { get; set; }
        public Nullable<bool> IsInJournal { get; set; }
        public Nullable<bool> IsInSafe { get; set; }
        public Nullable<bool> IsInCust { get; set; }
        public Nullable<bool> IsInBank { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<long> PeriodId { get; set; }
    }
}