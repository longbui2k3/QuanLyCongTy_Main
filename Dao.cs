using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyCongTy
{
    internal class Dao
    {
        public SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public DataTable DanhSach(string s)
        {
            string sqlStr = string.Format(s);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
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
                if (sqlex.Number == 2627) throw new Exception("Tên người dùng đã tồn tại");
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
