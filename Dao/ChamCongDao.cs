using QuanLyCongTy.Bus;
using QuanLyCongTy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyCongTy.Dao
{
    public class ChamCongDao
    {
        public bool checkin = false;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public List<TimeLog> GetTimeLogsByEmployeeAndDate(string employeeId, DateTime date)
        {
            List<TimeLog> timeLogs = new List<TimeLog>();

            string query = "SELECT TimeLogID, EmployeeID, CheckinTime, CheckoutTime, TotalWorkHours " +
                           "FROM TimeLog " +
                           "WHERE EmployeeID = @EmployeeID AND CONVERT(date, CheckinTime) = CONVERT(date, @Date)";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@EmployeeID", employeeId);
                command.Parameters.AddWithValue("@Date", date);

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TimeLog timeLog = new TimeLog();
                    timeLog.TimeLogID = Convert.ToInt32(reader["TimeLogID"]);
                    timeLog.EmployeeID = Convert.ToString(reader["EmployeeID"]);
                    timeLog.CheckinTime = Convert.ToDateTime(reader["CheckinTime"]);

                    if (reader["CheckoutTime"] != DBNull.Value)
                    {
                        timeLog.CheckoutTime = Convert.ToDateTime(reader["CheckoutTime"]);
                    }

                    timeLogs.Add(timeLog);
                }
            }
            conn.Close();
            return timeLogs;
        }

        public void InsertTimeLog(TimeLog timeLog)
        {
            if (!checkin)
            {
                try
                {
                    string query = "INSERT INTO TimeLog (EmployeeID, CheckinTime) " +
                               "VALUES (@EmployeeID, @CheckinTime)";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", timeLog.EmployeeID);
                        command.Parameters.AddWithValue("@CheckinTime", timeLog.CheckinTime);

                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Đã checkin lúc {timeLog.CheckinTime:hh:mm tt}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("loi");
                }
                finally
                {
                    conn.Close();
                    checkin = true;
                }
            }
            else
            {
                MessageBox.Show("Ban da checkin roi");
            }
        }

        public void UpdateTimeLog(TimeLog timeLog)
        {
            if (checkin)
            {
                try
                {

                    string query = "UPDATE TimeLog " +
                                   "SET CheckoutTime = @CheckoutTime, TotalWorkHours = @TotalWorkHours " +
                                   "WHERE EmployeeID = @EmployeeID and CheckinTime = @CheckinTime ";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@CheckoutTime", timeLog.CheckoutTime);
                        command.Parameters.AddWithValue("@EmployeeID", timeLog.EmployeeID);
                        command.Parameters.AddWithValue("@TotalWorkHours", timeLog.ToTalTimes().TotalHours);
                        command.Parameters.AddWithValue("@CheckinTime", timeLog.CheckinTime);
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show($"Đã checkout lúc {timeLog.CheckoutTime:hh:mm tt}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("loi");
                }
                finally
                {
                    conn.Close();
                    checkin = false;
                }
            }
            else
            {
                MessageBox.Show("Ban chua checkin");
            }
        }

        public void InsertLeaveRequest(LeaveRequest leaveRequest)
        {
            string query = "INSERT INTO LeaveRequest (EmployeeID, LeaveDate, Reason) " +
                           "VALUES (@EmployeeID, @LeaveDate, @Reason)";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@EmployeeID", leaveRequest.EmployeeID);
                command.Parameters.AddWithValue("@LeaveDate", leaveRequest.LeaveDate);
                command.Parameters.AddWithValue("@Reason", leaveRequest.Reason);

                conn.Open();
                command.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}
