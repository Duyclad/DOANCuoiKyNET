﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Entities
{
    [Table("GioiThieu")]
    public class GioiThieu
    {
        [Key]
        public int idGioiThieu { get; set; }
        [Required]
        public string tieude { get; set; }
        public string noidung { get; set; }
        public int idhinhanh { get; set; }
        public DateTime ngaytao { get; set; }
        public DateTime ngaycapnhat { get; set; }
        public int iduser { get; set; }
    }
}
