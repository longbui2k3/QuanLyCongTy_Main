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
using StackedHeader;

namespace QuanLyCongTy
{
    public partial class UCLuong : UserControl
    {
        Dao dao = new Dao();

        public UCLuong()
        {
            InitializeComponent();
            StackedHeaderDecorator objREnderer = new StackedHeaderDecorator(dataGridView1);

        }

        

        private void UserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                dao.conn.Open();
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.HeaderText = "Tính Lương";
                btnCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                btnCol.UseColumnTextForButtonValue = true;
                btnCol.Text = "Tính Lương";
                dataGridView1.Columns.Insert(0, btnCol);
                DataGridViewCheckBoxColumn comboBoxCol = new DataGridViewCheckBoxColumn();
                comboBoxCol.HeaderText = "Chọn";
                dataGridView1.Columns.Insert(1, comboBoxCol);
                
                
                

                dataGridView1.DataSource = dao.DanhSach("SELECT MaNhanVien as 'Mã Nhân Viên', " +
                                                                "HoVaTen as 'Họ và Tên', " +
                                                                "PhongBan as 'Phòng Ban', " +
                                                                "ViTri as 'Vị Trí', " +
                                                                "LuongViTri as 'Lương Hợp Đồng.Lương Vị Trí', " +
                                                                "LuongPhuCap as 'Lương Hợp Đồng.Lương Phụ Cấp', " +
                                                                "NgayCong as 'Lương Thực Tế.Ngày Công', " +
                                                                "SoCongChuan as 'Lương Thực Tế.Số Công Chuẩn', " +
                                                                "LuongThucTe as 'Lương Thực Tế.Lương Thực Tế'," +
                                                                "Thuong as 'Các Khoản Khác.Thưởng', " +
                                                                "KhauTru as 'Các Khoản Khác.Khấu Trừ'," +
                                                                "TamUng as 'Lương Nhận.Tạm Ứng', " +
                                                                "ThucNhan as 'Lương Nhận.Thực Nhận' FROM LUONG");

                dataGridView1.Columns[1].Frozen = true;


                //btnCol.Frozen = true



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



        public void ThucThi(DataGridView dataGV, string query, string message)
        {
            try
            {
                dao.conn.Open();
                string sqlStr;
                sqlStr = "Select * from Luong";
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


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TimKiemNhanVien tknv = new TimKiemNhanVien();
            //tknv.Show();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[1];
            if (cell.Value == null)
            {
                cell.Value = true;
            }
            else cell.Value = !Convert.ToBoolean(cell.Value);  
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripComboBox2.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                toolStripComboBox2.Items.Add("Tháng " + i + "/" + toolStripComboBox1.Text);
            }
        }
        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] str = toolStripComboBox2.Text.Split('/');
            int month = Convert.ToInt32(str[0][str[0].Length - 1].ToString());
            int year = Convert.ToInt32(str[1]);
            string query = "SELECT MaNhanVien as 'Mã Nhân Viên', " +
                                       "HoVaTen as 'Họ và Tên', " +
                                       "PhongBan as 'Phòng Ban', " +
                                       "ViTri as 'Vị Trí', " +
                                       "LuongViTri as 'Lương Hợp Đồng.Lương Vị Trí', " +
                                       "LuongPhuCap as 'Lương Hợp Đồng.Lương Phụ Cấp', " +
                                       "NgayCong as 'Lương Thực Tế.Ngày Công', " +
                                       "SoCongChuan as 'Lương Thực Tế.Số Công Chuẩn', " +
                                       "LuongThucTe as 'Lương Thực Tế.Lương Thực Tế'," +
                                       "Thuong as 'Các Khoản Khác.Thưởng', " +
                                       "KhauTru as 'Các Khoản Khác.Khấu Trừ'," +
                                       "TamUng as 'Lương Nhận.Tạm Ứng', " +
                                       "ThucNhan as 'Lương Nhận.Thực Nhận' FROM LUONG WHERE ThangLamViec=" + month +"and NamLamViec="+year;
            string sqlStr = string.Format(query);
            if (dao.DanhSach(sqlStr).Rows.Count > 0)
                dataGridView1.DataSource = dao.DanhSach(sqlStr);

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            try
            {
                
                dao.conn.Open();
                
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.HeaderText = "Tính Lương";
                btnCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                btnCol.UseColumnTextForButtonValue = true;
                btnCol.Text = "Tính Lương";
                dataGridView1.Columns.Insert(0, btnCol);
                DataGridViewCheckBoxColumn comboBoxCol = new DataGridViewCheckBoxColumn();
                comboBoxCol.HeaderText = "Chọn";
                dataGridView1.Columns.Insert(1, comboBoxCol);
                dataGridView1.Columns[1].Frozen = true;


                string query = "SELECT MaNhanVien as 'Mã Nhân Viên', " +
                                        "HoVaTen as 'Họ và Tên', " +
                                        "PhongBan as 'Phòng Ban', " +
                                        "ViTri as 'Vị Trí', " +
                                        "LuongViTri as 'Lương Hợp Đồng.Lương Vị Trí', " +
                                        "LuongPhuCap as 'Lương Hợp Đồng.Lương Phụ Cấp', " +
                                        "NgayCong as 'Lương Thực Tế.Ngày Công', " +
                                        "SoCongChuan as 'Lương Thực Tế.Số Công Chuẩn', " +
                                        "LuongThucTe as 'Lương Thực Tế.Lương Thực Tế'," +
                                        "Thuong as 'Các Khoản Khác.Thưởng', " +
                                        "KhauTru as 'Các Khoản Khác.Khấu Trừ'," +
                                        "TamUng as 'Lương Nhận.Tạm Ứng', " +
                                        "ThucNhan as 'Lương Nhận.Thực Nhận' FROM LUONG WHERE MaNhanVien='{0}'";
                string sqlStr = string.Format(query, toolStripTextBoxSearch.Text);
                if (dao.DanhSach(sqlStr).Rows.Count > 0)
                    dataGridView1.DataSource = dao.DanhSach(sqlStr);

               

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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            UserControl1_Load(sender, e);
        }
        
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int total = dataGridView1.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells[1].Value) == true).Count();
            if (total > 0)
            {
                string message = $"Bạn chắc chắn muốn xóa hàng được chọn?";
                if (total > 1)
                    message = $"Bạn chắc chắn muốn xóa các hàng được chọn?";
                if (MessageBox.Show(message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[1].Value) == true)
                        {
                            string query = "DELETE FROM LUONG WHERE MaNhanVien='{0}'";
                            string sqlStr = string.Format(query, row.Cells[2].Value);
                            dao.conn.Open();
                            SqlCommand cmd = new SqlCommand(sqlStr, dao.conn);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                dataGridView1.DataSource = dao.DanhSach("SELECT MaNhanVien as 'Mã Nhân Viên', " +
                                                              "HoVaTen as 'Họ và Tên', " +
                                                              "PhongBan as 'Phòng Ban', " +
                                                              "ViTri as 'Vị Trí', " +
                                                              "LuongViTri as 'Lương Hợp Đồng.Lương Vị Trí', " +
                                                              "LuongPhuCap as 'Lương Hợp Đồng.Lương Phụ Cấp', " +
                                                              "NgayCong as 'Lương Thực Tế.Ngày Công', " +
                                                              "SoCongChuan as 'Lương Thực Tế.Số Công Chuẩn', " +
                                                              "LuongThucTe as 'Lương Thực Tế.Lương Thực Tế'," +
                                                              "Thuong as 'Các Khoản Khác.Thưởng', " +
                                                              "KhauTru as 'Các Khoản Khác.Khấu Trừ'," +
                                                              "TamUng as 'Lương Nhận.Tạm Ứng', " +
                                                              "ThucNhan as 'Lương Nhận.Thực Nhận' FROM LUONG");
                            }
                            dao.conn.Close();
                        }
                    }
                }    

            }
        }

      
    }
}
