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
    
    public partial class Product
    {
        public Product()
        {
            this.Assays = new HashSet<Assay>();
            this.Product_Color_Realation = new HashSet<Product_Color_Realation>();
        }
    
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string Description { get; set; }
        public Nullable<long> ProductUnitID { get; set; }
        public byte[] Picture { get; set; }
        public string LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public string Notes { get; set; }
        public Nullable<long> HRDepartmentID { get; set; }
    
        public virtual ICollection<Assay> Assays { get; set; }
        public virtual ICollection<Product_Color_Realation> Product_Color_Realation { get; set; }
        public virtual ProdustUnit ProdustUnit { get; set; }
    }
}
