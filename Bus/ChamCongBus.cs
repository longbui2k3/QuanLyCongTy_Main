using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCongTy.Dao;
using QuanLyCongTy.Models;

namespace QuanLyCongTy.Bus
{
    public class ChamCongBus
    {
        private readonly ChamCongDao chamcong = new ChamCongDao();

        // Phương thức để chấm công CHECKIN cho nhân viên
        public void CheckIn(string employeeId, DateTime checkinTime)
        {
            TimeLog timeLog = new TimeLog();
            timeLog.EmployeeID = employeeId;
            timeLog.CheckinTime = checkinTime;
            chamcong.InsertTimeLog(timeLog);
        }

        public void CheckOut(string employeeId, DateTime checkoutTime, DateTime CheckinTime)
        {
            TimeLog timeLog = new TimeLog();
            timeLog.EmployeeID = employeeId;
            timeLog.CheckoutTime = checkoutTime;
            timeLog.CheckinTime = CheckinTime;
            chamcong.UpdateTimeLog(timeLog);
        }

        public void XinNghi(string employeeId, DateTime leaveDate, string reason)
        {
            LeaveRequest leaveRequest = new LeaveRequest();
            leaveRequest.EmployeeID = employeeId;
            leaveRequest.LeaveDate = leaveDate;
            leaveRequest.Reason = reason;

            chamcong.InsertLeaveRequest(leaveRequest);
        }

        public double CalculateTotalWorkHours(List<TimeLog> timeLogs)
        {
            double totalWorkHours = 0;

            for (int i = 0; i < timeLogs.Count; i += 2)
            {
                if (i + 1 < timeLogs.Count)
                {
                    TimeSpan workHours = timeLogs[i + 1].CheckoutTime - timeLogs[i].CheckinTime;
                    totalWorkHours += workHours.TotalHours;
                }
            }
            return totalWorkHours;
        }

        // Phương thức để lấy thông tin chấm công của nhân viên trong ngày
        public List<TimeLog> GetTimeLogsByEmployeeAndDate(string employeeId, DateTime date)
        {
            return chamcong.GetTimeLogsByEmployeeAndDate(employeeId, date);
        }
    }
}
