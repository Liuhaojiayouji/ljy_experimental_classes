//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace DAL
{
    public class CostomerListDAL
    {
        public List<Customers> Get_Customers_List()
        {
            string SQLStr = "select * from Customers";
            DataTable dt = new DataTable();
            List<Customers> customersList = new List<Customers>();
            dt = SQLHelper.Adapter(SQLStr);
            foreach (DataRow DTrow in dt.Rows)
            {
                customersList.Add(new Customers()
                {
                    Customer_ID =  Convert.ToInt32(DTrow["ID"]),
                    Customer_Name=Convert.ToString(DTrow["Customer_Name"]),
                    Customer_Gender = Convert.ToString(DTrow["Customer_Gender"]),
                    Customer_Phone = Convert.ToString(DTrow["Customer_Phone"]),
                    Customer_Email = Convert.ToString(DTrow["Customer_Email"]),
                    Customer_Birthday = Convert.ToDateTime(DTrow["Customer_Birthday"])
                }
                );
            }
            return customersList;
        }
    }
}