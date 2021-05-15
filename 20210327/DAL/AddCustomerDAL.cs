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
    public class AddCustomerDAL
    {
        public int InsertCustomer(Customers customers)
        {
            string SQLStr = "insert into Customers values(@CSName,@CSGender,@CSPhone,@CSEmail,@CSBirthday,@Customer_AccNum_ID,@Customer_DelFlag)";
            SqlParameter[] SQLps ={
                new SqlParameter("@CSName",customers.Customer_Name),
                new SqlParameter("@CSGender",customers.Customer_Gender),
                new SqlParameter("@CSPhone",customers.Customer_Phone),
                new SqlParameter("@CSEmail",customers.Customer_Email),
                new SqlParameter("@CSBirthday",customers.Customer_Birthday),

                new SqlParameter("Customer_AccNum_ID",1),
                new SqlParameter("Customer_DelFlag",1)

            };
            int r = SQLHelper.SQLExcuteNoQuery(SQLStr, SQLps);
            return r;
        }
    }
}
