namespace QuanLyCongTy
{
    public partial class Main : Form
    {
        public static TabControl tc;
        public static TabPage tc_tk;
        public Main()
        {
            InitializeComponent();
            // WindowState = FormWindowState.Maximized;
            tc = this.tabControl1;
            tc_tk = this.tc_taikhoan;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKi dk = new DangKi();
            dk.Show();
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in splitContainer1.Panel2.Controls)
            {
                ctrl.Dispose();
            }
            splitContainer1.Panel2.Controls.Add(new UCLuong());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in splitContainer1.Panel2.Controls)
            {
                ctrl.Dispose();
            }
            UCNhanSu ucns = new UCNhanSu();
            ucns.Location = new Point(10, 0);
            splitContainer1.Panel2.Controls.Add(ucns);

        }

        private void tc_hrm_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmChamCong dlg2 = new frmChamCong();
            dlg2.ShowDialog();
        }
    }
}