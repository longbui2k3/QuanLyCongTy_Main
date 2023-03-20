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
namespace QuanLyCongTy.RecycleCode
{
    public partial class Form1 : Form
    {
        Dao dao = new Dao();
        public static TextBox txt_HoVaTenCopy;
        public static TextBox txt_MaNVCopy;
        public static TextBox txt_PhongBanCopy;
        public static TextBox txt_ViTriCopy;
        public Form1()
        {
            InitializeComponent();
            txt_HoVaTenCopy = txt_HoVaTen;
            txt_MaNVCopy = txt_MaNV;
            txt_PhongBanCopy = txt_PhongBan;
            txt_ViTriCopy = txt_ViTri;
        }
        /* if (e.RowIndex >= 0)
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
            }*/
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
        void KiemTraHopLe()
        {

            if (txt_MaNV.Text == "" || txt_HoVaTen.Text == "" || txt_PhongBan.Text == "" || txt_ViTri.Text == "")
                throw new Exception("Thông tin không được để trống");
            KiemTraSo();
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
        /*
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
                    }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
