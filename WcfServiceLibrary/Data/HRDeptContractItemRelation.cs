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
    
    public partial class HRDeptContractItemRelation
    {
        public long ID { get; set; }
        public Nullable<long> HRDepartmentID { get; set; }
        public Nullable<long> ContractItemID { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
    
        public virtual ContractItem ContractItem { get; set; }
        public virtual HRDepartment HRDepartment { get; set; }
    }
}
