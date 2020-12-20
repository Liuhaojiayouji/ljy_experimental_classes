using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome"); 
            Console.WriteLine("请输入字母");
            string all = "Welcome";
            string name = Console.ReadLine();
            int x = all.IndexOf(name);
            Console.WriteLine(x+1);
        }
    }
}