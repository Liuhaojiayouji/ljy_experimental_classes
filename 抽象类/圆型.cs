using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class 圆型:图形
    {
       private int r;

        public 圆型(int r)
        {
            this.r = r;
        }

        public int R { get => r; set => r = value; }

        public override void Area()
        {
            Console.WriteLine(3.14*r*r);
        }
        public override void Perimeter()
        {
            Console.WriteLine(3.14*2*r);
        }
    }
}
