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
    
    public partial class StudentCertificate
    {
        public int StudentCertificateId { get; set; }
        public short CertificateTypeId { get; set; }
        public System.DateTime IssuedDate { get; set; }
        public int StudentClassId { get; set; }
        public short OrgId { get; set; }
        public short BatchId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<short> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<short> UpdatedBy { get; set; }
        public byte Active { get; set; }
    
        public virtual Batch Batch { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual StudentClass StudentClass { get; set; }
    }
}
