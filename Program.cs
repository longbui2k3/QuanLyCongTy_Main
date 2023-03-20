using QuanLyCongTy.Data;
using QuanLyCongTy.Models;

namespace QuanLyCongTy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            Application.Run(new NVHayQL());
            /*
            using QLCT context = new QLCT();
            MPhongBan mPhongBan = new MPhongBan()
            {
                MaPB = "PB001",
                TenPB = "Marketing",
                DiaChi = "TPHCM",
                SDT = "0493859555",
            };
            context.PhongBan.Add(mPhongBan);
            MNhanVien mNhanVien = new MNhanVien()
            {
                MaNV = "NV001",
                HoTen = "Bùi Đức Long",
                ViTri = "Giám Đốc",
                QueQuan = "Thái Bình",
                DanToc = "Kinh",
                GioiTinh = "Nam",
                NgaySinh = "04/09/2003",
                SDT = "0777981051",
                MaPB = mPhongBan,
            };
            context.NhanVien.Add(mNhanVien);*/

                            
        }
    }
}