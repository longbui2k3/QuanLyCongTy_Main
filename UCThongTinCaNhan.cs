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
    public partial class UCThongTinCaNhan : UserControl
    {
        Dao dao = new Dao();
        public UCThongTinCaNhan()
        {
            InitializeComponent();
            
            txt_Username.Text = DangNhap.txt_UsernameCopy.Text;
            txt_Password.Text = DangNhap.pwd_LogInCopy.Text;

            dao.conn.Open();
            try
            {
                string query = "Select * from (Select * from (Select * " +
                                "from TKTruongPhong inner join NhanVien " +
                                "on TKTruongPhong.MaTP = NhanVien.MaNV where Username = '{0}' and Pass_word = '{1}') p inner join ChucVu " +
                                "on p.ViTri=ChucVu.MaChucVu) k inner join PhongBan on k.MaPB=Phongban.MaPB";
                string sqlStr = String.Format(query, txt_Username.Text, txt_Password.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_MaNV.Text = reader["MaNV"].ToString();
                    txt_HoVaTen.Text = reader["HoTen"].ToString();
                    date_NgaySinh.Text = reader["NgaySinh"].ToString();
                    cb_GioiTinh.Text = reader["GioiTinh"].ToString();
                    txt_QueQuan.Text = reader["QueQuan"].ToString();
                    txt_HonNhan.Text = reader["HonNhan"].ToString();
                    txt_SoCMND.Text = reader["SoCMND"].ToString();
                    txt_NoiCap.Text = reader["NoiCap"].ToString();
                    date_NgayCap.Text = reader["NgayCap"].ToString();
                    txt_DanToc.Text = reader["DanToc"].ToString();
                    txt_TonGiao.Text = reader["TonGiao"].ToString();
                    date_NgayVao.Text = reader["NgayVao"].ToString();
                    txt_TinhTrang.Text = reader["TinhTrang"].ToString();
                    rtxt_GhiChu.Text = reader["GhiChu"].ToString();
                    txt_ViTri.Text = reader["TenChucVu"].ToString();
                    txt_PhongBan.Text = reader["TenPB"].ToString();
                    txt_SDT.Text = reader["SoDienThoai"].ToString();
                    txt_Email.Text = reader["Email"].ToString();
                    txt_DiaChi.Text = reader["Diachi"].ToString();
                    txt_Facebook.Text = reader["Facebook"].ToString();
                    pb_Anh.Image = Image.FromFile(reader["Anh"].ToString());

                }
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
