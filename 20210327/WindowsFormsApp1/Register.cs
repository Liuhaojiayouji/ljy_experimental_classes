using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            AccNum accNum = new AccNum();
            accNum.accNumber = txtAccNum.Text.ToString();
            accNum.password = txtPassword.Text.ToString();
            accNum.passwordAgain = txtPasswordAgain.Text.ToString();
            int r = RegisterBLL.UIPassword(accNum);
            if (r == 1)
            {
                int temp = RegisterBLL.GetAcc(accNum);
                if (temp==1)
                {
                    MessageBox.Show("成功");
                }
                else
                {
                    MessageBox.Show("失败");
                }
            }
            else if (r == 0)
            {
                MessageBox.Show("对不起，两次密码输入的不一致");
            }
            else
            {
                MessageBox.Show("请呼叫专业人员，本系统不干活了");
            }


        }
    }
}
