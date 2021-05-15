using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
 public  class UpdateCustomerBLL
    {
        public int GetUpdateCustomer(Customers customers)
        {
            UpdateCustomerDAL updateCustomerBAL = new UpdateCustomerDAL();
            int r= updateCustomerBAL.UpdateCustomer(customers);
            if (r==1)
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
