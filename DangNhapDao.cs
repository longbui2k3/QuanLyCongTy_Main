using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using QuanLyCongTy.Models;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCongTy
{
    internal class DangNhapDao: Dao
    {
        public void KiemTraSDT(string sdt)
        {
            string vn_regex = "((09|03|07|08|05)+([0-9]{8})$)";
            Regex regex = new Regex(vn_regex);
            if (!regex.IsMatch(sdt))
                throw new Exception("Số điện thoại không hợp lệ");
        }
        public bool KiemTraEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

       
        public void ThemTaiKhoan(TaiKhoan tk, string query)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format(query, tk.HoVaTen, tk.ViTri, tk.SDT, tk.Email, tk.Username, tk.Password);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                int errorPrimaryKey = 2627;
                if (sqlex.Number == errorPrimaryKey) throw new Exception("Tên người dùng đã tồn tại");
            }
            finally
            {
                conn.Close();
            }
        }
        public void KiemTraDangNhap(string username, string password, string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            var danhmuc1 = new SqlParameter("@usernameLogIn", username);
            var danhmuc2 = new SqlParameter("@pass_word", password);
            cmd.Parameters.Add(danhmuc1);
            cmd.Parameters.Add(danhmuc2);
            if (!cmd.ExecuteReader().HasRows)
            {
                conn.Close();
                throw new Exception("");
            }
            else conn.Close();

        }
    }
}
