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
    
    public partial class att_workTimeRecord
    {
        public att_workTimeRecord()
        {
            this.att_attendance = new HashSet<att_attendance>();
            this.att_EmpPermission = new HashSet<att_EmpPermission>();
            this.att_ShiftsTimes = new HashSet<att_ShiftsTimes>();
        }
    
        public long ID { get; set; }
        public string IdCode { get; set; }
        public Nullable<long> StartTime { get; set; }
        public Nullable<bool> StartPrayCheck { get; set; }
        public Nullable<long> StartPray { get; set; }
        public long StartBefore { get; set; }
        public Nullable<long> StartAfter { get; set; }
        public Nullable<long> EndTime { get; set; }
        public Nullable<bool> EndPrayCheck { get; set; }
        public Nullable<long> EndPray { get; set; }
        public long EndBefore { get; set; }
        public Nullable<long> EndAfter { get; set; }
        public Nullable<long> LUU { get; set; }
        public System.DateTime LUD { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<att_attendance> att_attendance { get; set; }
        public virtual ICollection<att_EmpPermission> att_EmpPermission { get; set; }
        public virtual ICollection<att_ShiftsTimes> att_ShiftsTimes { get; set; }
    }
}