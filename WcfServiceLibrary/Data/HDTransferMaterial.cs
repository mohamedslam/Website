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
    
    public partial class HDTransferMaterial
    {
        public HDTransferMaterial()
        {
            this.DTLTransferMaterials = new HashSet<DTLTransferMaterial>();
            this.DTLTransferMaterialsNews = new HashSet<DTLTransferMaterialsNew>();
        }
    
        public long Id { get; set; }
        public Nullable<System.DateTime> DateHDTransferMaterials { get; set; }
        public Nullable<long> HDTransferRequest { get; set; }
        public Nullable<long> RequestStoreID { get; set; }
        public Nullable<long> ReceiveStoreID { get; set; }
        public Nullable<long> RequestEmpID { get; set; }
        public Nullable<long> ReceiveEmpID { get; set; }
        public Nullable<long> PeriodId { get; set; }
        public string Notes { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<long> IdCode { get; set; }
        public string Barcode { get; set; }
    
        public virtual ICollection<DTLTransferMaterial> DTLTransferMaterials { get; set; }
        public virtual ICollection<DTLTransferMaterialsNew> DTLTransferMaterialsNews { get; set; }
        public virtual EmployedInfo EmployedInfo { get; set; }
        public virtual StoresCompany StoresCompany { get; set; }
    }
}
