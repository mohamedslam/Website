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
    
    public partial class att_AttendanceRecordsInPeriod_Result
    {
        public long ID { get; set; }
        public Nullable<long> EmpID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> InBegein { get; set; }
        public Nullable<int> InEnd { get; set; }
        public Nullable<int> OutBegein { get; set; }
        public Nullable<int> OutEnd { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> TimeIn { get; set; }
        public Nullable<int> TimeOut { get; set; }
        public bool IsOpenShift { get; set; }
        public Nullable<bool> isHoliday { get; set; }
        public Nullable<int> MinTime { get; set; }
    }
}