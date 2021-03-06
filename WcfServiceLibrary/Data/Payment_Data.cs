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
    
    public partial class Payment_Data
    {
        public long PaymentDataID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<long> BankID { get; set; }
        public Nullable<long> ChequeId { get; set; }
        public Nullable<long> SafeId { get; set; }
        public Nullable<long> PaymentPermissionID { get; set; }
        public Nullable<long> InstallmentID { get; set; }
        public Nullable<long> PeriodID { get; set; }
        public Nullable<decimal> PaymentValue { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public string Notes { get; set; }
        public Nullable<byte> PaymentType { get; set; }
    
        public virtual Installment Installment { get; set; }
        public virtual Payment_Permission Payment_Permission { get; set; }
        public virtual SafeInfo SafeInfo { get; set; }
    }
}
