using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MD5Helper
    {
        public static string GetMd5(string str) /*创建MD5加密的方法*/
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.Default.GetBytes(str); /*将接受到的密码转为字符数组存放*/
            byte[] MD5string = md5.ComputeHash(buffer);/*将字符数组中的内容进行MD5加密并存入另一个字符数组中*/
            string x = "";
            for (int i = 0; i < MD5string.Length; i++)
            {
                x += MD5string[i].ToString("X2"); /*将字符数组中的字符以格式化的16进制转换并拼接*/
            }
            return x;


        }
    }
}
