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
    
    public partial class AttDevicesUser
    {
        public int ID { get; set; }
        public long EmpID { get; set; }
        public int DeviceUserID { get; set; }
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public int Privilege { get; set; }
        public bool Enabled { get; set; }
    
        public virtual AttDevice AttDevice { get; set; }
        public virtual EmployedInfo EmployedInfo { get; set; }
    }
}