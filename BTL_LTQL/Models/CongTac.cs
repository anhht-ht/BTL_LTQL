using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL.Models
{
    [Table("Congtacs")]
    public class CongTac
    {
        [Key]
        public string Ma_nv { get; set; }
        public string Congviec { get; set; }
        public string Ngaybatdau { get; set; }
        public string Ngayketthuc { get; set; }
        public string Noilamviec { get; set; }

    }
}