

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("DanhGiaSP")]
    public class DanhGiaSP
    {
        [Key]
        public int idDGSP { get; set; }
        [Required]
        [MaxLength(500)]
        public string noiDung { get; set; }

        public DateTime ngayDG { get; set; }

        public DateTime ngayCapNhat { get; set; }

        public int diemSo { get; set; }

        public int idSP { get; set; }
        [ForeignKey("idSP")]
        public SanPham SanPham { get; set; }


        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }
       

        public string trangThai { get; set; }
    }
}
