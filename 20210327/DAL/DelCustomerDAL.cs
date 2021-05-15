using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DelCustomerDAL
    {
        public int DeleterCustomer(Customers customers)
        {
            string SQLStr = $"UPDATE  Customers  SET   Customer_DelFlag = 0 WHERE ID = @CSID";
            SqlParameter[] SQLps = { new SqlParameter("@CSID", customers.Customer_ID) };
            int r = SQLHelper.SQLExcuteNoQuery(SQLStr, SQLps);
            return r;
        }
    }
}
