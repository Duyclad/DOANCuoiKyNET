

using Microsoft.EntityFrameworkCore;

namespace DOANCuoiKyNET.Entities
{
    public class MyDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<AnhSP> AnhSPs { get; set; }
        public DbSet<BanDo>  BanDos { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<ChinhSachGiaoHang> ChinhSachGiaoHangs { get; set; }

        public DbSet<ChinhSachQuyenRiengTu> ChinhSachQuyenRiengTus { get; set; }
        public DbSet<ChinhSachTraHangVaHoanTien> ChinhSachTraHangVaHoanTiens { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<ChiTietTTSP> ChiTietTTSPs { get; set; }
        public DbSet<DangKyNhanThongBao> DangKyNhanThongBaos { get; set; }
        public DbSet<DanhGiaSP> DanhGiaSPs { get; set; }
        public DbSet<DieuKhoanDichVu> DieuKhoanDichVus { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioiThieu> GioiThieus { get; set; }

        public DbSet<IPuser> IPusers { get; set; }
        public DbSet<LienHe> LienHes { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<LuotMua> LuotMuas { get; set; }
        public DbSet<LuotThich> LuotThiches { get; set; }
        public DbSet<MaGiamGia> MaGiamGias { get; set; }
 
       
        public DbSet<QuyDinhChung> QuyDinhChungs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ThuocTinhSP> ThuocTinhSPs { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<TraHang> TraHangs { get; set; }
        public object User { get; internal set; }

        public MyDBContext(DbContextOptions options) : base(options) { }
    }
}
