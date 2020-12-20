using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 水仙数
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                int bai = i / 100;
                int shi = i / 10 % 10;
                int ge = i / 1 % 10;

                if (i==(ge*ge*ge+
                        bai*bai*bai+
                        shi*shi*shi))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}