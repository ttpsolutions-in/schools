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
    
    public partial class MasterData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterData()
        {
            this.AccountingLedgerTrialBalances = new HashSet<AccountingLedgerTrialBalance>();
            this.AccountingLedgerTrialBalances1 = new HashSet<AccountingLedgerTrialBalance>();
            this.AccountingLedgerTrialBalances2 = new HashSet<AccountingLedgerTrialBalance>();
            this.AccountingTrialBalances = new HashSet<AccountingTrialBalance>();
            this.ApplicationFeatures = new HashSet<ApplicationFeature>();
            this.ClassFees = new HashSet<ClassFee>();
            this.ClassFees1 = new HashSet<ClassFee>();
            this.ClassFees2 = new HashSet<ClassFee>();
            this.ClassSubjects = new HashSet<ClassSubject>();
            this.ClassSubjects1 = new HashSet<ClassSubject>();
            this.ClassSubjectMarkComponents = new HashSet<ClassSubjectMarkComponent>();
            this.EmpComponents = new HashSet<EmpComponent>();
            this.EmpEmployeeGradeSalHistories = new HashSet<EmpEmployeeGradeSalHistory>();
            this.EmpEmployeeGradeSalHistories1 = new HashSet<EmpEmployeeGradeSalHistory>();
            this.EmpHolidayLists = new HashSet<EmpHolidayList>();
            this.EmpHolidayLists1 = new HashSet<EmpHolidayList>();
            this.EmployeeFamilies = new HashSet<EmployeeFamily>();
            this.EmployeeFamilies1 = new HashSet<EmployeeFamily>();
            this.Exams = new HashSet<Exam>();
            this.ExamStudentResults = new HashSet<ExamStudentResult>();
            this.ExamStudentResults1 = new HashSet<ExamStudentResult>();
            this.ExamStudentSubjectResults = new HashSet<ExamStudentSubjectResult>();
            this.FilesNPhotos = new HashSet<FilesNPhoto>();
            this.Pages = new HashSet<Page>();
            this.RoleUsers = new HashSet<RoleUser>();
            this.StudentClasses = new HashSet<StudentClass>();
            this.StudentDocuments = new HashSet<StudentDocument>();
            this.Students = new HashSet<Student>();
            this.Students1 = new HashSet<Student>();
            this.Students2 = new HashSet<Student>();
            this.Students3 = new HashSet<Student>();
            this.Students4 = new HashSet<Student>();
            this.Students5 = new HashSet<Student>();
            this.Students6 = new HashSet<Student>();
            this.Students7 = new HashSet<Student>();
            this.Students8 = new HashSet<Student>();
            this.StudTeacherClassMappings = new HashSet<StudTeacherClassMapping>();
            this.StudTeacherClassMappings1 = new HashSet<StudTeacherClassMapping>();
            this.TaskAssignments = new HashSet<TaskAssignment>();
            this.SchoolClassPeriods = new HashSet<SchoolClassPeriod>();
            this.SchoolClassPeriods1 = new HashSet<SchoolClassPeriod>();
            this.LeaveEmployeeLeaves = new HashSet<LeaveEmployeeLeaf>();
            this.LeaveEmployeeLeaves1 = new HashSet<LeaveEmployeeLeaf>();
            this.LeavePolicies = new HashSet<LeavePolicy>();
            this.LeavePolicies1 = new HashSet<LeavePolicy>();
        }
    
        public int MasterDataId { get; set; }
        public string MasterDataName { get; set; }
        public string Description { get; set; }
        public Nullable<short> ParentId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<short> CreatedBy { get; set; }
        public Nullable<short> OrgId { get; set; }
        public Nullable<short> DepartmentId { get; set; }
        public Nullable<short> LocationId { get; set; }
        public Nullable<short> ApplicationId { get; set; }
        public Nullable<byte> Active { get; set; }
        public string Logic { get; set; }
        public Nullable<byte> Sequence { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountingLedgerTrialBalance> AccountingLedgerTrialBalances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountingLedgerTrialBalance> AccountingLedgerTrialBalances1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountingLedgerTrialBalance> AccountingLedgerTrialBalances2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountingTrialBalance> AccountingTrialBalances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationFeature> ApplicationFeatures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassFee> ClassFees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassFee> ClassFees1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassFee> ClassFees2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassSubject> ClassSubjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassSubject> ClassSubjects1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassSubjectMarkComponent> ClassSubjectMarkComponents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpComponent> EmpComponents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpEmployeeGradeSalHistory> EmpEmployeeGradeSalHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpEmployeeGradeSalHistory> EmpEmployeeGradeSalHistories1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpHolidayList> EmpHolidayLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpHolidayList> EmpHolidayLists1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeFamily> EmployeeFamilies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeFamily> EmployeeFamilies1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamStudentResult> ExamStudentResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamStudentResult> ExamStudentResults1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamStudentSubjectResult> ExamStudentSubjectResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilesNPhoto> FilesNPhotos { get; set; }
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Page> Pages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleUser> RoleUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentDocument> StudentDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students8 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudTeacherClassMapping> StudTeacherClassMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudTeacherClassMapping> StudTeacherClassMappings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssignment> TaskAssignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolClassPeriod> SchoolClassPeriods { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolClassPeriod> SchoolClassPeriods1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveEmployeeLeaf> LeaveEmployeeLeaves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveEmployeeLeaf> LeaveEmployeeLeaves1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeavePolicy> LeavePolicies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeavePolicy> LeavePolicies1 { get; set; }
    }
}
