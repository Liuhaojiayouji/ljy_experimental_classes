using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 质数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数"); int count = Convert.ToInt32(Console.ReadLine());
            demo01(count);
        }

       

        private static void demo02()
        {
            int a = 0;int b = 0;
            for (int i = 1; i < 101; i++)
            {
                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        a++;
                    }
                }
                if (a == 0)
                {
                    b += i;
                }
            }
            Console.WriteLine(b); 
            Console.ReadKey();
        }

        private static void demo01(int count)
        {
            int a = 0;
            for (int i = 2; i < count; i++)
            {
                if (count % i == 0)
                {
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("质数");
            }
            else
            {
                Console.WriteLine("不是");
            }
            Console.ReadKey();
        }
    }
}
