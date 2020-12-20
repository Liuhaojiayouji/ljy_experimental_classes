using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机生成10个随机的偶数求和
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int a;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                a = random.Next(1, 101);
                if (!list.Contains(a))
                {
                    list.Add(a);
                }
            }




            a = 0;
            for (int j = 0; j < list.Count; j++)
            {
                a += list[j];
                Console.WriteLine(list[j]);
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
