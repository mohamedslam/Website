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
    
    public partial class TreeUserMenuApplication
    {
        public long Id { get; set; }
        public Nullable<long> IdTree { get; set; }
        public Nullable<long> ParentID { get; set; }
        public string FormName { get; set; }
        public string DisplayValue { get; set; }
        public Nullable<bool> AllowOpen { get; set; }
        public Nullable<bool> WithParameters { get; set; }
        public Nullable<int> UserSort { get; set; }
        public Nullable<int> ImageIndex { get; set; }
        public Nullable<bool> Checked { get; set; }
        public Nullable<bool> Seperated { get; set; }
        public Nullable<long> EmplIdCode { get; set; }
        public Nullable<bool> IsSelect { get; set; }
        public Nullable<bool> IsModified { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<bool> IsDisplayReport { get; set; }
        public Nullable<bool> IsPrintReport { get; set; }
        public Nullable<bool> IsLock { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
    }
}
