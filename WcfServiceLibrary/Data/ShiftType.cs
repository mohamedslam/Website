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
    
    public partial class ShiftType
    {
        public ShiftType()
        {
            this.EmployeesShifts = new HashSet<EmployeesShift>();
        }
    
        public long ID { get; set; }
        public string JobType { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<long> LUU { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<EmployeesShift> EmployeesShifts { get; set; }
    }
}
