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
    public class RegisterDAL
    {
        public static int CustomerRegister(AccNum accNum)
        {
            string SQLStr = "insert into accNum values (@accNumber,@password)";
            SqlParameter[] SQLps = {
                new SqlParameter("@accNumber",accNum.accNumber),
                new SqlParameter("@password",MD5Helper.GetMd5(accNum.password))
            };
            int r = SQLHelper.SQLExcuteNoQuery(SQLStr, SQLps);
            if (r > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
