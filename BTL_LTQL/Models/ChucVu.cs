using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL.Models
{
    [Table("ChucVus")]
    public class ChucVu
    {
        [Key]
        public string Ma_chucvu { get; set; }
        public string Ten_chucvu { get; set; }
    }
}