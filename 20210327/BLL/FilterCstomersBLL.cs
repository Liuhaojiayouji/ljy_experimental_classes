using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FilterCstomersBLL
    {
        public List<Customers> GetFilterData(Customers FilterCS)
        {
            FilterCustomersDAL filterData = new FilterCustomersDAL();
            return filterData.GetFillerList(FilterCS);

        }
    }
}
