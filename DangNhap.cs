using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCongTy
{
    public partial class DangNhap : Form
    {
        IDao dao = new IDao();
        public DangNhap()
        {
            InitializeComponent();
        }
        int hide = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hide = 1 - hide;
            Image img = Image.FromFile("../../.././Images/" + (hide == 1 ? "hide" : "show") + "_password.png");
            pwd_Log_in.UseSystemPasswordChar = hide == 1 ? true : false;
            pictureBox1.Image = img; 
        }

        private void pwd_Log_In_TextChanged_1(object sender, EventArgs e)
        {

        }
        void form_Login(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
        }
        void form_Signup(object sender, EventArgs e)
        {
            DangKi dn = new DangKi();
            dn.Show();
        }
        void create_AttrBtn(Button btn, string image, string text, Point location, Size s)
        {
            btn.Image = Image.FromFile("../../.././Images/" + image);
            btn.Text = text;
            btn.TextImageRelation = TextImageRelation.ImageAboveText;
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.Location = location;
            btn.Size = s;
        }
        void btn_Logout(object sender, EventArgs e)
        {
            
            TabPage acc = new TabPage("Tài khoản");

            Button btn_login = new Button();
            create_AttrBtn(btn_login, "login.png", "Đăng Nhập", new Point(0, 0), new Size(123, 137));
            btn_login.Click += new EventHandler(form_Login);


            Button btn_signup = new Button();
            create_AttrBtn(btn_signup, "signup.png", "Đăng Ký", new Point(123, 0), new Size(123, 137));
            btn_signup.Click += new EventHandler(form_Signup);


            acc.Controls.Add(btn_login);
            acc.Controls.Add(btn_signup);
            Main.tc.TabPages.Insert(0, acc);
            Main.tc.TabPages.RemoveAt(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = "SELECT Username FROM TaiKhoan WHERE Username = @usernameLogIn AND Pass_word = @pass_word";
                dao.KiemTraDangNhap(txt_Username.Text, pwd_Log_in.Text, query);
                MessageBox.Show("Đăng nhập thành công ");

                if (checkBox1.Checked)
                {
                    Properties.Settings.Default.userName = txt_Username.Text;
                    Properties.Settings.Default.passUser = pwd_Log_in.Text;
                    Properties.Settings.Default.Save();
                }
                if (!checkBox1.Checked && Properties.Settings.Default.userName == string.Empty)
                {
                    Properties.Settings.Default.userName = "";
                    Properties.Settings.Default.passUser = "";
                    Properties.Settings.Default.Save();
                }

                TabPage inforAcc = new TabPage(txt_Username.Text);

                Button btn_tttk = new Button();
                create_AttrBtn(btn_tttk, "personal-information.png", "Thông Tin Cá Nhân", new Point(0, 0), new Size(123, 137));

                Button btn_logout = new Button();
                create_AttrBtn(btn_logout, "logout.png", "Đăng Xuất", new Point(123, 0), new Size(123, 137));
                btn_logout.Click += new EventHandler(btn_Logout);

                inforAcc.Controls.Add(btn_tttk);
                inforAcc.Controls.Add(btn_logout);
                

                Main.tc.TabPages.Insert(0, inforAcc);
                Main.tc.TabPages.RemoveAt(1);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại \n" + ex.Message);
            }
        }

        private void lbl_notAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKi dk = new DangKi();
            dk.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.userName != string.Empty)
            {
                txt_Username.Text = Properties.Settings.Default.userName;
                pwd_Log_in.Text = Properties.Settings.Default.passUser;
            }
        }
    }
}
