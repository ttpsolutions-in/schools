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
    
    public partial class ExamStudentClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamStudentClass()
        {
            this.ExamStudentSubjects = new HashSet<ExamStudentSubject>();
        }
    
        public short ExamStudentClassId { get; set; }
        public short ExamId { get; set; }
        public int StudentClassId { get; set; }
        public Nullable<short> TotalFullMark { get; set; }
        public Nullable<short> TotalPassMark { get; set; }
        public Nullable<short> TotalMarks { get; set; }
        public Nullable<short> Grade { get; set; }
        public Nullable<short> Rank { get; set; }
        public Nullable<short> Status { get; set; }
    
        public virtual Exam Exam { get; set; }
        public virtual StudentClass StudentClass { get; set; }
        public virtual MasterData MasterData { get; set; }
        public virtual MasterData MasterData1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamStudentSubject> ExamStudentSubjects { get; set; }
    }
}
