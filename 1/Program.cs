using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "asd";
            student.Id = 1;
            student.Age = 122;
            Console.WriteLine("id:" +
                    student.Id +
                    "  name:" +
                    student.Name +
                    "  age:" +
                    student.Age);
            Console.ReadKey();
        }
    }
}
