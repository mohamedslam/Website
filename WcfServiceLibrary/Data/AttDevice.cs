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
    
    public partial class AttDevice
    {
        public AttDevice()
        {
            this.AttDevicesUsers = new HashSet<AttDevicesUser>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int MachineNo { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public Nullable<long> LUU { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
    
        public virtual ICollection<AttDevicesUser> AttDevicesUsers { get; set; }
    }
}
