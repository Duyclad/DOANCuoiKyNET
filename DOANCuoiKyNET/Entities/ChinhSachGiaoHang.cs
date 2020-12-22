﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Entities
{
    [Table("ChinhSachGiaoHang")]
    public class ChinhSachGiaoHang
    {
        [Key]
        public int idChinhSachGiaoHang { get; set; }
        
        public string tieuDe { get; set; }
        public string noiDung { get; set; }
        public string hinhAnh { get; set; }
        public DateTime ngayTao { get; set; }
        public DateTime ngayCapNhat { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }

    }
}
