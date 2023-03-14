﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyCongTy.Data;

#nullable disable

namespace QuanLyCongTy.Migrations
{
    [DbContext(typeof(QLCT))]
    [Migration("20230308083607_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyCongTy.Models.MLuong", b =>
                {
                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KhauTru")
                        .HasColumnType("int");

                    b.Property<int>("LuongNgayCong")
                        .HasColumnType("int");

                    b.Property<int>("LuongPhuCap")
                        .HasColumnType("int");

                    b.Property<int>("LuongViTri")
                        .HasColumnType("int");

                    b.Property<string>("MaNV1")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NgayCong")
                        .HasColumnType("int");

                    b.Property<string>("PhongBan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoCongChuan")
                        .HasColumnType("int");

                    b.Property<int>("TamUng")
                        .HasColumnType("int");

                    b.Property<int>("ThucNhan")
                        .HasColumnType("int");

                    b.Property<int>("Thuong")
                        .HasColumnType("int");

                    b.Property<string>("ViTri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("MaNV1");

                    b.ToTable("Luong");
                });

            modelBuilder.Entity("QuanLyCongTy.Models.MNhanVien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DanToc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaPB1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NgaySinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QueQuan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViTri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNV");

                    b.HasIndex("MaPB1");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("QuanLyCongTy.Models.MPhongBan", b =>
                {
                    b.Property<string>("MaPB")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPB");

                    b.ToTable("PhongBan");
                });

            modelBuilder.Entity("QuanLyCongTy.Models.MLuong", b =>
                {
                    b.HasOne("QuanLyCongTy.Models.MNhanVien", "MaNV")
                        .WithMany()
                        .HasForeignKey("MaNV1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaNV");
                });

            modelBuilder.Entity("QuanLyCongTy.Models.MNhanVien", b =>
                {
                    b.HasOne("QuanLyCongTy.Models.MPhongBan", "MaPB")
                        .WithMany()
                        .HasForeignKey("MaPB1");

                    b.Navigation("MaPB");
                });
#pragma warning restore 612, 618
        }
    }
}
