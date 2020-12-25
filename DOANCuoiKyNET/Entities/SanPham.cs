using System;
using System.Collections.Generic;
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
       
        public string hinhAnh { get; set; }
        [Required]
        public string metaTitle { get; set; }

        public int luotXem { get; set; }
        
        public int soLuongKho { get; set; }
        [Required]
        
        public string moTa { get; set; }

        public int idLoaiSP { get; set; }
        [ForeignKey("idLoaiSPcon")]
        public LoaiSPcon LoaiSPcon { get; set; }

        public int idThuongHieu { get; set; }
        [ForeignKey("idThuongHieu")]
        public ThuongHieu ThuongHieu { get; set; }

        public string trangThai { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }
        public int idUser { get; set; }
        [ForeignKey("idUser")]
        public User User { get; set; }


        public ICollection<DanhGiaSP> DanhGiaSPs { get; set; }

        public ICollection<LuotMua> LuotMuas { get; set; }

        public ICollection<LuotThich> LuotThiches { get; set; }

        public ICollection<ThuocTinhSP> ThuocTinhSPs { get; set; }

        public ICollection<AnhSP> AnhSPs { get; set; }
        public ICollection<TraHang> TraHangs { get; set; }
        public ICollection<GioHang> GioHangs { get; set; }
        public SanPham()
        {
            DanhGiaSPs = new HashSet<DanhGiaSP>();
            LuotMuas = new HashSet<LuotMua>();
            LuotThiches = new HashSet<LuotThich>();
            ThuocTinhSPs = new HashSet<ThuocTinhSP>();
            AnhSPs = new HashSet<AnhSP>();
            TraHangs = new HashSet<TraHang>();
            GioHangs = new HashSet<GioHang>();
        }
    }
}
