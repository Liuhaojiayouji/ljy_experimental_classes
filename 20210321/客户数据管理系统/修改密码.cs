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
    public partial class 修改密码 : Form
    {
        public 修改密码()
        {
            InitializeComponent();
        }
        string ConnStr = ConfigurationManager.ConnectionStrings["CommConn"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                MessageBox.Show("两次密码输入的不相同哦");
            }
            else
            {
                using (SqlConnection SQLConn = new SqlConnection(ConnStr))
                {

                    string SQLStr = $"UPDATE accNum SET password = {txtPassword.Text} WHERE accNumber = '{登录界面.MName}'";
                    int Resultcount = SQLHelper.SQLExcuteNoQuery(SQLStr);

                    if (Resultcount > 0)
                    {
                        MessageBox.Show("更改成功");
                        //返回操作界面
                        操作 operating = new 操作();
                        this.Hide();
                        operating.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("更改失败");
                    }
                }
            }
        }

        private void 修改密码_Load(object sender, EventArgs e)
        {

        }
    }
}
