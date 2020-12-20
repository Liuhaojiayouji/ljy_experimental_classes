using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201213_作业
{
    class TiMu2
    {
        static void tenRandom(out int a0,
                    out int a1,
                    out int a2,
                    out int a3,
                    out int a4,
                    out int a5,
                    out int a6,
                    out int a7,
                    out int a8,
                    out int a9
                    )
        {
            Random random = new Random();
            a0 = random.Next();
            a1 = random.Next();
            a2 = random.Next();
            a3 = random.Next();
            a4 = random.Next();
            a5 = random.Next();
            a6 = random.Next();
            a7 = random.Next();
            a8 = random.Next();
            a9 = random.Next();
        }
        public void Second()
        {
            Console.WriteLine("开始执行");
            int a0,
                a1,
                a2,
                a3,
                a4,
                a5,
                a6,
                a7,
                a8,
                a9;
            tenRandom(out a0,
                      out a1,
                      out a2,
                      out a3,
                      out a4,
                      out a5,
                      out a6,
                      out a7,
                      out a8,
                      out a9
                );
            Console.WriteLine(a0);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);
            Console.WriteLine(a5);
            Console.WriteLine(a6);
            Console.WriteLine(a7);
            Console.WriteLine(a8);
            Console.WriteLine(a9);
            Console.ReadKey();


        }
    }
}
