//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salary
    {
        public int idSalary { get; set; }
        public Nullable<decimal> payDate { get; set; }
        public Nullable<decimal> salary1 { get; set; }
        public Nullable<decimal> bonus { get; set; }
        public Nullable<int> idEmployee { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
