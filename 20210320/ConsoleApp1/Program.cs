using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ConStr = "server=.; database = demo;uid=sa;Password = Password01!";//.可以是IP 或者是 主机名/域名      SQL Sever 2016 配置管理器
            //string ConStr = "Data Source=(local);Initial Catalog=demo;User ID=sa;Password = Password01!";
            //SqlConnection SQLConn = new SqlConnection(ConStr);
            //SqlCommand SQLCmd = new SqlCommand();
            //SQLCmd.Connection = SQLConn;
            //SQLConn.Open();
            //SQLCmd.CommandText = "insert  into Student values(9,'小九',123123123,12,'女')";
            //SQLCmd.ExecuteNonQuery();//返回受影响行数
            //SQLConn.Dispose();

            //Console.WriteLine("插入成功");
            //Console.ReadKey();
            string ConStr = "Data Source=(local);Initial Catalog=demo;User ID=sa;Password = Password01!";
            using (SqlConnection SqlConn =new SqlConnection(ConStr))
            {
                string SQLStr = "insert  into Student values(10,'小十',123123123,12,'女')";
                using (SqlCommand SqlCmd =new SqlCommand(SQLStr,SqlConn))
                {
                    SqlConn.Open();
                    int x = SqlCmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        Console.WriteLine("插入成功");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("插入未成功");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
