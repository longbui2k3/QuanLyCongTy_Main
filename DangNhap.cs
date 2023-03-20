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
        DangNhapDao dndao = new DangNhapDao();
        public static TextBox txt_UsernameCopy;
        public static TextBox pwd_LogInCopy;
        public DangNhap()
        {
            InitializeComponent();
            txt_UsernameCopy = txt_Username;
            pwd_LogInCopy = pwd_Log_in;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pwd_Log_in.UseSystemPasswordChar = !pwd_Log_in.UseSystemPasswordChar;
            Image img = Image.FromFile("../../.././Images/" + (pwd_Log_in.UseSystemPasswordChar ? "hide" : "show") + "_password.png");
            btn_pwd.Image = img;
        }

        private void pwd_Log_In_TextChanged_1(object sender, EventArgs e)
        {

        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = "SELECT Username FROM TKTruongPhong WHERE Username = @usernameLogIn AND Pass_word = @pass_word";
                dndao.KiemTraDangNhap(txt_Username.Text, pwd_Log_in.Text, query);
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

                Main m = new Main();
                m.Show();
                this.Hide();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại \n" + ex.Message);
            }
        }

        private void lbl_notAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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
