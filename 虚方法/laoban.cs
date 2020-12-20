using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚方法
{
    class laoban:staff
    {
        public override void checkin()
        {
            Console.WriteLine("老板无需考勤");
        }
    }
}
