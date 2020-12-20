using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出数组中名字最长的名字
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vs =
            {
                "asdasdfgwe",
                "asd",
                "asdsdar",
                "asdssa",
            };
            Console.WriteLine(getLongest(vs));
            Console.ReadKey();
        }

        private static string getLongest(string[] vs)
        {
            string x = vs[0];
            int a = vs[0].Length;
            for (int i = 1; i < vs.Length; i++)
            {
                if (vs[i].Length>a)
                {
                    x = vs[i];
                }
            }
            return x;
            throw new NotImplementedException();
        }
    }
}
