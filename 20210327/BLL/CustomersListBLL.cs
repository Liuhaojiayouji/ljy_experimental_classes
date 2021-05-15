//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BLL
{
    public class CustomersListBLL
    {
        public List<Customers> CustomersListData()
        {
            CostomerListDAL GetCustomerList = new CostomerListDAL();
            return GetCustomerList.Get_Customers_List();
        }
    }
}