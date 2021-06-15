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
    
    public partial class StudentFeeReceipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentFeeReceipt()
        {
            this.PaymentDetails = new HashSet<PaymentDetail>();
        }
    
        public short StudentReceiptId { get; set; }
        public decimal TotalAmount { get; set; }
        public Nullable<decimal> Less { get; set; }
        public Nullable<short> OfflineReceiptNo { get; set; }
        public System.DateTime ReceiptDate { get; set; }
        public Nullable<int> StudentClassId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<byte> Active { get; set; }
        public Nullable<short> OrgId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<short> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<short> UpdatedBy { get; set; }
    
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
        public virtual StudentClass StudentClass { get; set; }
        public virtual Student Student { get; set; }
    }
}
