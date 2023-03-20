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
    public partial class NhanVien : Form
    {
        IDao dao = new IDao();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                dao.conn.Open();
                string query = "SELECT MaNV as 'Mã Nhân Viên', " +
                                        "HoTen as 'Họ và Tên', " +
                                        "ViTri as 'Vị Trí', " +
                                        "TenPB as 'Phòng Ban'," +
                                        "QueQuan as 'Quê Quán'," +
                                        "DanToc as 'Dân Tộc'," +
                                        "GioiTinh as 'Giới Tính'," +
                                        "NgaySinh as 'Ngày Sinh'," +
                                        "NhanVien.SoDienThoai as 'SĐT'," +
                                        "Email," +
                                        "TinhTrang as 'Tình Trạng'" +
                                        "FROM NHANVIEN inner join PHONGBAN on NhanVien.MaPB=PhongBan.MaPB";
                string sqlStr = string.Format(query);
                if (dao.DanhSach(sqlStr).Rows.Count > 0)
                {
                    dataGridView1.DataSource = dao.DanhSach(sqlStr);
                }
                this.AcceptButton = btn_Search;


                string queryPB = "Select TenPB from PhongBan";
                SqlCommand cmd = new SqlCommand(queryPB, dao.conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                    cb_PhongBan.Items.Add(reader["TenPB"]);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dao.conn.Open();
                string query = "SELECT MaNV as 'Mã Nhân Viên', " +
                                        "HoTen as 'Họ và Tên', " +
                                        "ViTri as 'Vị Trí', " +
                                        "TenPB as 'Phòng Ban'," +
                                        "QueQuan as 'Quê Quán'," +
                                        "DanToc as 'Dân Tộc'," +
                                        "GioiTinh as 'Giới Tính'," +
                                        "NgaySinh as 'Ngày Sinh'," +
                                        "NhanVien.SoDienThoai as 'SĐT'," +
                                        "Email," +
                                        "TinhTrang as 'Tình Trạng'" +
                                        "FROM NHANVIEN inner join PHONGBAN on NhanVien.MaPB=PhongBan.MaPB WHERE " + (rb_HoTen.Checked ? "HoTen LIKE N'%{0}%'" : "MaNV='{0}'" );
                string sqlStr = string.Format(query, txt_Search.Text);
                if (dao.DanhSach(sqlStr).Rows.Count > 0)
                {
                    dataGridView1.DataSource = dao.DanhSach(sqlStr);
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
