using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL.Models
{
    [Table("Phongbans")]
    public class Phongban
    {
        [Key]
        public string Ma_phong { get; set; }
        public string Ten_phong { get; set; }
    }
}