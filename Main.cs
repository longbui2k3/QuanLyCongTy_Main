using System.Runtime.InteropServices;
 
namespace QuanLyCongTy
{
    public partial class Main : Form
    {
        public static TabControl tc;
        public static TabPage tc_tk;

        private string closeButtonFullPath = "../../../Images/closeTab.png";

        public Main()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            tc = this.tabControl1;
            tc_tk = this.tc_taikhoan;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tabControl2.Visible = false;
            tabControl2.TabPages.RemoveAt(0);
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tc_hrm_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
            }
            TabPage tb = new TabPage();
            tb.Text = "Nhân sự";
            tb.Text += "    ";
            tb.BorderStyle = BorderStyle.Fixed3D;
            tb.Controls.Add(new UCNhanSu());
            for (int i = 0; i < tabControl2.TabCount; i++)
            {
                if (tabControl2.TabPages[i].Text == tb.Text)
                {
                    tabControl2.SelectedTab = tabControl2.TabPages[i];
                    return;
                }
            }
            tabControl2.TabPages.Add(tb);
            tabControl2.SelectedTab = tb;
        }

        private void toolStripSplitButton5_ButtonClick(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
            }
            TabPage tb = new TabPage();
            tb.Text = "Tiền Lương";
            tb.Text += "    ";
            tb.BorderStyle = BorderStyle.Fixed3D;
            tb.Controls.Add(new UCLuong());
            for (int i = 0; i < tabControl2.TabCount; i++)
            {
                if (tabControl2.TabPages[i].Text == tb.Text)
                {
                    tabControl2.SelectedTab = tabControl2.TabPages[i];
                    return;
                }
            }
            tabControl2.TabPages.Add(tb);
            tabControl2.SelectedTab = tb;
        }

        private void toolStripSplitButton7_ButtonClick(object sender, EventArgs e)
        {
            if (tabControl2.Visible == false)
            {
                tabControl2.Visible = true;
            }
            TabPage tb = new TabPage();
            tb.Text = "Thông Tin Cá Nhân";
            tb.Text += "    ";
            tb.BorderStyle = BorderStyle.Fixed3D;
            tb.Controls.Add(new UCThongTinCaNhan());
            for (int i = 0; i < tabControl2.TabCount; i++)
            {
                if (tabControl2.TabPages[i].Text == tb.Text)
                {
                    tabControl2.SelectedTab = tabControl2.TabPages[i];
                    return;
                }
            }
            tabControl2.TabPages.Add(tb);
            tabControl2.SelectedTab = tb;


        }
        private void toolStripSplitButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Show();
        }


        private void tabControl2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tabControl2_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            var tabPage = this.tabControl2.TabPages[e.Index];
            var tabRect = this.tabControl2.GetTabRect(e.Index);
            var closeImage = new Bitmap(closeButtonFullPath);
            e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width-2), tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left);

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl2_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.tabControl2.TabPages.Count; i++)
            {
                var tabRect = this.tabControl2.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap(closeButtonFullPath);
                var imageRect = new Rectangle((tabRect.Right - closeImage.Width),tabRect.Top + (tabRect.Height - closeImage.Height) / 2,closeImage.Width,closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    this.tabControl2.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

       
    }
}