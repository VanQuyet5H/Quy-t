﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VNUA.FITA.MQTT.HRM.Data.Access;

namespace VNUA.FITA.MQTT.HRM.Data.Access.Data.Migrations.SqlServer
{
    [DbContext(typeof(SqlServerDbContext))]
    [Migration("20221110134722_inital_db")]
    partial class inital_db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.BoPhan", b =>
                {
                    b.Property<int>("IdBoPhan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IdPhong")
                        .HasColumnType("int");

                    b.Property<string>("MaBP")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenBP")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdBoPhan");

                    b.HasIndex("IdPhong");

                    b.ToTable("BoPhan");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.ChamCong", b =>
                {
                    b.Property<int>("IdCong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IdNhanVien")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdCong");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("ChamCong");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.DonTu", b =>
                {
                    b.Property<int>("IdDonTu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IdNhanVien")
                        .HasColumnType("int");

                    b.Property<string>("NguoiNhan")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("PhanLoai")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<string>("TieuDe")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDonTu");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("DonTu");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.GiayTo", b =>
                {
                    b.Property<int>("MaGT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anh")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IdNhanVien")
                        .HasColumnType("int");

                    b.Property<string>("TenGT")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaGT");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("GiayTo");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.KhenThuongKyLuat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("GiaTri")
                        .HasColumnType("float");

                    b.Property<int>("IdNhanVien")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("PhanLoai")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("KhenThuongKyLuat");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.Luong", b =>
                {
                    b.Property<int>("MaLuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeSo")
                        .HasColumnType("int");

                    b.Property<int>("IdNhanVien")
                        .HasColumnType("int");

                    b.Property<double>("LCoBan")
                        .HasColumnType("float");

                    b.Property<double>("LThucNhan")
                        .HasColumnType("float");

                    b.Property<double>("PhiPhat")
                        .HasColumnType("float");

                    b.Property<double>("PhiThue")
                        .HasColumnType("float");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaLuong");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("Luong");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", b =>
                {
                    b.Property<int>("IdNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Anh")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ChucVu")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IdBP")
                        .HasColumnType("int");

                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int>("PhanQuyen")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("SoCCCD")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("TenTaiKhoan")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("TrinhDo")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdNhanVien");

                    b.HasIndex("IdBP");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.Phong", b =>
                {
                    b.Property<int>("IdPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("MaP")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenP")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPhong");

                    b.ToTable("Phong");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.BoPhan", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.Phong", "Phongs")
                        .WithMany("BoPhans")
                        .HasForeignKey("IdPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.ChamCong", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("ChamCongs")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.DonTu", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("DonTus")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.GiayTo", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("GiayTos")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.KhenThuongKyLuat", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("KhenThuongKyLuats")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.Luong", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("Luongs")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.BoPhan", "BoPhans")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdBP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
