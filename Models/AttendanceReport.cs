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
    
    public partial class AttendanceReport
    {
        public int AttendanceReportId { get; set; }
        public int EmployeeId { get; set; }
        public int MonthYear { get; set; }
        public byte Presents { get; set; }
        public byte WeekOffs { get; set; }
        public byte Holiday { get; set; }
        public byte LeaveAjusted { get; set; }
        public byte PaidDays { get; set; }
        public byte LossOfPay { get; set; }
        public short OrgId { get; set; }
        public short FinancialYear { get; set; }
        public Nullable<short> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<short> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public byte Active { get; set; }
    
        public virtual Batch Batch { get; set; }
        public virtual EmpEmployee EmpEmployee { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
