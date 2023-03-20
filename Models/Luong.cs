using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuanLyCongTy.Models
{
	[Keyless]
    public class Luong
    {
		public NhanVien MaNV { get; set; } = null!;
		public string HoTen { get; set; } = null!;
        public string PhongBan { get; set; } = null!; 
        public string ViTri { get; set; } = null!; 
        public int NgayCong { get; set; }
		public int LuongViTri { get; set; } 
		public int SoCongChuan { get; set; } 
		public int LuongThucTe { get; set; }
		public int LuongPhuCap { get; set; }
		public int Thuong { get; set; }
		public int KhauTru { get; set; }
		public int TamUng { get; set; }
		public int ThucNhan { get; set; }
    }
}
