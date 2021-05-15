using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FilterCustomersDAL
    {
        public List<Customers> GetFillerList(Customers FilterCS)
        {
            string SQLStr = "select * from Customers where Customer_DelFlag=1 ";//改成逻辑删除
            List<SqlParameter> SQLps = new List<SqlParameter>();
            if (!String.IsNullOrEmpty(FilterCS.Customer_Name))
            {
                SQLStr += " and Customer_Name like @CSName";
                SQLps.Add(new SqlParameter("@CSName", "%" + FilterCS.Customer_Name + "%"));
               
            }
            if (FilterCS.Customer_Gender == "男" || FilterCS.Customer_Gender == "女")
            {
                SQLStr += " and Customer_Gender= @CSGender";
                SQLps.Add(new SqlParameter("@CSGender", FilterCS.Customer_Gender));
            }
            if (!String.IsNullOrEmpty(FilterCS.Customer_Phone))
            {
                SQLStr += " and Customer_Phone like @CSPhone";
                SQLps.Add(new SqlParameter("@CSPhone", "%" + FilterCS.Customer_Phone + "%"));

            }
            if (!String.IsNullOrEmpty(FilterCS.Customer_Email))
            {
                SQLStr += " and Customer_Email like @CSEmail";
                SQLps.Add(new SqlParameter("@CSEmail", "%" + FilterCS.Customer_Email + "%"));

            }

            List<Customers> FilterResult = new List<Customers>();
            DataTable dt = new DataTable();
            dt = SQLHelper.Adapter(SQLStr, SQLps.ToArray());


            foreach (DataRow DTrow in dt.Rows)
            {
                FilterResult.Add(new Customers()
                {

                    Customer_ID = Convert.ToInt32(DTrow["ID"]),
                    Customer_Name = Convert.ToString(DTrow["Customer_Name"]),
                    Customer_Gender = Convert.ToString(DTrow["Customer_Gender"]),
                    Customer_Phone = Convert.ToString(DTrow["Customer_Phone"]),
                    Customer_Email = Convert.ToString(DTrow["Customer_Email"]),
                    Customer_Birthday = Convert.ToDateTime(DTrow["Customer_Birthday"])

                }
            );
            }
            return FilterResult;
        }
    }
}
