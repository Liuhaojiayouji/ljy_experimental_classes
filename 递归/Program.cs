using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 递归
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            writeHappy(a);
            Console.ReadKey();
        }

        private static void writeHappy(int a)
        {

            for (; a > 0; a--)
            {
                writeHappy(a);
            }
            Console.WriteLine("圣诞快乐");
        }
    }
}
