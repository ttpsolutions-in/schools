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
    
    public partial class EmpHolidayList
    {
        public short HolidayCalendarId { get; set; }
        public string HolidayName { get; set; }
        public System.DateTime HolidayDate { get; set; }
        public int LocationId { get; set; }
        public int HolidayTypeId { get; set; }
        public short FinancialYearId { get; set; }
        public byte Active { get; set; }
        public short OrgId { get; set; }
        public Nullable<short> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<short> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual Batch Batch { get; set; }
        public virtual MasterData MasterData { get; set; }
        public virtual MasterData MasterData1 { get; set; }
    }
}
