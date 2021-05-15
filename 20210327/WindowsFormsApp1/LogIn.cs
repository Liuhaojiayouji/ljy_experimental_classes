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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            AccNum accNum = new AccNum();
            accNum.accNumber = txtAccNum.Text.ToString();
            accNum.password = txtPassword.Text.ToString();

            LogInBLL logInBLL = new LogInBLL();
            switch (logInBLL.GetIfAccNum(accNum))
            {
                case 0:
                    MessageBox.Show("登录成功");
                    CustomersList customers = new CustomersList();
                    this.Hide();
                    customers.ShowDialog();
                    this.Dispose();
                    break;
                case 1:
                    MessageBox.Show("账号错误");
                    break;
                case 2:
                    MessageBox.Show("密码错误");
                    break;

            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
