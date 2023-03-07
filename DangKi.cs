using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace QuanLyCongTy
{
    public partial class DangKi : Form
    {
        Dao dao = new Dao();
        public DangKi()
        {
            InitializeComponent();
        }
        public void KiemTraHopLe()
        {
            if (hoVaTen.Text == "" || viTri.Text == "" || SDT.Text == "" || Email.Text == "" || username.Text == "" || txt_Pwd.Text == "" || txt_PwdCon.Text == "")
            {
                throw new Exception("Thông tin không được để trống");
            }
            dao.KiemTraSDT(SDT.Text);
            if (!dao.KiemTraEmail(Email.Text)) throw new Exception("Email không hợp lệ");
            if (txt_Pwd.Text != txt_PwdCon.Text) throw new Exception("Mật khẩu xác nhận bạn nhập không phù hợp");
        }
        int hidePwd = 1;
        int hidePwdCon = 1;
        
        private void pwd_Sign_Up_Click(object sender, EventArgs e)
        {
            hidePwd = 1 - hidePwd;
            Image img = Image.FromFile("../../.././Images/" + (hidePwd == 1 ? "hide" : "show") + "_password.png");
            txt_Pwd.UseSystemPasswordChar = hidePwd == 1 ? true : false;
            pwd_Sign_Up.Image = img;
        }

        private void pwdCon_Sign_Up_Click(object sender, EventArgs e)
        {
            hidePwdCon = 1 - hidePwdCon;
            Image img = Image.FromFile("../../.././Images/" + (hidePwdCon == 1 ? "hide" : "show") + "_password.png");
            txt_PwdCon.UseSystemPasswordChar = hidePwdCon == 1 ? true : false;
            pwdCon_Sign_Up.Image = img;
        }
        private void txt_Pwd_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txt_PwdCon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                KiemTraHopLe();
                string query = "INSERT INTO TaiKhoan (hoVaTen, viTri, SDT, Email, Username, Pass_word) VALUES(N'{0}', N'{1}', '{2}', '{3}', '{4}', '{5}')";
                dao.ThemTaiKhoan(new TaiKhoan(hoVaTen.Text, viTri.Text, SDT.Text, Email.Text, username.Text, txt_Pwd.Text), query);
                MessageBox.Show("Đăng kí thành công ");
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng kí thất bại \n" + ex.Message);
            }
        }
    }
}
