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
    public class LogInDAL
    {
        public int LogInCustomerFirst(AccNum accNum)//首先验证是否有此账号
        {
            string SQLStr = "select * from accNum where accNumber = @accNumber";
            SqlParameter[] SQLps ={
                new SqlParameter("@accNumber",accNum.accNumber) };
            object r = SQLHelper.SQLExcuteScalar(SQLStr, SQLps);
            if (r != null)
            {
                return 1;//成功
            }
            else
            {
                return 0;//失败
            }
        }
        public int LogInCustomerSecond(AccNum accNum)//比较密码
        {
            string SQLStr = "select * from accNum where accNumber = @accNumber and password = @password ";
            SqlParameter[] SQLps ={
                new SqlParameter("@accNumber",accNum.accNumber),
                new SqlParameter("@password",MD5Helper.GetMd5(accNum.password))
            };
            object r = SQLHelper.SQLExcuteScalar(SQLStr, SQLps);
            if (r != null)
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
