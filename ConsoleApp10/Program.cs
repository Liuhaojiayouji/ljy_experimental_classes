using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个邮箱");
            string str = Console.ReadLine();
            int firstIndex = str.IndexOf("@");
            int lastIndex = str.LastIndexOf("@");
            if (firstIndex != -1 && firstIndex == lastIndex)
            {
                str = str.Substring(0, firstIndex);
            }
            Console.WriteLine("邮箱中的用户名是：" + str);
        }
    }
}
