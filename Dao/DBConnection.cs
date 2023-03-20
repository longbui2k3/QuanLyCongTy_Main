using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy.Dao
{
    public class DBConnection
    {
        private SqlConnection conn;
        public DBConnection()
        {
            conn = new SqlConnection(Properties.Settings.Default.connStr);
        }
    }
}
