using Microsoft.EntityFrameworkCore;

namespace QuanLyCongTy.Models
{
    [PrimaryKey(nameof(MaPB))]
    public class MPhongBan
    {
        public string MaPB{ get; set; } = null!;
        public string TenPB { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public string SDT { get; set; } = null!;
    }
}