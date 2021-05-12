using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL.Models
{
    [Table("Hopdongs")]
    public class HopDong
    {
        [Key]
        public String Ma_hd { get; set; }
        public string Ma_nv { get; set; }
        public string Ten_nv { get; set; }
        public string Ngayky_hd { get; set; }
        public string Han_hd { get; set; }
    }
}