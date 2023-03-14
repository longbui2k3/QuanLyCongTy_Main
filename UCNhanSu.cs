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
    public partial class UCNhanSu : UserControl
    {
        public UCNhanSu()
        {
            InitializeComponent();
            UCNhanVien ucnv = new UCNhanVien();
            ucnv.Dock = DockStyle.Fill;
            tp_NhanVien.Controls.Add(ucnv);
        }

        private void tp_NhanVien_Click(object sender, EventArgs e)
        {
            
        }

        private void UCNhanSu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
