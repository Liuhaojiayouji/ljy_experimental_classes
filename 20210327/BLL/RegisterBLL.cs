using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RegisterBLL
    {
        public static int UIPassword(AccNum accNum)
        {
            if (accNum.password==accNum.passwordAgain)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int GetAcc(AccNum accNum)
        {
            int r = RegisterDAL.CustomerRegister(accNum);
            if (r==1)
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
