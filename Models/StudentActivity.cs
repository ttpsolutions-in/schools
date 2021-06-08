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
    
    public partial class StudentActivity
    {
        public short StudentActivityId { get; set; }
        public Nullable<int> StudentClassId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public string Activity { get; set; }
        public Nullable<System.DateTime> ActivityDate { get; set; }
        public Nullable<byte> Active { get; set; }
        public string Remarks { get; set; }
        public Nullable<short> OrgId { get; set; }
        public Nullable<short> BatchId { get; set; }
        public Nullable<short> TeacherId { get; set; }
    
        public virtual Organization Organization { get; set; }
        public virtual StudentClass StudentClass { get; set; }
        public virtual Student Student { get; set; }
    }
}
