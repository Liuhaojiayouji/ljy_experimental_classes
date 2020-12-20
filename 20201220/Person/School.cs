using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class School:Person
    {
        string school;

        public School(string name,string sex,string school):base(name,sex,"")
        {
            this.school = school;
        }
    }
}
