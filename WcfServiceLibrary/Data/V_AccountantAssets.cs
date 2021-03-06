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
    
    public partial class V_AccountantAssets
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string TreeId { get; set; }
        public Nullable<bool> IsDepreciationMethod { get; set; }
        public Nullable<int> DepreciationPercent { get; set; }
        public Nullable<int> DepreciationMethod { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Scrap { get; set; }
        public Nullable<int> UseLife { get; set; }
        public string Serial { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string MachineID { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<decimal> PurchaseValue { get; set; }
        public Nullable<long> AssetsDept { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<long> CoinId { get; set; }
        public Nullable<bool> IsEmpCare { get; set; }
        public Nullable<bool> IsInitialBalance { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<bool> IsRelay { get; set; }
    }
}
