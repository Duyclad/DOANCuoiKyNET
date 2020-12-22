using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOANCuoiKyNET.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int idUser { get; set; }
        [Required]
        [MaxLength(10)]
        public string hoUser { get; set; }
        [Required]
        [MaxLength(50)]
        public string tenUser { get; set; }
        [Required]
        [MaxLength(10)]
        public string sdtUser { get; set; }
        [Required]
        [MaxLength(200)]
        [EmailAddress(ErrorMessage = "Nhập đúng định dạng email!")]
        public string emailUser { get; set; }
        [Required]
        public string matKhau { get; set; }

        public int gioiTinh { get; set; }

        public DateTime ngaySinh { get; set; }

        public string diaChi { get; set; }

        public string hinhAVT { get; set; }

        public DateTime ngayTao { get; set; }

        public DateTime ngayCapNhat { get; set; }

        public DateTime hoatDongLanCuoi { get; set; }

        public string trangThai { get; set; }

        public ICollection<Banner> Banners { get; set; }

        public ICollection<ThuongHieu> ThuongHieus { get; set; }

        public ICollection<LoaiSP> LoaiSPs { get; set; }

        public ICollection<SanPham> SanPhams { get; set; }

        public ICollection<MaGiamGia> MaGiamGias { get; set; }

        public ICollection<DanhGiaSP> DanhGiaSPs { get; set; }

        public ICollection<NhanVien> NhanViens { get; set; }

        public ICollection<QuanTri> QuanTris { get; set; }

        public ICollection<DonHang> DonHangs { get; set; }

        public ICollection<LuotMua> LuotMuas { get; set; }

        public ICollection<LuotThich> LuotThiches { get; set; }

        public ICollection<ThuocTinhSP> ThuocTinhSPs { get; set; }

        public ICollection<ChiTietTTSP> ChiTietTTSPs { get; set; }
        public User()
        {
            Banners = new HashSet<Banner>();
            ThuongHieus = new HashSet<ThuongHieu>();
            LoaiSPs = new HashSet<LoaiSP>();
            SanPhams = new HashSet<SanPham>();
            MaGiamGias = new HashSet<MaGiamGia>();
            DanhGiaSPs = new HashSet<DanhGiaSP>();
            NhanViens = new HashSet<NhanVien>();
            QuanTris = new HashSet<QuanTri>();
            DonHangs = new HashSet<DonHang>();
            LuotMuas = new HashSet<LuotMua>();
            LuotThiches = new HashSet<LuotThich>();
            ThuocTinhSPs = new HashSet<ThuocTinhSP>();
            ChiTietTTSPs = new HashSet<ChiTietTTSP>();
        }
    }
}
