//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_API
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHANCONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHANCONG()
        {
            this.NHIEMVUs = new HashSet<NHIEMVU>();
        }
    
        public string MAPHANCONG { get; set; }
        public string MACONGTAC { get; set; }
        public string MANHANVIEN { get; set; }
        public string VAITRO { get; set; }
        public string TIEUDE { get; set; }
        public string NOIDUNG { get; set; }
        public string TAILIEUDINHKEM { get; set; }
        public Nullable<System.DateTime> THOIGIANBATDAU { get; set; }
        public Nullable<System.DateTime> THOIGIANKETTHUC { get; set; }
        public string TRANGTHAI { get; set; }
        public Nullable<int> TANSUATNHACNHO { get; set; }
        public Nullable<int> MUCDOUUTIEN { get; set; }
        public string DANHGIAPHANCONG { get; set; }
    
        public virtual LICHCONGTAC LICHCONGTAC { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHIEMVU> NHIEMVUs { get; set; }
    }
}
