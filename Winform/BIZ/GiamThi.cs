//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Winform.BIZ
{
    using System;
    using System.Collections.Generic;
    
    public partial class GiamThi
    {
        public int MaPhong { get; set; }
        public int MaGiaoVien { get; set; }
        public string NhiemVu { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
        public virtual PhongThi PhongThi { get; set; }
    }
}
