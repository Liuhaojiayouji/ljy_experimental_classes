using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DelCustomerBLL
    {
        public int GetDelResult(Customers customers)
        {
            DelCustomerDAL DelCS = new DelCustomerDAL();
            int r = DelCS.DeleterCustomer(customers);
            if (r > 0)
            {
                return 1;//成功
            }
            else
            {
                return 2;//失败
            }
        }
    }
}
