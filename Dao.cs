using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using QuanLyCongTy.Models;

namespace QuanLyCongTy
{
    internal class Dao
    {
        public SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public Dao()
        {
            conn = new SqlConnection(Properties.Settings.Default.connStr);
        }
        public DataTable DanhSach(string s)
        {
            string sqlStr = string.Format(s);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

    }
}
