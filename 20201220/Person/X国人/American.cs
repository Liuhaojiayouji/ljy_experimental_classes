﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class American:Person
    {
        public American(string name, string sex, string countrie) : base(name, sex, countrie)
        {
        }

        public void Spec()
        {
            Console.WriteLine("美国大片");
        }
    }
}
