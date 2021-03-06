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
    
    public partial class HDMaterialsrequest
    {
        public HDMaterialsrequest()
        {
            this.DTLMaterialsRequests = new HashSet<DTLMaterialsRequest>();
            this.HDReceiptOfMaterialsRequests = new HashSet<HDReceiptOfMaterialsRequest>();
        }
    
        public long Id { get; set; }
        public Nullable<System.DateTime> DateMaterialsrequest { get; set; }
        public Nullable<long> EmpID { get; set; }
        public Nullable<long> ContractID { get; set; }
        public Nullable<long> StoreID { get; set; }
        public Nullable<long> RequestEmpID { get; set; }
        public string Notes { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<long> PeriodId { get; set; }
    
        public virtual ICollection<DTLMaterialsRequest> DTLMaterialsRequests { get; set; }
        public virtual EmployedInfo EmployedInfo { get; set; }
        public virtual StoresCompany StoresCompany { get; set; }
        public virtual ICollection<HDReceiptOfMaterialsRequest> HDReceiptOfMaterialsRequests { get; set; }
    }
}
