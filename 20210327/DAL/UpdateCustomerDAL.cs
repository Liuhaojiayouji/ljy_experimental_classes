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
  public  class UpdateCustomerDAL
    {
        public int UpdateCustomer(Customers customers)
        {
            string SQLStr = 
                "UPDATE  Customers  SET " +
                "Customer_Name = @CSName," +
                "Customer_Gender= @CSGender," +
                "Customer_Phone=@CSPhone," +
                "Customer_Email=@CSEmail," +
                "Customer_Birthday=@CSBirthday " +
                "WHERE ID = @CS_ID";
            SqlParameter[] SQLps ={
                new SqlParameter("@CSName",customers.Customer_Name),
                new SqlParameter("@CSGender",customers.Customer_Gender),
                new SqlParameter("@CSPhone",customers.Customer_Phone),
                new SqlParameter("@CSEmail",customers.Customer_Email),
                new SqlParameter("@CSBirthday",customers.Customer_Birthday),
                new SqlParameter("@CS_ID",customers.Customer_ID)
            };
            int r = SQLHelper.SQLExcuteNoQuery(SQLStr, SQLps);
            if (r>0)
            {
                return 1;//成功
            }
            else
            {
                return 0;//失败
            }
        }
    }
}
