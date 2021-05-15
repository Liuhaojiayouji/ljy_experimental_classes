using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AddCustomerBLL
    {
        public int GetAddResult(Customers customers)
        {
            AddCustomerDAL AddCS = new AddCustomerDAL();
            int r  = AddCS.InsertCustomer(customers);
            if (r>0)
            {
                return 1;//表示成功
            }
            else
            {
                return 2;//表示失败
            }
        }
    }
}
