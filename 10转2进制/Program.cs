using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10转2进制
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(demo01());
            Console.ReadKey();
        }

        private static string demo01()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            return Convert.ToString(a, 2);
        }
    }
}