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
    
    public partial class SystemExceptionLogView
    {
        public long Id { get; set; }
        public string MethodName { get; set; }
        public Nullable<long> LineNum { get; set; }
        public string ClassName { get; set; }
        public string ExceptionDetails { get; set; }
        public string MachineName { get; set; }
        public string Ip { get; set; }
        public string DomainName { get; set; }
        public Nullable<bool> IsSolved { get; set; }
        public string Notice { get; set; }
        public Nullable<System.DateTime> LUD { get; set; }
        public Nullable<long> LUU { get; set; }
    }
}
