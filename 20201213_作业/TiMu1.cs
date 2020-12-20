using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201213_作业
{
    class TiMu1
    {
        public void First()
        {
            Console.WriteLine("请输入一个年份");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 != 0)
            {
                Console.WriteLine("{0}年不是闰年", year);
            }
            else if (year % 100 == 0 && year % 400 != 0)
            {
                Console.WriteLine("{0}年不是闰年", year);
            }
            else
            {
                Console.WriteLine("{0}年是闰年", year);
            }
            Console.ReadKey();

        }
    }
}
