namespace QuanLyCongTy
{
    public partial class Main : Form
    {
        public static TabControl tc;
        public static TabPage tc_tk;
        public Main()
        {
            InitializeComponent();
            tc = this.tabControl1;
            tc_tk = this.tc_taikhoan;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKi dk = new DangKi();
            dk.Show();
        }

        private void workplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workplace wp = new Workplace();
            wp.Show();
        }

        private void cRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRM crm = new CRM();
            crm.Show();
        }

        private void hRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HRM hrm = new HRM();
            hrm.Show();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}