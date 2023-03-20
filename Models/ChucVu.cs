using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy.Models
{
    public class ChucVu
    {
        public string MaChucVu { get; set; } = null!;
        public string TenChucVu { get; set; } = null!;
        public string MaPB { get; set; } = null!;

        public int LuongChucVu { get; set; }
    }
}
