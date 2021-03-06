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
    
    public partial class DTLPurchaseBill
    {
        public long Id { get; set; }
        public Nullable<long> HDId { get; set; }
        public Nullable<long> ItemId { get; set; }
        public Nullable<long> UnitId { get; set; }
        public Nullable<long> SupplierUnite { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> QTYBonus { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> PriceCostDiscount { get; set; }
        public Nullable<decimal> DiscountValue { get; set; }
        public Nullable<double> DiscountPercentage { get; set; }
        public Nullable<decimal> TPriceAfterDiscount { get; set; }
        public string Notes { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<decimal> priceCost { get; set; }
        public Nullable<long> CurrentQuantity { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public Nullable<decimal> ccTotalCostDiscount { get; set; }
        public Nullable<decimal> DefultPrice { get; set; }
        public Nullable<decimal> TotalDefultPrice { get; set; }
        public Nullable<double> realAmount { get; set; }
    
        public virtual HDPurchaseBill HDPurchaseBill { get; set; }
        public virtual ItemControl ItemControl { get; set; }
        public virtual ModelUnit ModelUnit { get; set; }
    }
}
