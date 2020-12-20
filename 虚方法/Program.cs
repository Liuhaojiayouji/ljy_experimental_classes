using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            staff[] staffs =
            {
                new laoban(),
                new jingli(),
                new zhigong(),
                new baojie()
        };
            for (int i = 0; i < staffs.Length; i++)
            {
                staffs[i].checkin();
            }
            Console.ReadKey();
        }
    }
}
