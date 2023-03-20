using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy.Bus
{
    public class TimeLog
    {

        public int TimeLogID { get; set; }
        public string EmployeeID { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public float ToTalTime { get; set; }
        public TimeLog() { }
        public TimeLog(DateTime checkinTime)
        {
            CheckinTime = checkinTime;
        }

        public void SetCheckoutTime(DateTime checkoutTime)
        {
            CheckoutTime = checkoutTime;
        }
        public TimeSpan ToTalTimes()
        {
            return CheckoutTime - CheckinTime;
        }
        
    }
}
