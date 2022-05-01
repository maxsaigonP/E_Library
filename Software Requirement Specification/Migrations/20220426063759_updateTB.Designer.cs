﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Software_Requirement_Specification.Data;

namespace Software_Requirement_Specification.Migrations
{
    [DbContext(typeof(Software_Requirement_SpecificationContext))]
    [Migration("20220426063759_updateTB")]
    partial class updateTB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Software_Requirement_Specification.Models.BoMon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenBoMon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BoMon");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.CauHoi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeThiId")
                        .HasColumnType("int");

                    b.Property<int>("DoKho")
                        .HasColumnType("int");

                    b.Property<int>("LoaiCauHoi")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeThiId");

                    b.ToTable("CauHoi");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.ChuDe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenChuDe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChuDe");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.DapAn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CauHoiId")
                        .HasColumnType("int");

                    b.Property<bool>("Dung")
                        .HasColumnType("bit");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CauHoiId");

                    b.ToTable("DapAn");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.DeThi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhThuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonHocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("NguoiDungId")
                        .HasColumnType("int");

                    b.Property<int>("NguoiPheDuyet")
                        .HasColumnType("int");

                    b.Property<string>("NienKhoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PheDuyet")
                        .HasColumnType("bit");

                    b.Property<string>("TenDeThi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TepId")
                        .HasColumnType("int");

                    b.Property<int>("ThoiLuong")
                        .HasColumnType("int");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MonHocId");

                    b.HasIndex("NguoiDungId");

                    b.HasIndex("TepId")
                        .IsUnique();

                    b.ToTable("DeThi");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.Hoi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MonHocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayGui")
                        .HasColumnType("datetime2");

                    b.Property<int>("NguoiDungId")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaiLieuId")
                        .HasColumnType("int");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MonHocId")
                        .IsUnique();

                    b.HasIndex("NguoiDungId")
                        .IsUnique();

                    b.ToTable("Hoi");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.LopHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLop")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.LopHocMonHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LopHocId")
                        .HasColumnType("int");

                    b.Property<int>("MonHocId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LopHocId");

                    b.HasIndex("MonHocId");

                    b.ToTable("LopHocMonHoc");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.MonHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BoMonId")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenMonHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BoMonId");

                    b.ToTable("MonHoc");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.NguoiDung", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VaitroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VaitroId");

                    b.ToTable("NguoiDung");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.PhanQuyen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenPhanQuyen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhanQuyen");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.TaiKhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NguoiDungId")
                        .HasColumnType("int");

                    b.Property<string>("TenNguoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NguoiDungId")
                        .IsUnique();

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.TaiLieu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChuDeId")
                        .HasColumnType("int");

                    b.Property<string>("LoaiTaiLieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonHocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayGuiPheDuyet")
                        .HasColumnType("datetime2");

                    b.Property<int>("NguoiChinhSuaCuoi")
                        .HasColumnType("int");

                    b.Property<int>("NguoiDungId")
                        .HasColumnType("int");

                    b.Property<string>("TenTaiLieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TepId")
                        .HasColumnType("int");

                    b.Property<string>("TieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ChuDeId");

                    b.HasIndex("MonHocId");

                    b.HasIndex("NguoiDungId");

                    b.HasIndex("TepId")
                        .IsUnique();

                    b.ToTable("TaiLieu");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.Tep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KichThuoc")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySuaCuoi")
                        .HasColumnType("datetime2");

                    b.Property<int>("NguoiChinhSua")
                        .HasColumnType("int");

                    b.Property<string>("TenTep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tep");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.ThongBao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoaiThongBao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LopHocId")
                        .HasColumnType("int");

                    b.Property<int>("NguoiDungId")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ThongBao");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.ThuVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChiTruyCap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HieuTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaTruongHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NgonNguXacDinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NienKhoaMacDinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHeThong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTruongHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThuVien");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.VaiTro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaiNguyen")
                        .HasColumnType("int");

                    b.Property<string>("TenVaiTro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThongBao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VaiTro");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.VaiTroPhanQuyen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PhanQuyenId")
                        .HasColumnType("int");

                    b.Property<int>("VaiTroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhanQuyenId");

                    b.HasIndex("VaiTroId");

                    b.ToTable("VaiTroPhanQuyen");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.CauHoi", b =>
                {
                    b.HasOne("Software_Requirement_Specification.Models.DeThi", "DeThi")
                        .WithMany("CauHoi")
                        .HasForeignKey("DeThiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeThi");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.DapAn", b =>
                {
                    b.HasOne("Software_Requirement_Specification.Models.CauHoi", "CauHoi")
                        .WithMany("DapAn")
                        .HasForeignKey("CauHoiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CauHoi");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.DeThi", b =>
                {
                    b.HasOne("Software_Requirement_Specification.Models.MonHoc", "MonHoc")
                        .WithMany("DeThi")
                        .HasForeignKey("MonHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Software_Requirement_Specification.Models.NguoiDung", "NguoiDung")
                        .WithMany("DeThi")
                        .HasForeignKey("NguoiDungId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Software_Requirement_Specification.Models.Tep", "Tep")
                        .WithOne("DeThi")
                        .HasForeignKey("Software_Requirement_Specification.Models.DeThi", "TepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MonHoc");

                    b.Navigation("NguoiDung");

                    b.Navigation("Tep");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.Hoi", b =>
                {
                    b.HasOne("Software_Requirement_Specification.Models.MonHoc", "MonHoc")
                        .WithOne("Hoi")
                        .HasForeignKey("Software_Requirement_Specification.Models.Hoi", "MonHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Software_Requirement_Specification.Models.NguoiDung", "NguoiDung")
                        .WithOne("Hoi")
                        .HasForeignKey("Software_Requirement_Specification.Models.Hoi", "NguoiDungId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MonHoc");

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.LopHocMonHoc", b =>
                {
                    b.HasOne("Software_Requirement_Specification.Models.LopHoc", "LopHoc")
                        .WithMany("LopHocMonHoc")
                        .HasForeignKey("LopHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Software_Requirement_Specification.Models.MonHoc", "MonHoc")
                        .WithMany("LopHocMonHoc")
                        .HasForeignKey("MonHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LopHoc");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.MonHoc", b =>
                {
                    b.HasOne("Software_Requirement_Specification.Models.BoMon", "BoMon")
                        .WithMany("MonHoc")
                        .HasForeignKey("BoMonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoMon");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.NguoiDung", b =>
                {
                    b.HasOne("Software_Requirement_Specification.Models.VaiTro", "VaiTro")
                        .WithMany("NguoiDung")
                        .HasForeignKey("VaitroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.TaiKhoan", b =>
                {
                    b.HasOne("Software_Requirement_Specification.Models.NguoiDung", "NguoiDung")
                        .WithOne("TaiKhoan")
                        .HasForeignKey("Software_Requirement_Specification.Models.TaiKhoan", "NguoiDungId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.TaiLieu", b =>
                {
                    b.HasOne("Software_Requirement_Specification.Models.ChuDe", "ChuDe")
                        .WithMany("TaiLieu")
                        .HasForeignKey("ChuDeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Software_Requirement_Specification.Models.MonHoc", "MonHoc")
                        .WithMany("TaiLieu")
                        .HasForeignKey("MonHocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Software_Requirement_Specification.Models.NguoiDung", "NguoiDung")
                        .WithMany("TaiLieu")
                        .HasForeignKey("NguoiDungId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Software_Requirement_Specification.Models.Tep", "Tep")
                        .WithOne("TaiLieu")
                        .HasForeignKey("Software_Requirement_Specification.Models.TaiLieu", "TepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChuDe");

                    b.Navigation("MonHoc");

                    b.Navigation("NguoiDung");

                    b.Navigation("Tep");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.VaiTroPhanQuyen", b =>
                {
                    b.HasOne("Software_Requirement_Specification.Models.PhanQuyen", "PhanQuyen")
                        .WithMany("VaiTroPhanQuyen")
                        .HasForeignKey("PhanQuyenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Software_Requirement_Specification.Models.VaiTro", "VaiTro")
                        .WithMany("VaiTroPhanQuyen")
                        .HasForeignKey("VaiTroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhanQuyen");

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.BoMon", b =>
                {
                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.CauHoi", b =>
                {
                    b.Navigation("DapAn");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.ChuDe", b =>
                {
                    b.Navigation("TaiLieu");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.DeThi", b =>
                {
                    b.Navigation("CauHoi");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.LopHoc", b =>
                {
                    b.Navigation("LopHocMonHoc");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.MonHoc", b =>
                {
                    b.Navigation("DeThi");

                    b.Navigation("Hoi");

                    b.Navigation("LopHocMonHoc");

                    b.Navigation("TaiLieu");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.NguoiDung", b =>
                {
                    b.Navigation("DeThi");

                    b.Navigation("Hoi");

                    b.Navigation("TaiKhoan");

                    b.Navigation("TaiLieu");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.PhanQuyen", b =>
                {
                    b.Navigation("VaiTroPhanQuyen");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.Tep", b =>
                {
                    b.Navigation("DeThi");

                    b.Navigation("TaiLieu");
                });

            modelBuilder.Entity("Software_Requirement_Specification.Models.VaiTro", b =>
                {
                    b.Navigation("NguoiDung");

                    b.Navigation("VaiTroPhanQuyen");
                });
#pragma warning restore 612, 618
        }
    }
}
