using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL.Models
{
    [Table("Duans")]
    public class DuAn
    {
        [Key]
        public string Ma_duan { get; set; }
        public string TenDuan { get; set; }
        public string Ngaybatdau { get; set; }
        public string Ngayketthuc { get; set; }
        public string SoLuong { get; set; }
        public string Dongia { get; set; }
        public string Chietkhau { get; set; }
        public string Ma_nv { get; set; }
    }
}