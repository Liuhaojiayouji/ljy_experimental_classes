using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Person
    {
        private string name;
        
        private string sex;

        public Person()
        {
        }

        public Person(string name, string sex)
        {
            this.name = name;
           
            this.sex = sex;
        }

        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}
