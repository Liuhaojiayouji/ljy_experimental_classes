using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class 矩形:图形
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public 矩形(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Area()
        {
            Console.WriteLine(X * Y);
            
        }

        public override void Perimeter()
        {
            Console.WriteLine((X+Y)*2);
        }
    }
}
