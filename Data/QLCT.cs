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
        public DbSet<Models.NhanVien> NhanVien { get; set; } = null!;
        public DbSet<PhongBan> PhongBan { get; set; } = null!;
        public DbSet<Models.Luong> Luong { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QLCTEntityDB;Integrated Security=True");
        }
     }
}
