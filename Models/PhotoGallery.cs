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
    
    public partial class PhotoGallery
    {
        public int PhotoId { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public Nullable<byte> Active { get; set; }
        public Nullable<short> AlbumId { get; set; }
        public Nullable<byte> PhotoOrFile { get; set; }
        public short OrgId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<short> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<short> UpdatedBy { get; set; }
    
        public virtual Album Album { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
