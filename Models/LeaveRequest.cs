using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy.Models
{
    public class LeaveRequest
    {
        public string LeaveRequestID { get; set; }
        public string EmployeeID { get; set; }
        public DateTime LeaveDate { get; set; }
        public string Reason { get; set; }
    }
}
