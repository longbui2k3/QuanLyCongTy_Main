using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    internal class TaiKhoan
    {
        private string hoVaTen;
        private string viTri;
        private string sDT;
        private string email;
        private string userName;
        private string pwd;
        public TaiKhoan(string hoVaTen, string viTri, string sDT, string email, string userName, string pwd)
        {
            this.hoVaTen = hoVaTen;
            this.viTri = viTri;
            this.sDT = sDT;
            this.email = email;
            this.userName = userName;
            this.pwd = pwd;
        }
        public static List<TaiKhoan> tk = new List<TaiKhoan>();

        public string HoVaTen { get { return hoVaTen; } set { hoVaTen = value; } }
        public string ViTri { get { return viTri; } set { viTri = value; } }
        public string SDT { get { return sDT; } set { sDT = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Username { get { return userName; } set { userName = value; } }
        public string Password { get { return pwd; } set { pwd = value; } }
    }
}
