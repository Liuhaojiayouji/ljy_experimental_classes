using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Teacher:Person
    {
        int wage;
        string school;

        public Teacher(string name,string sex, int wage, string school):base(name,sex)
        {
            this.wage = wage;
            this.school = school;
            Console.WriteLine("我是：{0}，性别：{1},在{2}工作，月薪：{3}",Name,Sex,school,wage);
        }
    }
}
