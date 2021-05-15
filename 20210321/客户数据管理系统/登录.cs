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
    public partial class 登录界面 : Form
    {
        public static string MName;
        string ConnStr = ConfigurationManager.ConnectionStrings["CommConn"].ConnectionString;
        public 登录界面()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                string SQLStr = $"select * from accNum where accNumber = '{txtAccountNnumber.Text}'";
                using (SqlCommand SQLCmd = new SqlCommand(SQLStr, SQLConn))
                {
                    SQLConn.Open();
                    int Resultcount = Convert.ToInt32(SQLCmd.ExecuteScalar());
                    if (Resultcount > 0)
                    {
                        //MessageBox.Show("登陆成功");
                        string SQLStr1 = $"select * from accNum where accNumber = '{txtAccountNnumber.Text}'and password='{txtPassword.Text}'";
                        using (SqlConnection SQLConn1 = new SqlConnection(ConnStr))
                        {
                            using (SqlCommand SQLCmd1 = new SqlCommand(SQLStr1, SQLConn1))
                            {
                                SQLConn1.Open();
                                int Resultcount1 = Convert.ToInt32(SQLCmd1.ExecuteScalar());
                                if (Resultcount1 > 0)
                                {
                                    MessageBox.Show("登陆成功");
                                    MName = txtAccountNnumber.Text;
                                    操作 operating = new 操作();
                                    this.Hide();
                                    operating.ShowDialog();
                                    this.Dispose();
                                }
                                else
                                {
                                    MessageBox.Show("密码错误");

                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("账号错误");

                    }
                }
            }
        }

        private void btnRegistered_Click(object sender, EventArgs e)
        {
            注册 registered = new 注册();
            this.Hide();
            registered.ShowDialog();
            this.Dispose();
        }

    }
}
