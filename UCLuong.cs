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
    public partial class UCLuong : UserControl
    {
        IDao dao = new IDao();
        public static TextBox txt_HoVaTenCopy;
        public static TextBox txt_MaNVCopy;
        public static TextBox txt_PhongBanCopy;
        public static TextBox txt_ViTriCopy;
        public UCLuong()
        {
            InitializeComponent();
            txt_HoVaTenCopy = txt_HoVaTen;
            txt_MaNVCopy = txt_MaNV;
            txt_PhongBanCopy = txt_PhongBan;
            txt_ViTriCopy = txt_ViTri;
        }

        private void UserControl1_Load(object sender, EventArgs e)
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

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txt_MaNV.Text = row.Cells[0].Value.ToString();
                txt_HoVaTen.Text = row.Cells[1].Value.ToString();
                txt_PhongBan.Text = row.Cells[2].Value.ToString();
                txt_ViTri.Text = row.Cells[3].Value.ToString();
                txt_NgayCong.Text = row.Cells[4].Value.ToString();
                txt_LuongViTri.Text = row.Cells[5].Value.ToString();
                txt_SoCongChuan.Text = row.Cells[6].Value.ToString();
                txt_LuongNgayCong.Text = row.Cells[7].Value.ToString();
                txt_LuongPhuCap.Text = row.Cells[8].Value.ToString();
                txt_Thuong.Text = row.Cells[9].Value.ToString();
                txt_KhauTru.Text = row.Cells[10].Value.ToString();
                txt_TamUng.Text = row.Cells[11].Value.ToString();
                txt_ThucNhan.Text = row.Cells[12].Value.ToString();
            }
        }
        void KiemTraSo()
        {
            try
            {
                int NgayCong = Int32.Parse(txt_NgayCong.Text);
                int LuongViTri = Int32.Parse(txt_NgayCong.Text);
                int SoCongChuan = Int32.Parse(txt_SoCongChuan.Text);
                int LuongPhuCap = Int32.Parse(txt_LuongPhuCap.Text);
                int Thuong = Int32.Parse(txt_Thuong.Text);
                int KhauTru = Int32.Parse(txt_KhauTru.Text);
                int TamUng = Int32.Parse(txt_TamUng.Text);
            }
            catch
            {
                throw new Exception("Chỉ được phép nhập số ở thông tin Bảng Lương");
            }
        }
        public void ThucThi(DataGridView dataGV, string query, string message)
        {
            try
            {
                dao.conn.Open();
                string sqlStr;
                if (message == "Thêm" || message == "Sửa")
                {
                    KiemTraHopLe();
                    int NgayCong = Int32.Parse(txt_NgayCong.Text);
                    int LuongViTri = Int32.Parse(txt_LuongViTri.Text);
                    int SoCongChuan = Int32.Parse(txt_SoCongChuan.Text);
                    int LuongPhuCap = Int32.Parse(txt_LuongPhuCap.Text);
                    int LuongNgayCong = (LuongViTri + LuongPhuCap) / SoCongChuan;
                    int Thuong = Int32.Parse(txt_Thuong.Text);
                    int KhauTru = Int32.Parse(txt_KhauTru.Text);
                    int TamUng = Int32.Parse(txt_TamUng.Text);
                    int ThucNhan = (LuongViTri + LuongPhuCap) * NgayCong / SoCongChuan + Thuong - KhauTru;

                    sqlStr = string.Format(query, txt_MaNV.Text, txt_HoVaTen.Text, txt_PhongBan.Text, txt_ViTri.Text,
                                                     txt_NgayCong.Text != "" ? NgayCong : 0,
                                                     txt_LuongViTri.Text != "" ? LuongViTri : 0,
                                                     txt_SoCongChuan.Text != "" ? SoCongChuan : 0,
                                                     LuongNgayCong,
                                                     txt_LuongPhuCap.Text != "" ? LuongPhuCap : 0,
                                                     txt_Thuong.Text != "" ? Thuong : 0,
                                                     txt_KhauTru.Text != "" ? KhauTru : 0,
                                                     txt_TamUng.Text != "" ? TamUng : 0,
                                                     ThucNhan);
                }
                else
                {
                    sqlStr = string.Format(query, txt_MaNV.Text);
                }
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(message + " thành công");
                    dataGV.DataSource = dao.DanhSach("SELECT * FROM LUONG");
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
            string query = "INSERT INTO LUONG(MaNhanVien, HoVaTen, PhongBan, ViTri, NgayCong, LuongViTri, SoCongChuan, LuongNgayCong, LuongPhuCap, Thuong, KhauTru, TamUng, ThucNhan) VALUES('{0}', N'{1}', N'{2}', N'{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')";
            ThucThi(dataGV, query, "Thêm");
        }
        public void Xoa(DataGridView dataGV)
        {
            string query = "DELETE FROM LUONG WHERE MaNhanVien='{0}'";
            ThucThi(dataGV, query, "Xóa");
        }
        public void Sua(DataGridView dataGV)
        {
            string query = "UPDATE LUONG SET HoVaTen = N'{1}', PhongBan = N'{2}', ViTri = N'{3}', NgayCong = '{4}', LuongViTri = '{5}', SoCongChuan = '{6}', LuongNgayCong = '{7}', LuongPhuCap = '{8}', Thuong = '{9}', KhauTru = '{10}', TamUng = '{11}', ThucNhan = '{12}' WHERE MaNhanVien= '{0}' ";
            ThucThi(dataGV, query, "Sửa");
        }
        void KiemTraHopLe()
        {

            if (txt_MaNV.Text == "" || txt_HoVaTen.Text == "" || txt_PhongBan.Text == "" || txt_ViTri.Text == "")
                throw new Exception("Thông tin không được để trống");
            KiemTraSo();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Them(dataGridView1);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            Sua(dataGridView1);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
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

                txt_PhongBan.ReadOnly = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            TimKiemNhanVien tknv = new TimKiemNhanVien();
            tknv.Show();
        }
        void xuatLuongNgayCong()
        {
            if (txt_LuongViTri.Text != "" && txt_SoCongChuan.Text != "" && txt_LuongPhuCap.Text != "")
            {
                int LuongNgayCong;
                try
                {
                    int LuongViTri = Int32.Parse(txt_LuongViTri.Text);
                    int SoCongChuan = Int32.Parse(txt_SoCongChuan.Text);
                    int LuongPhuCap = Int32.Parse(txt_LuongPhuCap.Text);
                    LuongNgayCong = (LuongViTri + LuongPhuCap) / SoCongChuan;
                }
                catch
                {
                    LuongNgayCong = 0;
                }
                txt_LuongNgayCong.Text = LuongNgayCong.ToString();
            }
        }
        void xuatThucNhan()
        {
            if (txt_LuongViTri.Text != "" && txt_SoCongChuan.Text != "" && txt_LuongPhuCap.Text != "" && txt_NgayCong.Text != "" && txt_Thuong.Text != "" && txt_KhauTru.Text != "")
            {
                int ThucNhan;
                try
                {
                    int LuongViTri = Int32.Parse(txt_LuongViTri.Text);
                    int SoCongChuan = Int32.Parse(txt_SoCongChuan.Text);
                    int LuongPhuCap = Int32.Parse(txt_LuongPhuCap.Text);
                    int NgayCong = Int32.Parse(txt_NgayCong.Text);
                    int Thuong = Int32.Parse(txt_Thuong.Text);
                    int KhauTru = Int32.Parse(txt_KhauTru.Text);
                    ThucNhan = (LuongViTri + LuongPhuCap) * NgayCong / SoCongChuan + Thuong - KhauTru;
                }
                catch
                {
                    ThucNhan = 0;
                }
                txt_ThucNhan.Text = ThucNhan.ToString();
            }
        }

        private void txt_SoCongChuan_TextChanged(object sender, EventArgs e)
        {
            xuatLuongNgayCong();
            xuatThucNhan();
        }

        private void txt_LuongViTri_TextChanged(object sender, EventArgs e)
        {
            xuatLuongNgayCong();
            xuatThucNhan();
        }

        private void txt_LuongPhuCap_TextChanged(object sender, EventArgs e)
        {
            xuatLuongNgayCong();
            xuatThucNhan();
        }

        private void txt_NgayCong_TextChanged(object sender, EventArgs e)
        {
            xuatThucNhan();
        }

        private void txt_Thuong_TextChanged(object sender, EventArgs e)
        {
            xuatThucNhan();
        }

        private void txt_KhauTru_TextChanged(object sender, EventArgs e)
        {
            xuatThucNhan();
        }

        private void txt_TamUng_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_HoVaTen.Text = "";
            txt_PhongBan.Text = "";
            txt_ViTri.Text = "";
            txt_NgayCong.Text = "";
            txt_LuongViTri.Text = "";
            txt_SoCongChuan.Text = "";
            txt_LuongNgayCong.Text = "";
            txt_LuongPhuCap.Text = "";
            txt_Thuong.Text = "";
            txt_KhauTru.Text = "";
            txt_TamUng.Text = "";
            txt_ThucNhan.Text = "";
        }
    }
}
