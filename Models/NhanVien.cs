using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuanLyCongTy.Models
{
    //PrimaryKey(nameof(MaNV))]
    public class NhanVien
    {
        public string MaNV { get; set; } = null!;
        public string HoTen { get; set; } = null!;
        
        public string ViTri { get; set; } = null!;
        public string QueQuan { get; set; } = null!;
        public string DanToc { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public string NgaySinh {get; set; } = null!;

        public string SDT { get; set; } = null!;
        public PhongBan MaPB { get; set; } = null!;

        public NhanVien() { }

    }

}
