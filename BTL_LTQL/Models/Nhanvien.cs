using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL.Models
{
    [Table("Nhanviens")]
    public class Nhanvien
    {
        [Key]
        public string Ma_nv { get; set; }
        public string Ma_chucvu { get; set; }
        public string Ten_nv { get; set; }
        public string Sodienthoai { get; set; }
        public string Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
        public string Quequan { get; set; }
        public string Dantoc { get; set; }
        public string Phongban { get; set; }
        public string Trinhdo { get; set; }
    }
}