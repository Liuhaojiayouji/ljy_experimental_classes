using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConStr = "DAta Source =192.168.31.123;;initial Catalog = demo;User ID = sa ;Password= Password01!";
            using (SqlConnection SQLConn = new SqlConnection(ConStr))
            {
                string SqlCmdStr = "select count(*) from student";
                using (SqlCommand SQLCmd = new SqlCommand(SqlCmdStr, SQLConn))
                {
                    SQLConn.Open();
                    object r = SQLCmd.ExecuteScalar();
                    Console.WriteLine(r);
                    Console.ReadKey();
                }
            }
        }
    }
}

