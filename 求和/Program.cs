using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求和
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(QiuHe(1,2));
            Console.WriteLine(QiuHe(1.1,2.1));
            Console.WriteLine(QiuHe(0.123,0.122));
        }

        private static int QiuHe(int a, int b)
        {
            return a + b;
            throw new NotImplementedException();
        }
        private static double QiuHe(double a, double b)
        {
            return a + b;
            throw new NotImplementedException();
        }
        private static float QiuHe(float a, float b)
        {
            return a + b;
            throw new NotImplementedException();
        }


    }

}
