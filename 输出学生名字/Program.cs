using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出学生名字
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Student student1 = new Student(1, "12", 1);
            Student student2 = new Student(4, "11232", 1123);
            Student student3 = new Student(2, "12312", 112345);
            student.Name = "asd";
            student.Id = 1;
            student.Age = 122;
            Console.WriteLine("id:" +
                    student1.Id +
                    "  name:" +
                    student1.Name +
                    "  age:" +
                    student1.Age);
            Console.WriteLine("id:" +
                     student2.Id +
                     "  name:" +
                     student2.Name +
                     "  age:" +
                     student2.Age);
            Console.WriteLine("id:" +
                     student2.Id +
                     "  name:" +
                     student2.Name +
                     "  age:" +
                     student2.Age);
            Console.WriteLine("id:" +
                     student3.Id +
                     "  name:" +
                     student3.Name +
                     "  age:" +
                     student3.Age);
            Console.ReadKey();
        }
    }
}
