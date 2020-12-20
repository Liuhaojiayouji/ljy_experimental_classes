using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出学生名字
{
    class Student
    {
        private int id;
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 100 && value < 0)
                {
                    age = value;
                }
                else
                {
                    age = 1;
                }
            }
        }
        public Student()
        {
            
        }
        public Student(int id, string name, int age)
        {
            this.Age = age;
            this.Id = id;
            this.Name = name;
        }

    }
}
