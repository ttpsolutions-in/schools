﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TTPEntities : DbContext
    {
        public TTPEntities()
            : base("name=TTPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AccountingLedgerTrialBalance> AccountingLedgerTrialBalances { get; set; }
        public virtual DbSet<AccountingTrialBalance> AccountingTrialBalances { get; set; }
        public virtual DbSet<AccountingVoucher> AccountingVouchers { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<ApplicationFeatureRolesPerm> ApplicationFeatureRolesPerms { get; set; }
        public virtual DbSet<ApplicationFeature> ApplicationFeatures { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<ClassFee> ClassFees { get; set; }
        public virtual DbSet<ClassSubjectMarkComponent> ClassSubjectMarkComponents { get; set; }
        public virtual DbSet<EmpComponent> EmpComponents { get; set; }
        public virtual DbSet<EmpEmployeeGradeSalHistory> EmpEmployeeGradeSalHistories { get; set; }
        public virtual DbSet<EmpEmployeeGroup> EmpEmployeeGroups { get; set; }
        public virtual DbSet<EmpEmployee> EmpEmployees { get; set; }
        public virtual DbSet<EmpEmployeeSalaryComponent> EmpEmployeeSalaryComponents { get; set; }
        public virtual DbSet<EmpEmployeeSkill> EmpEmployeeSkills { get; set; }
        public virtual DbSet<EmpHolidayList> EmpHolidayLists { get; set; }
        public virtual DbSet<EmployeeEducationHistory> EmployeeEducationHistories { get; set; }
        public virtual DbSet<EmployeeFamily> EmployeeFamilies { get; set; }
        public virtual DbSet<EmployeeMonthlySalary> EmployeeMonthlySalaries { get; set; }
        public virtual DbSet<EmpManagerGroupMapping> EmpManagerGroupMappings { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamSlot> ExamSlots { get; set; }
        public virtual DbSet<ExamStudentResult> ExamStudentResults { get; set; }
        public virtual DbSet<ExamStudentSubjectResult> ExamStudentSubjectResults { get; set; }
        public virtual DbSet<FilesNPhoto> FilesNPhotos { get; set; }
        public virtual DbSet<MasterData> MasterDatas { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<PageHistory> PageHistories { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PhotoGallery> PhotoGalleries { get; set; }
        public virtual DbSet<RoleUser> RoleUsers { get; set; }
        public virtual DbSet<SchoolFeeType> SchoolFeeTypes { get; set; }
        public virtual DbSet<SlotAndClassSubject> SlotAndClassSubjects { get; set; }
        public virtual DbSet<StudentActivity> StudentActivities { get; set; }
        public virtual DbSet<StudentCertificate> StudentCertificates { get; set; }
        public virtual DbSet<StudentClass> StudentClasses { get; set; }
        public virtual DbSet<StudentClassSubject> StudentClassSubjects { get; set; }
        public virtual DbSet<StudentDocument> StudentDocuments { get; set; }
        public virtual DbSet<StudentFeePayment> StudentFeePayments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudTeacherClassMapping> StudTeacherClassMappings { get; set; }
        public virtual DbSet<SubjectType> SubjectTypes { get; set; }
        public virtual DbSet<TaskConfiguration> TaskConfigurations { get; set; }
        public virtual DbSet<VariableConfiguration> VariableConfigurations { get; set; }
        public virtual DbSet<StudentFeeReceipt> StudentFeeReceipts { get; set; }
        public virtual DbSet<TaskAssignmentComment> TaskAssignmentComments { get; set; }
        public virtual DbSet<TaskAssignment> TaskAssignments { get; set; }
        public virtual DbSet<SchoolClassPeriod> SchoolClassPeriods { get; set; }
        public virtual DbSet<SchoolTimeTable> SchoolTimeTables { get; set; }
        public virtual DbSet<LeaveEmployeeLeaf> LeaveEmployeeLeaves { get; set; }
        public virtual DbSet<AttendanceReport> AttendanceReports { get; set; }
        public virtual DbSet<LeaveBalance> LeaveBalances { get; set; }
        public virtual DbSet<LeavePolicy> LeavePolicies { get; set; }
        public virtual DbSet<ClassSubject> ClassSubjects { get; set; }
        public virtual DbSet<ReportConfigData> ReportConfigDatas { get; set; }
        public virtual DbSet<ReportOrgReportName> ReportOrgReportNames { get; set; }
        public virtual DbSet<ReportOrgReportColumn> ReportOrgReportColumns { get; set; }
    }
}
