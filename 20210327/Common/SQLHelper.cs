using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class SQLHelper
    {
        private static string ConnStr = ConfigurationManager.ConnectionStrings["CommConn"].ConnectionString;
        public static int SQLExcuteNoQuery(string CmdStr, params SqlParameter[] p)
        {
            int r = -1;
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                using (SqlCommand SQLCmd = new SqlCommand(CmdStr, SQLConn))
                {
                    SQLConn.Open();
                    SQLCmd.Parameters.AddRange(p);
                    r = SQLCmd.ExecuteNonQuery();
                }
            }
            return r;
        }
        public static object SQLExcuteScalar(string CmdStr, params SqlParameter[] p)
        {
            object t = null;
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                using (SqlCommand SQLCmd = new SqlCommand(CmdStr, SQLConn))
                {
                    SQLConn.Open();
                    SQLCmd.Parameters.AddRange(p);
                    t = SQLCmd.ExecuteScalar();
                }
            }
            return t;

        }
        public static SqlDataReader SQLReader(string CmdStr, params SqlParameter[] p)
        {
            SqlDataReader Reader;
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                using (SqlCommand SQLCmd = new SqlCommand(CmdStr, SQLConn))
                {
                    SQLConn.Open();
                    SQLCmd.Parameters.AddRange(p);
                    Reader = SQLCmd.ExecuteReader(CommandBehavior.CloseConnection);

                }
                return Reader;
            }

        }
        public static DataTable Adapter(string CmdStr, params SqlParameter[] p)
        {
            DataTable dt = new DataTable();
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                SqlDataAdapter Adapter = new SqlDataAdapter(CmdStr, SQLConn);
                SQLConn.Open();
                Adapter.SelectCommand.Parameters.AddRange(p);
                Adapter.Fill(dt);
            }
            return dt;
        }
    }
}
