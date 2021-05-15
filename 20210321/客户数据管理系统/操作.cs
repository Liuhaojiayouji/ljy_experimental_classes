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
    public partial class 操作 : Form
    {
        public 操作()
        {
            InitializeComponent();
        }

        string ConnStr = ConfigurationManager.ConnectionStrings["CommConn"].ConnectionString;
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)//查询
        {
            dt.Clear();
            string temp = "";
            if (txtInName.Text != "")
            {
                if (txtInPhone.Text != "")
                {
                    temp = $"UName ='{txtInName.Text}' and UPhoNum = '{txtInPhone.Text}'"; 
                    using (SqlConnection SQLConn = new SqlConnection(ConnStr))
                    {
                       
                        string Cmd = $"select ID from accNum where accNumber='{登录界面.MName}'";
                        int ID = Convert.ToInt32(SQLHelper.SQLExcuteScalar(Cmd));

                        string Cmd1 = $"select  UName 姓名,UphoNum 手机号 from accUName where ID='{ID}' and {temp}";
                        SqlDataAdapter adapter = new SqlDataAdapter(Cmd1, SQLConn);
                        SQLConn.Open();
                        adapter.Fill(dt);
                     
                        dataGridView1.DataSource = dt;
                    }

                }
                else
                {

                    temp = $"UName ='{txtInName.Text}'"; 
                    using (SqlConnection SQLConn = new SqlConnection(ConnStr))
                    {
                        string Cmd = $"select ID from accNum where accNumber='{登录界面.MName}'";
                        int ID = Convert.ToInt32(SQLHelper.SQLExcuteScalar(Cmd));

                        string Cmd1 = $"select  UName 姓名,UphoNum 手机号 from accUName where ID='{ID}' and {temp}";
                        SqlDataAdapter adapter = new SqlDataAdapter(Cmd1, SQLConn);
                        SQLConn.Open();
                        adapter.Fill(dt);
                       
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            else if (txtInPhone.Text != "")
            {

                temp = $"UPhoNum = '{txtInPhone.Text}'"; 
                using (SqlConnection SQLConn = new SqlConnection(ConnStr))
                {
                    string Cmd = $"select ID from accNum where accNumber='{登录界面.MName}'";
                    int ID = Convert.ToInt32(SQLHelper.SQLExcuteScalar(Cmd));

                    string Cmd1 = $"select  UName 姓名,UphoNum 手机号 from accUName where ID='{ID}' and {temp}";
                    SqlDataAdapter adapter = new SqlDataAdapter(Cmd1, SQLConn);
                    SQLConn.Open();
                    adapter.Fill(dt);

                    
                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
            
                MessageBox.Show("对不起，你好像没有输入哦");
            }

        }

        private void button3_Click(object sender, EventArgs e)//查询全部
        {
            dt.Clear();
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                string Cmd = $"select ID from accNum where accNumber='{登录界面.MName}'";
                int ID = Convert.ToInt32(SQLHelper.SQLExcuteScalar(Cmd));
                string SQLCmd = $"select UName 姓名,UphoNum 手机号 from accUName where ID='{ID}'";
                SqlDataAdapter adapter = new SqlDataAdapter(SQLCmd, SQLConn);
                SQLConn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void btnDel_Click(object sender, EventArgs e)//删除客户
        {
            string Cmd = $"select ID from accNum where accNumber='{登录界面.MName}'";
            int ID = Convert.ToInt32(SQLHelper.SQLExcuteScalar(Cmd));
            string Cmd1 = $"DELETE FROM accUName where ID='{ID}' and UName='{txtDelName.Text}'";
            using (SqlConnection SqlConn = new SqlConnection(ConnStr))
            {

                using (SqlCommand SqlCmd = new SqlCommand(Cmd1, SqlConn))
                {
                    SqlConn.Open();
                    int x = SqlCmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)//增加客户
        {
            添加客户 tj = new 添加客户();
            this.Hide();
            tj.ShowDialog();
            this.Dispose();
        }
        private void btnChange_Click(object sender, EventArgs e)//修改密码
        {
            修改密码 changePassword = new 修改密码();
            this.Hide();
            changePassword.ShowDialog();
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            登录界面 dl = new 登录界面();
            this.Hide();
            dl.ShowDialog();
            this.Dispose();
        }

        private void 操作_Load(object sender, EventArgs e)
        {

        }
    }
}
