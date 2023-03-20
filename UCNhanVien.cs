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
using Microsoft.Office.Interop.Excel;

namespace QuanLyCongTy
{
    public partial class UCNhanVien : UserControl
    {
        Dao dao = new Dao();
        public UCNhanVien()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
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
                if (dao.DanhSach(query).Rows.Count > 0)
                {
                    dataGridView1.DataSource = dao.DanhSach(query);
                }

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

        private void btn_Search_Click(object sender, EventArgs e)
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
                                        "FROM NHANVIEN inner join PHONGBAN on NhanVien.MaPB=PhongBan.MaPB WHERE " + (rb_HoTen.Checked ? "HoTen LIKE N'%{0}%'" : "MaNV='{0}'");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txt_MaNV.Text = row.Cells[0].Value.ToString();
                txt_HoVaTen.Text = row.Cells[1].Value.ToString();
                txt_PhongBan.Text = row.Cells[2].Value.ToString();
                txt_ViTri.Text = row.Cells[3].Value.ToString();
                txt_QueQuan.Text = row.Cells[4].Value.ToString();
                txt_DanToc.Text = row.Cells[5].Value.ToString();
                txt_GioiTinh.Text = row.Cells[6].Value.ToString();
                date_NgaySinh.Text = row.Cells[7].Value.ToString();
                txt_SDT.Text = row.Cells[8].Value.ToString();
                txt_Email.Text = row.Cells[9].Value.ToString();
                txt_TinhTrang.Text = row.Cells[10].Value.ToString();
            }
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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
                if (dao.DanhSach(query).Rows.Count > 0)
                {
                    dataGridView1.DataSource = dao.DanhSach(query);
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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult iExit;

                iExit = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (iExit == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(item.Index);
                    }
                }
            }
            
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            app.Visible = true;
           
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets["Sheet1"];
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            worksheet.Name = "Nhân Viên";
           
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs("./sheet1.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        }
        Bitmap bitmap;
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "PNG Image|*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pB_Anh.Image = Image.FromFile(op.FileName);
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void date_NgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
