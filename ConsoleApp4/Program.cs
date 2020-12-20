using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("请输入金额");

            int Cashier=int.Parse(Console.ReadLine());

            Console.WriteLine("请输入是否为会员");

            char Members = char.Parse(Console.ReadLine());

            if (Cashier > 1000)
            {
                Console.WriteLine("实付金额为：{0}", Cashier * 0.8);
                if (Members == '是')
                {
                    Console.WriteLine("赠送200元代金券");
                }else if (Members == '否')
                {
                    Console.WriteLine("赠送50元代金券");
                }
            }
            else
            {
                Console.WriteLine("实付金额为{0}",Cashier);
            }
            Console.ReadKey();
        }
    }
}
