using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnStr = "Data Source=192.168.31.123;;Initial Catalog=demo;User ID=sa;Password = Password01!";
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                string SQLStr = "select * from Student";
                using (SqlCommand SQLCmd = new SqlCommand(SQLStr,SQLConn))
                {
                    SQLConn.Open();
                    using (SqlDataReader SQLreader = SQLCmd.ExecuteReader()) 
                    {
                        while (SQLreader.Read())
                        {
                            ////int SID = Convert.ToInt32(SQLreader["no"]);
                            ////string Sname = SQLreader["name"].ToString();
                            ////int Sphone = Convert.ToInt32(SQLreader["phone"]);
                            ////int Sage = Convert.ToInt32(SQLreader["age"]);
                            ////string SGebder = SQLreader["gender"].ToString();
                            int SID = Convert.ToInt32(SQLreader[0]);
                            string Sname = SQLreader[1].ToString();
                            int Sphone = Convert.ToInt32(SQLreader[2]);
                            int Sage = Convert.ToInt32(SQLreader[3]);
                            string SGebder = SQLreader[4].ToString();
                            Console.WriteLine(SID);
                            Console.WriteLine(Sname);
                            Console.WriteLine(Sphone);
                            Console.WriteLine(Sage);
                            Console.WriteLine(SGebder);
                            // Console.WriteLine(SQLreader.GetInt32(SQLreader.GetOrdinal("no")));
                        }
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
