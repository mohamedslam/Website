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
    
    public partial class AccountantPeriodYear_SelectAll_Result
    {
        public long Id { get; set; }
        public Nullable<System.DateTime> CreatDate { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public Nullable<bool> TerminalComplete { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public string UserClose { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public string Descrip { get; set; }
        public Nullable<int> Name { get; set; }
    }
}