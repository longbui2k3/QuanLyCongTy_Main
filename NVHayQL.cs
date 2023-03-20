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
    public partial class NVHayQL : Form
    {
        public NVHayQL()
        {
            InitializeComponent();
        }
        void LoadingData()
        {
            for (int i = 0; i <= 50; i++)
                Thread.Sleep(10);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (Loading l = new Loading(LoadingData))
            {
                l.ShowDialog(this);
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }

        private void NVHayQL_Load(object sender, EventArgs e)
        {

        }
    }
}
