using System;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Output(Sorting(into()));
        }

        private static void Output(int[] vs)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }
        }

        private static int[] Sorting(int[] vs1)
        {
            int a;
            for (int j = 0; j < vs1.Length - 1; j++)
            {
                for (int i = 0; i < vs1.Length - 1; i++)
                {
                    if (vs1[i] < vs1[i + 1])
                    {
                        a = vs1[i];
                        vs1[i] = vs1[i + 1];
                        vs1[i + 1] = a;
                    }
                }
            }
            Console.WriteLine("开始输出了");
            return vs1;
        }

        //输入数据 并且将数据转化成 数字类型 数组
        private static int[] into()
        {
            Console.WriteLine("请输入一串数字 用空格分开");
            string name = Console.ReadLine();
            string[] vs = name.Split(" ");
            int[] vs1 = new int[vs.Length];
            for (int i = 0; i < vs.Length; i++)
            {
                vs1[i] = Convert.ToInt32((vs[i]));
            }
            return vs1;
        }
    }
}
