using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 客户数据管理系统
{
    public partial class 注册 : Form
    {
        public 注册()
        {
            InitializeComponent();
        }
        string ConnStr = ConfigurationManager.ConnectionStrings["CommConn"].ConnectionString;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                MessageBox.Show("您好，您两次密码输入的不一样哦，请重新输入呀");
            }
            else
            {
                using (SqlConnection SQLConn = new SqlConnection(ConnStr))
                {
                    string SQLStr = $"select * from accNum where accNumber = '{txtName.Text}'";
                    using (SqlCommand SQLCmd = new SqlCommand(SQLStr, SQLConn))
                    {
                        SQLConn.Open();
                        int Resultcount = Convert.ToInt32(SQLCmd.ExecuteScalar());
                        if (Resultcount > 0)
                        {
                            MessageBox.Show("对不起，已经有同名账号了");
                        }
                        else
                        {
                            using (SqlConnection SQLConn1 = new SqlConnection(ConnStr))
                            {
                                string InsertStr = $"insert into accNum values(@accNumber,@password)";
                                SqlParameter[] pars = {
                                new SqlParameter("@accNumber",txtName.Text),
                                new SqlParameter("@password",txtPassword.Text),
                                 };

                                int x = SQLHelper.SQLExcuteNoQuery(InsertStr, pars);
                                if (x > 0)
                                {
                                    MessageBox.Show("成功啦");
                                    MessageBox.Show("马上跳转至登录界面");
                                    登录界面 dl = new 登录界面();
                                    this.Hide();
                                    dl.ShowDialog();
                                    this.Dispose();
                                }
                                else
                                {
                                    MessageBox.Show("no");

                                }

                            }
                        }
                    }
                }
            }


        }
    }
}
