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
    
    public partial class OP_CodeMask
    {
        public string Page { get; set; }
        public bool UseAutomaticNumber { get; set; }
        public bool CanManual { get; set; }
        public int StartNumber { get; set; }
        public int NumberLength { get; set; }
        public string Letters { get; set; }
        public bool IsFixedLength { get; set; }
        public bool UseLetters { get; set; }
        public string MaskString { get; set; }
        public bool MaskIsNumber { get; set; }
        public bool UseBranchId { get; set; }
        public bool UseYearId { get; set; }
        public string PV_TableName { get; set; }
        public string PV_FieldName { get; set; }
        public int PV_FieldValue { get; set; }
        public string PV_KeyField { get; set; }
    }
}
