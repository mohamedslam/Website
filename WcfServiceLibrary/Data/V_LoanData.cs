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
    
    public partial class V_LoanData
    {
        public long Id { get; set; }
        public Nullable<long> PaymentCount { get; set; }
        public Nullable<long> EmplId { get; set; }
        public string Name { get; set; }
        public string HRJobName { get; set; }
        public string Nationalty { get; set; }
        public Nullable<decimal> loanVal { get; set; }
        public Nullable<System.DateTime> loanDate { get; set; }
    }
}
