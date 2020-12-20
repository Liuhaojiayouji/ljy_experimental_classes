using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个数");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            jiaoHuan(a, b);
            Console.ReadKey();
            Console.Read();
        }

        private static void jiaoHuan(int a, int b)
        {
            int c = 0;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("输出值为：");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
