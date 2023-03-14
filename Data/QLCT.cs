using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLyCongTy.Models;

namespace QuanLyCongTy.Data
{
    internal class QLCT: DbContext
    {
        public DbSet<MNhanVien> NhanVien { get; set; } = null!;
        public DbSet<MPhongBan> PhongBan { get; set; } = null!;
        public DbSet<MLuong> Luong { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QLCTEntityDB;Integrated Security=True");
        }
     }
}
