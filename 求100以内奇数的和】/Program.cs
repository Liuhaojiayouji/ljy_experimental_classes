using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求100以内奇数的和_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i%2==1)
                {
                    count = count + i;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
