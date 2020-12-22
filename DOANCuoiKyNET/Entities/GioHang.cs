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
        public int idSP { get; set; }
        [ForeignKey("idSP")]
        public SanPham SanPham { get; set; }
        public string hinhSP { get; set; }
        public string tenSP { get; set; }
        public int soLuong { get; set; }
        public string phanLoai { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }
    }
}
