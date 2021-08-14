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
    
    public partial class EmpEmployeeGradeSalHistory
    {
        public short EmployeeGradeHistoryId { get; set; }
        public int EmpGradeId { get; set; }
        public int EmployeeId { get; set; }
        public short DepartmentId { get; set; }
        public decimal CTC { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public short OrgId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<short> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<short> UpdatedBy { get; set; }
        public string Remarks { get; set; }
        public Nullable<short> ApprovedBy { get; set; }
        public Nullable<int> WorkAccountId { get; set; }
        public Nullable<short> JobTitleId { get; set; }
        public Nullable<short> DesignationId { get; set; }
        public byte Active { get; set; }
    
        public virtual EmpEmployeeGradeSalHistory EmpEmployeeGradeSalHistory1 { get; set; }
        public virtual EmpEmployeeGradeSalHistory EmpEmployeeGradeSalHistory2 { get; set; }
        public virtual EmpEmployee EmpEmployee { get; set; }
        public virtual MasterData MasterData { get; set; }
        public virtual MasterData MasterData1 { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
