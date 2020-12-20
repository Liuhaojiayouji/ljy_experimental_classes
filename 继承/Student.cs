using System;

namespace 继承
{
    class Student:Person
    {
        int id; string school;
        public Student(string name,string sex,int id,string school) :base(name,sex)
        {
            this.id = id;
            this.school = school;

            Console.WriteLine("我叫：{0}，性别：{1},学号：{2},在{3}就读。", Name, Sex, id, school);
        }
    }
}
