using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        public int idSP { get; set; }
        [Required]
        [MaxLength(100)]
        public string tenSP { get; set; }

        public int giaSP { get; set; }

        public int giamGiaSP { get; set; }
        [Required]
        public string hinhAnh { get; set; }
        [Required]
        public string metaTitle { get; set; }

        public int luotXem { get; set; }
        
        public int soLuongKho { get; set; }
        [Required]
        public string moTa { get; set; }

        public string idLoaiSP { get; set; }
        [ForeignKey("idLoaiSP")]
        public LoaiSP LoaiSP { get; set; }

        public string idThuongHieu { get; set; }
        [ForeignKey("idThuongHieu")]
        public ThuongHieu ThuongHieu { get; set; }

        public string trangThai { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }
    }
}
