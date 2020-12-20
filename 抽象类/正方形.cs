using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class 正方形 : 图形
    {
        private int x;

        public 正方形(int x)
        {
            this.x = x;
        }

        public int X { get => x; set => x = value; }

        public override void Area()
        {
            Console.WriteLine(x*x);
        }

        public override void Perimeter()
        {
            Console.WriteLine(4*x);
        }
    }
}
