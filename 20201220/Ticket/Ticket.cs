using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Ticket
    {
        private int distance;

        public int Distance
        {
            get { return distance; }
            set
            {
                if (value < 0)
                {
                    distance = 0;
                }
                else
                {
                    distance = value;
                }
            }
        }

        public Ticket(int distance)
        {
            if (distance<0)
            {
                this.distance = 0;
            }
            else
            {
                this.distance = distance;
            }
            
        }

        public double GetPrise()
        {
            if (distance > 0 && distance < 100)
            {
                Console.WriteLine("不打折");
                return 1 * distance;
            }
            else if (distance >= 100 && distance < 200)
            {
                Console.WriteLine("九折");
                return 1 * distance * 0.9;
            }
            else if (distance >= 200 && distance < 300)
            {
                Console.WriteLine("八折");
                return 1 * distance * 0.8;
            }
            else if (distance==0)
            {
                Console.WriteLine("你没有乘车");
                return 0;
            }
            else
            {
                Console.WriteLine("五折");
                return 1 * distance * 0.5;
            }
        }
    }
}