using QuanLyCongTy.Bus;
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
    public partial class frmChamCong : Form
    {
        private DateTime date;
        public frmChamCong()
        {
            InitializeComponent();
        }


        private readonly ChamCongBus employeeBLL = new ChamCongBus();

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string employeeName = txtMSNV.Text;
            DateTime dt = DateTime.Now;
            employeeBLL.CheckIn(employeeName, dt);
            date = dt;
        }

        /*private void DateSelector_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpChamCong.Value;
            string employeeName = txtMSNV.Text;
            TimeLogDataGridView.DataSource = employeeBLL.ShowDailyTimeLog(employeeName, selectedDate);
        }
        */
        private void btnNghi_Click(object sender, EventArgs e)
        {
            string employeeName = txtMSNV.Text;
            DateTime dt = dtpChamCong.Value;
            string reson = txtLiDo.Text;

            employeeBLL.XinNghi(employeeName, dt, reson);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string employeeName = txtMSNV.Text;
            employeeBLL.CheckOut(employeeName, DateTime.Now, date);
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            string employeeName = txtMSNV.Text;
            List<TimeLog> timeLogs = employeeBLL.GetTimeLogsByEmployeeAndDate(employeeName, DateTime.Today);
            dataGridView1.DataSource = timeLogs;
            lblTotal.Text = employeeBLL.CalculateTotalWorkHours(timeLogs).ToString("N2") + " hours";
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            string employeeName = txtMSNV.Text;
            List<TimeLog> timeLogs = employeeBLL.GetTimeLogsByEmployeeAndDate(employeeName, DateTime.Today);
            dataGridView1.DataSource = timeLogs;
            lblTotal.Text = employeeBLL.CalculateTotalWorkHours(timeLogs).ToString("N2") + " hours";
        }
    }
}
