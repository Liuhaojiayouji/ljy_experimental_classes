﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入距离");
            Console.WriteLine(new Ticket(Convert.ToInt32(Console.ReadLine())).GetPrise());
            Console.ReadKey();
        }
    }
}
