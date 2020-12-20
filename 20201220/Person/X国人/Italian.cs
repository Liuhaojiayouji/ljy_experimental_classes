using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Italian:Person
    {
        public void Spec()
        {
            Console.WriteLine("文艺复兴");
        }
        public Italian(string name, string sex, string countrie) : base(name, sex, countrie)
        {

        }
    }
}
