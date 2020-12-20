using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        enum Genders
        {
            男=1, 
            女=0
        }
        static void Main(string[] args)
        {
            Genders genders = Genders.男;
            Console.WriteLine((int)genders);
            Console.ReadKey();
            
        }
    }
}
