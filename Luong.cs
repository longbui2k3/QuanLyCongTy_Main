using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCongTy
{
    public partial class Luong : Form
    {
        Dao dao = new Dao();
        public static TextBox txt_HoVaTenCopy;
        public static TextBox txt_MaNVCopy;
        public static TextBox txt_PhongBanCopy;
        public static TextBox txt_ViTriCopy;
        public Luong()
        {
            InitializeComponent();
            txt_HoVaTenCopy = txt_HoVaTen;
            txt_MaNVCopy = txt_MaNV;
            txt_PhongBanCopy = txt_PhongBan;
            txt_ViTriCopy = txt_ViTri;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        void KiemTraSo()
        {
            try
            {
                int NgayCong = Int32.Parse(txt_NgayCong.Text);
                int LuongViTri = Int32.Parse(txt_NgayCong.Text);
                int SoCongChuan = Int32.Parse(txt_SoCongChuan.Text);
                int LuongNgayCong = Int32.Parse(txt_LuongNgayCong.Text);
                int LuongPhuCap = Int32.Parse(txt_LuongPhuCap.Text);
                int Thuong = Int32.Parse(txt_Thuong.Text);
                int KhauTru = Int32.Parse(txt_KhauTru.Text);
                int TamUng = Int32.Parse(txt_TamUng.Text);
                int ThucNhan = Int32.Parse(txt_ThucNhan.Text);
            } catch 
            {
                throw new Exception("Chỉ được phép nhập số ở thông tin Bảng Lương");
            }
        }
        public void ThucThi(DataGridView dataGV, string query, string message)
        {
            try
            {
                dao.conn.Open();
                if (message == "Thêm" || message == "Sửa")
                    KiemTraHopLe();
                string sqlStr = string.Format(query, txt_MaNV.Text, txt_HoVaTen.Text, txt_PhongBan.Text, txt_ViTri.Text, 
                                                     txt_NgayCong.Text != "" ? Int32.Parse(txt_NgayCong.Text) : 0,
                                                     txt_LuongViTri.Text != "" ? Int32.Parse(txt_LuongViTri.Text) : 0,
                                                     txt_SoCongChuan.Text != "" ? Int32.Parse(txt_SoCongChuan.Text) : 0,
                                                     txt_LuongNgayCong.Text != "" ? Int32.Parse(txt_LuongNgayCong.Text) : 0,
                                                     txt_LuongPhuCap.Text != "" ? Int32.Parse(txt_LuongPhuCap.Text) : 0,
                                                     txt_Thuong.Text != "" ? Int32.Parse(txt_Thuong.Text) : 0,
                                                     txt_KhauTru.Text != "" ? Int32.Parse(txt_KhauTru.Text) : 0,
                                                     txt_TamUng.Text != "" ? Int32.Parse(txt_TamUng.Text) : 0,
                                                     txt_ThucNhan.Text != "" ? Int32.Parse(txt_ThucNhan.Text) : 0);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(message + " thành công");
                    dataGV.DataSource = dao.DanhSach(" SELECT * FROM LUONG");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + " thất bại \n" + ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }
        public void Them(DataGridView dataGV)
        {
            string query = "INSERT INTO LUONG(MaNhanVien, HoVaTen, PhongBan, ViTri, NgayCong, LuongViTri, SoCongChuan, LuongNgayCong, LuongPhuCap, Thuong, KhauTru, TamUng, ThucNhan) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')";
            ThucThi(dataGV, query, "Thêm");
        }
        public void Xoa(DataGridView dataGV)
        {
            string query = "DELETE FROM LUONG WHERE MaNhanVien= '{0}'";
            ThucThi(dataGV, query, "Xóa");
        }
        public void Sua(DataGridView dataGV)
        {
            string query = "UPDATE LUONG SET HoVaTen = '{1}', PhongBan = '{2}', ViTri = '{3}', NgayCong = '{4}', LuongViTri = '{5}', SoCongChuan = '{6}', LuongNgayCong = '{7}', LuongPhuCap = '{8}', Thuong = '{9}', KhauTru = '{10}', TamUng = '{11}', ThucNhan = '{12}' WHERE MaNhanVien= '{0}' ";
            ThucThi(dataGV, query, "Sửa");
        }

        private void Luong_Load(object sender, EventArgs e)
        {
            try
            {
                dao.conn.Open();
                dataGridView1.DataSource = dao.DanhSach("SELECT MaNhanVien as 'Mã Nhân Viên', " +
                                                                "HoVaTen as 'Họ và Tên', " +
                                                                "PhongBan as 'Phòng Ban', " +
                                                                "ViTri as 'Vị Trí', " +
                                                                "NgayCong as 'Ngày Công', " +
                                                                "LuongViTri as 'Lương Vị Trí', " +
                                                                "SoCongChuan as 'Số Công Chuẩn', " +
                                                                "LuongNgayCong as 'Lương Ngày Công'," +
                                                                "LuongPhuCap as 'Lương Phụ Cấp', " +
                                                                "Thuong as 'Thưởng', " +
                                                                "KhauTru as 'Khấu Trừ'," +
                                                                "TamUng as 'Tạm Ứng', " +
                                                                "ThucNhan as 'Thực Nhận' FROM LUONG");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }
        void KiemTraHopLe()
        {
            
            if (txt_MaNV.Text == "" || txt_HoVaTen.Text == "" || txt_PhongBan.Text == "" || txt_ViTri.Text == "")
                throw new Exception("Thông tin không được để trống");
            KiemTraSo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Them(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sua(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xoa(dataGridView1);
        }

        private void txt_MaNV_TextChanged(object sender, EventArgs e)
        {
            dao.conn.Open();
            string query = "SELECT * FROM NHANVIEN, PHONGBAN WHERE MaNV='{0}' AND NHANVIEN.MAPB = PHONGBAN.MAPB";
            string sqlStr = string.Format(query, txt_MaNV.Text);
            SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {  
                txt_PhongBan.Text = reader["TenPB"].ToString();
                txt_HoVaTen.Text = reader["HoTen"].ToString();
                txt_ViTri.Text = reader["ViTri"].ToString();

                txt_PhongBan.ReadOnly = true ;
                txt_HoVaTen.ReadOnly = true;
                txt_ViTri.ReadOnly = true;
            }
            else
            {
                txt_PhongBan.Text = "";
                txt_HoVaTen.Text = "";
                txt_ViTri.Text = "";

                txt_PhongBan.ReadOnly = false;
                txt_HoVaTen.ReadOnly = false;
                txt_ViTri.ReadOnly = false;
            }
            dao.conn.Close();
        }

        private void txt_HoVaTen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TimKiemNhanVien tknv = new TimKiemNhanVien();
            tknv.Show();
        }
    }
}
