using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 123, 34, 23, 423, 423, 3, 45, 34245, 12 };
            int GetMax(params int[] max) {
                int x = max[0];
                for (int i = 0; i < max.Length; i++)
                {
                    if (x<max[i])
                    {
                        x = max[i];
                    }
                }
                return x;
            }
            int y = GetMax(a);
            Console.ReadKey();
        }
    }
}
