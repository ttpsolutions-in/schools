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
    
    public partial class ApplicationRoleUser
    {
        public short ApplicationRoleUserId { get; set; }
        public short UserId { get; set; }
        public short ApplicationId { get; set; }
        public short RoleId { get; set; }
        public byte Active { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public short CreatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public short UpdatedBy { get; set; }
    }
}
