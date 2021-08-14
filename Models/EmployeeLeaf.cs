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
    
    public partial class EmployeeLeaf
    {
        public int EmployeeLeaveId { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public System.DateTime LeaveFrom { get; set; }
        public System.DateTime LeaveTo { get; set; }
        public short NoOfDays { get; set; }
        public string LeaveReason { get; set; }
        public Nullable<System.DateTime> ApplyDate { get; set; }
        public Nullable<int> LeaveStatusId { get; set; }
        public Nullable<System.DateTime> ApproveRejecteDate { get; set; }
        public Nullable<short> ApprovedBy { get; set; }
        public string Remarks { get; set; }
        public short OrgId { get; set; }
        public byte Active { get; set; }
        public Nullable<short> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<short> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual EmpEmployee EmpEmployee { get; set; }
        public virtual MasterData MasterData { get; set; }
        public virtual MasterData MasterData1 { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
