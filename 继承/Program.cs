using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            new Student("asd","中侨",12, "男");
        
            Person person = new Student("asd", "中侨", 12, "男");
            Student[] students =
             {
                new Student("asd","中侨",12, "男")
        };
            students[0].ToString(); Console.ReadKey();
        }
    }
}
