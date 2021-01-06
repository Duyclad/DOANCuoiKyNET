﻿// <auto-generated />
using System;
using DOANCuoiKyNET.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DOANCuoiKyNET.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20210106191402_202101070214")]
    partial class _202101070214
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DOANCuoiKyNET.Entities.Banner", b =>
                {
                    b.Property<int>("idBanner")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(5000);

                    b.HasKey("idBanner");

                    b.HasIndex("idUser");

                    b.ToTable("Banner");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.ChiTietDonHang", b =>
                {
                    b.Property<int>("idCTDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("donGia")
                        .HasColumnType("int");

                    b.Property<int>("giamGia")
                        .HasColumnType("int");

                    b.Property<string>("hinhSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idDH")
                        .HasColumnType("int");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("tenSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thuocTinhSP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCTDH");

                    b.HasIndex("idDH");

                    b.ToTable("ChiTietDonHang");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.ChinhSachGiaoHang", b =>
                {
                    b.Property<int>("idChinhSachGiaoHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idChinhSachGiaoHang");

                    b.HasIndex("idUser");

                    b.ToTable("ChinhSachGiaoHang");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.DieuKhoanDichVu", b =>
                {
                    b.Property<int>("idDieuKhoanDV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idDieuKhoanDV");

                    b.HasIndex("idUser");

                    b.ToTable("DieuKhoanDichVu");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.DonHang", b =>
                {
                    b.Property<int>("idDH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaGiamGiacodeMGG")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("UseridUser")
                        .HasColumnType("int");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ghiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoDH")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("idNVCSKH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idNVShip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ipMayKhach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maGiamGiaDH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maGiamGiaShip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayDat")
                        .HasColumnType("datetime2");

                    b.Property<int>("phiShip")
                        .HasColumnType("int");

                    b.Property<string>("sdtDH")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("tenDH")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("tongSoTien")
                        .HasColumnType("int");

                    b.Property<int>("tongTienHang")
                        .HasColumnType("int");

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idDH");

                    b.HasIndex("MaGiamGiacodeMGG");

                    b.HasIndex("UseridUser");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.GioHang", b =>
                {
                    b.Property<int>("idGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hinhSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idSP")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<string>("phanLoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("tenSP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idGioHang");

                    b.HasIndex("idSP");

                    b.HasIndex("idUser");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.GioiThieu", b =>
                {
                    b.Property<int>("idGioiThieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("hinhAnh")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idGioiThieu");

                    b.HasIndex("idUser");

                    b.ToTable("GioiThieu");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.IPuser", b =>
                {
                    b.Property<int>("idIPuser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("diachiip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.HasKey("idIPuser");

                    b.HasIndex("idUser");

                    b.ToTable("IPuser");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.LienHe", b =>
                {
                    b.Property<int>("idLH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("hoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayGui")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idLH");

                    b.ToTable("LienHe");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.LoaiSP", b =>
                {
                    b.Property<int>("idLoaiSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<string>("metaTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenLoaiSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("typeLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idLoaiSP");

                    b.HasIndex("idUser");

                    b.ToTable("LoaiSP");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.MaGiamGia", b =>
                {
                    b.Property<string>("codeMGG")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("giaTri")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<int>("loaiMGG")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("tenMGG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codeMGG");

                    b.HasIndex("idUser");

                    b.ToTable("MaGiamGia");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.QuyDinhChung", b =>
                {
                    b.Property<int>("idQuyDinhChung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idQuyDinhChung");

                    b.HasIndex("idUser");

                    b.ToTable("QuyDinhChung");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.SanPham", b =>
                {
                    b.Property<int>("idSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("giaSP")
                        .HasColumnType("int");

                    b.Property<int>("giamGiaSP")
                        .HasColumnType("int");

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idLoaiSP")
                        .HasColumnType("int");

                    b.Property<int>("idThuongHieu")
                        .HasColumnType("int");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<int>("luotMua")
                        .HasColumnType("int");

                    b.Property<int>("luotXem")
                        .HasColumnType("int");

                    b.Property<string>("metaTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("moTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("soLuongKho")
                        .HasColumnType("int");

                    b.Property<string>("tenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idSP");

                    b.HasIndex("idLoaiSP");

                    b.HasIndex("idThuongHieu");

                    b.HasIndex("idUser");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.ThuongHieu", b =>
                {
                    b.Property<int>("idThuongHieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("emailThuongHieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("hinhLogo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("sdtThuongHieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenThuongHieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idThuongHieu");

                    b.HasIndex("idUser");

                    b.ToTable("ThuongHieu");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.User", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("diaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("hinhAVT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("hoatDongLanCuoi")
                        .HasColumnType("datetime2");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("sdtUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("tenUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("trangThai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vaiTro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUser");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.Banner", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("Banners")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.ChiTietDonHang", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.DonHang", "DonHang")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("idDH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.ChinhSachGiaoHang", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("ChinhSachGiaoHangs")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.DieuKhoanDichVu", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("DieuKhoanDichVus")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.DonHang", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.MaGiamGia", null)
                        .WithMany("DonHangs")
                        .HasForeignKey("MaGiamGiacodeMGG");

                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("DonHangs")
                        .HasForeignKey("UseridUser");
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.GioHang", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.SanPham", "SanPham")
                        .WithMany("GioHangs")
                        .HasForeignKey("idSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("GioHangs")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.GioiThieu", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("GioiThieus")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.IPuser", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("IPusers")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.LoaiSP", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("LoaiSPs")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.MaGiamGia", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("MaGiamGias")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.QuyDinhChung", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("QuyDinhChungs")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.SanPham", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.LoaiSP", "LoaiSP")
                        .WithMany()
                        .HasForeignKey("idLoaiSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOANCuoiKyNET.Entities.ThuongHieu", "ThuongHieu")
                        .WithMany("SanPhams")
                        .HasForeignKey("idThuongHieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("SanPhams")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOANCuoiKyNET.Entities.ThuongHieu", b =>
                {
                    b.HasOne("DOANCuoiKyNET.Entities.User", "User")
                        .WithMany("ThuongHieus")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
