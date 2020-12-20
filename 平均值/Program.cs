using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 平均值
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vs =
            {
                12,324,2311,234,1234,123,42,234,1,45,6,356,2
            };
            double perCount = demo01(vs);
            Console.WriteLine(
                               Math.Round(perCount, 2)
                             );
            Console.ReadKey();
        }

        private static double demo01(int[] vs)
        {
            int count = 0;
            for (int i = 0; i < vs.Length; i++)
            {
                count += vs[i];
            }
            return count / vs.Length;
            throw new NotImplementedException();
        }
    }
}
