//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp3
{
    public class SQLHelper
    {
        private static string ConnStr = ConfigurationManager.ConnectionStrings["CommConn"].ConnectionString;
        public int SQLExcuteNoQuery(string CmdStr, params SqlParameter[] p)
        {
            int r = -1;
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                using (SqlCommand SQLCmd = new SqlCommand(CmdStr, SQLConn))
                {
                    SQLConn.Open();
                    SQLCmd.Parameters.Add(p);
                    r = SQLCmd.ExecuteNonQuery();
                }
            }
            return r;
        }
    }
}