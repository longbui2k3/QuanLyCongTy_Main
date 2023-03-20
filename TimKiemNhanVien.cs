using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongTy
{
    public partial class TimKiemNhanVien : Form
    {
        IDao dao = new IDao();
        public TimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimKiemNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                dao.conn.Open();
                dataGridView1.DataSource = dao.DanhSach("SELECT MaNV as 'Mã Nhân Viên', " +
                                                                "HoTen as 'Họ và Tên', " +
                                                                "ViTri as 'Vị Trí', " + 
                                                                "TenPB as 'Phòng Ban' FROM NHANVIEN, PHONGBAN WHERE NHANVIEN.MaPB=PHONGBAN.MaPB");
                this.AcceptButton = button1;
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                Luong.txt_MaNVCopy.Text = row.Cells[0].Value.ToString();
                Luong.txt_HoVaTenCopy.Text = row.Cells[1].Value.ToString();
                Luong.txt_ViTriCopy.Text = row.Cells[2].Value.ToString();
                Luong.txt_PhongBanCopy.Text = row.Cells[3].Value.ToString();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dao.conn.Open();
                string query = "SELECT MaNV as 'Mã Nhân Viên', " +
                                        "HoTen as 'Họ và Tên', " +
                                        "ViTri as 'Vị Trí', " +
                                        "TenPB as 'Phòng Ban' FROM NHANVIEN inner join PHONGBAN on NhanVien.MaPB=PhongBan.MaPB WHERE HoTen LIKE N'%{0}%'";
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
    }
}
