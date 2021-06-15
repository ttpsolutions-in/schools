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
    
    public partial class AppUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AppUser()
        {
            this.RoleUsers = new HashSet<RoleUser>();
        }
    
        public short ApplicationUserId { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<short> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<short> UpdatedBy { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public Nullable<byte> Active { get; set; }
        public string Remarks { get; set; }
        public Nullable<short> ManagerId { get; set; }
        public Nullable<short> OrgId { get; set; }
        public Nullable<short> DepartmentId { get; set; }
        public Nullable<short> LocationId { get; set; }
    
        public virtual Organization Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoleUser> RoleUsers { get; set; }
    }
}
