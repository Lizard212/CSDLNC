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
    
    public partial class BANGPHANANH
    {
        public string MAPHANANH { get; set; }
        public string NGUOITAO { get; set; }
        public string TIEUDE { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<System.DateTime> THOIGIANTAO { get; set; }
        public string TAILIEUDINHKEM { get; set; }
        public string NGUOINHAN { get; set; }
        public string CAPDO { get; set; }
        public string MACONGTAC { get; set; }
    
        public virtual LICHCONGTAC LICHCONGTAC { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual NHANVIEN NHANVIEN1 { get; set; }
    }
}