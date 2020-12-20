using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] vs = new int[10]; int x = vs[0];
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = random.Next();
                Console.WriteLine(vs[i]);
            }
            int GetMax(params int[] max)
            {
                x = max[0];
                for (int i = 0; i < max.Length; i++)
                {
                    if (x < max[i])
                    {
                        x = max[i];
                    }
                }
                return x;
            }
            int y = GetMax(vs);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
