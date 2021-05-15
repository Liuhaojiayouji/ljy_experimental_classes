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
    public partial class 添加客户 : Form
    {
        public 添加客户()
        {
            InitializeComponent();
        }
        string ConnStr = ConfigurationManager.ConnectionStrings["CommConn"].ConnectionString;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                string SQLStr = $"select * from accUName where ID=" +
                    $"(select ID from accNum where accNumber='{登录界面.MName}')" +
                    $" and UName = '{txtName.Text}'";
                using (SqlCommand SQLCmd = new SqlCommand(SQLStr, SQLConn))
                {
                    SQLConn.Open();
                    int Resultcount = Convert.ToInt32(SQLCmd.ExecuteScalar());
                    if (Resultcount > 0)
                    {
                        MessageBox.Show("对不起，已经有相同姓名了");
                    }
                    else
                    {

                        using (SqlConnection SQLConn1 = new SqlConnection(ConnStr))
                        {
                            string Cmd = $"select ID from accNum where accNumber='{登录界面.MName}'";
                            int ID = Convert.ToInt32(SQLHelper.SQLExcuteScalar(Cmd));
                            string InsertStr = $"insert into accUName values(@ID,@UName,@UPhoNum)";
                            SqlParameter[] pars = {
                               new SqlParameter("@ID",ID),
                                new SqlParameter("@UName",txtName.Text),
                                new SqlParameter("@UPhoNum",txtPhone.Text),
                                 };

                            int x = SQLHelper.SQLExcuteNoQuery(InsertStr, pars);
                            if (x > 0)
                            {
                                MessageBox.Show("成功啦");

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            操作 operating = new 操作();
            this.Hide();
            operating.ShowDialog();
            this.Dispose();
        }

        private void 添加客户_Load(object sender, EventArgs e)
        {

        }
    }
}
