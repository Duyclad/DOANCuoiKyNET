using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Entities
{
    [Table("GioHang")]
    public class GioHang
    {
        [Key]
        public int idGioHang { get; set; }
        [Required]
        public HinhAnh hinhSP { get; set; }
        public string tenSP { get; set; }
        public int soluong { get; set; }
        public string phanloai { get; set; }
        public int idKH { get; set; }
    }
}
