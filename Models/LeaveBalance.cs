//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace schools.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeaveBalance
    {
        public int LeaveBalanceId { get; set; }
        public int EmployeeId { get; set; }
        public int LeavePolicyId { get; set; }
        public short YearMonth { get; set; }
        public short FinancialYearId { get; set; }
        public short OrgId { get; set; }
        public Nullable<short> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<short> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public byte Active { get; set; }
        public byte NoOfDays { get; set; }
    
        public virtual Batch Batch { get; set; }
        public virtual EmpEmployee EmpEmployee { get; set; }
        public virtual LeavePolicy LeavePolicy { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
