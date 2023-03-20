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
                txt_MaNV.ReadOnly = true;
                txt_HoVaTen.ReadOnly = true;
                date_NgaySinh.Enabled = false;
                cb_GioiTinh.Enabled = false;
                txt_QueQuan.ReadOnly = true;
                txt_HonNhan.ReadOnly = true;
                txt_SoCMND.ReadOnly = true;
                txt_NoiCap.ReadOnly = true;
                date_NgayCap.Enabled = false;
                txt_DanToc.ReadOnly = true;
                txt_TonGiao.ReadOnly = true;
                date_NgayVao.Enabled = false;
                txt_TinhTrang.ReadOnly = true;
                rtxt_GhiChu.ReadOnly = true;
                txt_ViTri.ReadOnly = true;
                txt_PhongBan.ReadOnly = true;
                txt_SDT.ReadOnly = true;
                txt_Email.ReadOnly = true;
                txt_DiaChi.ReadOnly = true;
                txt_Facebook.ReadOnly = true;
                btn_ChonAnh.Enabled = false;
                btn_pwd.Enabled = false;
                btn_Luu.Enabled = false;
                

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

        private void btn_pwd_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = !txt_Password.UseSystemPasswordChar;
            Image img = Image.FromFile("../../.././Images/" + (txt_Password.UseSystemPasswordChar ? "hide" : "view") + ".png");
            btn_pwd.Image = img;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_MaNV.ReadOnly = false;
            txt_HoVaTen.ReadOnly = false;
            date_NgaySinh.Enabled = true;
            cb_GioiTinh.Enabled = true; ;
            txt_QueQuan.ReadOnly = false;
            txt_HonNhan.ReadOnly = false;
            txt_SoCMND.ReadOnly = false;
            txt_NoiCap.ReadOnly = false;
            date_NgayCap.Enabled = true;
            txt_DanToc.ReadOnly = false;
            txt_TonGiao.ReadOnly = false;
            date_NgayVao.Enabled = true;
            txt_TinhTrang.ReadOnly = false;
            rtxt_GhiChu.ReadOnly = false;
            txt_ViTri.ReadOnly = false;
            txt_PhongBan.ReadOnly = false;
            txt_SDT.ReadOnly = false;
            txt_Email.ReadOnly = false;
            txt_DiaChi.ReadOnly = false;
            txt_Facebook.ReadOnly = false;
            btn_ChonAnh.Enabled = true;
            btn_pwd.Enabled = true;
            btn_Luu.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                dao.conn.Open();
                string query = "INSERT INTO NhanVien VALUES('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')";
                /*
                string sqlStr = String.Format(query, txt_MaNV, txt_HoVaTen, )
                SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại \n" + ex.Message);
            }
            finally
            {
                dao.conn.Close();
            }
        }
    }
}
