using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            矩形 jx = new 矩形(21, 31);
            jx.Perimeter();jx.Area();

            圆型 yx = new 圆型(123);
            yx.Area();yx.Perimeter();

            正方形 zfx = new 正方形(23);
            zfx.Perimeter();
            zfx.Area();

            图形[] tx =
            {
                new 矩形(21, 31),
                new 圆型(123),
                new 正方形(23)
            };
            for (int i = 0; i < tx.Length; i++)
            {
                tx[i].Area();
            }
            Console.ReadKey();
        }
    }
}
