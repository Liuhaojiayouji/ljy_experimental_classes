using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vs = { 10, 3, 4, 2, 32, 4, 5, 2, 345, 5 };
            int a;
            for (int j = 0; j < vs.Length - 1; j++)
            {
                for (int i = 0; i < vs.Length - 1; i++)
                {
                    if (vs[i] < vs[i + 1])
                    {
                        a = vs[i];
                        vs[i] = vs[i + 1];
                        vs[i + 1] = a;
                    }
                }
            }
            
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }
        }
    }
}
