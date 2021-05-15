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
    public class LogInBLL
    {
        public int GetIfAccNum(AccNum accNum)
        {
            LogInDAL logInDAL = new LogInDAL();
            if (logInDAL.LogInCustomerFirst(accNum) == 1)
            {
                if (logInDAL.LogInCustomerSecond(accNum) == 1)
                {
                    return 0;//正确
                }
                else
                {
                    return 2;//密码错误
                }
            }
            else
            {
                return 1;//账号错误
            }
        }
    }
}