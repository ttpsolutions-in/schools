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
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.StudentClasses = new HashSet<StudentClass>();
            this.StudentDocuments = new HashSet<StudentDocument>();
            this.StudentFeePayments = new HashSet<StudentFeePayment>();
            this.StudentFeeReceipts = new HashSet<StudentFeeReceipt>();
        }
    
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public Nullable<short> Gender { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }
        public string WhatsAppNumber { get; set; }
        public Nullable<short> City { get; set; }
        public string Pincode { get; set; }
        public Nullable<short> State { get; set; }
        public Nullable<short> Country { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<short> Bloodgroup { get; set; }
        public Nullable<short> Category { get; set; }
        public string BankAccountNo { get; set; }
        public string IFSCCode { get; set; }
        public string MICRNo { get; set; }
        public string AadharNo { get; set; }
        public string Photo { get; set; }
        public Nullable<short> Religion { get; set; }
        public string ContactNo { get; set; }
        public string AlternateContact { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<short> ClassAdmissionSought { get; set; }
        public string LastSchoolPercentage { get; set; }
        public string TransferFromSchool { get; set; }
        public string TransferFromSchoolBoard { get; set; }
        public string Remarks { get; set; }
        public string FatherOccupation { get; set; }
        public string FatherContactNo { get; set; }
        public string MotherContactNo { get; set; }
        public string MotherOccupation { get; set; }
        public Nullable<short> PrimaryContactFatherOrMother { get; set; }
        public string NameOfContactPerson { get; set; }
        public string RelationWithContactPerson { get; set; }
        public string ContactPersonContactNo { get; set; }
        public Nullable<byte> Active { get; set; }
        public Nullable<byte> StudentDeclaration { get; set; }
        public Nullable<byte> ParentDeclaration { get; set; }
        public Nullable<short> LocationId { get; set; }
        public Nullable<short> ReasonForLeavingId { get; set; }
    
        public virtual MasterData MasterData { get; set; }
        public virtual MasterData MasterData1 { get; set; }
        public virtual MasterData MasterData2 { get; set; }
        public virtual MasterData MasterData3 { get; set; }
        public virtual MasterData MasterData4 { get; set; }
        public virtual MasterData MasterData5 { get; set; }
        public virtual MasterData MasterData6 { get; set; }
        public virtual MasterData MasterData7 { get; set; }
        public virtual MasterData MasterData8 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentDocument> StudentDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentFeePayment> StudentFeePayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentFeeReceipt> StudentFeeReceipts { get; set; }
    }
}
