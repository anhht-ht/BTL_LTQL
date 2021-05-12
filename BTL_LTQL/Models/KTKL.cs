using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_LTQL.Models
{
    [Table("ktkls")]
    public class KTKL
    {
        [Key]
        public string Ma_nv { get; set; }
        public string Ktkl { get; set; }
        public string Lydo { get; set; }
    }
}