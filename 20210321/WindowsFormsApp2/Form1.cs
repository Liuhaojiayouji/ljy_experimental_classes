using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string SQLStr = "Data source=(local);Initial Catalog=demo;User Id=sa;Password= Password01!";
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)//查询
        {
            using (SqlConnection SQLConn = new SqlConnection(SQLStr))
            {
                string SQLCmd = "select * from student ";
                SqlDataAdapter adapter = new SqlDataAdapter(SQLCmd, SQLConn);
                SQLConn.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)//统计
        {
            using (SqlConnection SQLConn = new SqlConnection(SQLStr))
            {
                string SqlCmd = "select count(*) from student";
                using (SqlCommand SQLCmd = new SqlCommand(SqlCmd, SQLConn))
                {
                    SQLConn.Open();
                    object all = SQLCmd.ExecuteScalar();
                    MessageBox.Show(all.ToString());
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)//删除
        {
            using (SqlConnection SQLConn = new SqlConnection(SQLStr))
            {
                string SqlCmd = $"DELETE FROM student where name = '{txtDelName.Text}'";
                using (SqlCommand SQLCmd = new SqlCommand(SqlCmd, SQLConn))
                {
                    try
                    {
                        SQLConn.Open();
                        SQLCmd.ExecuteNonQuery();
                        MessageBox.Show("恭喜你，操作成功");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("对不起，操作失败");

                    }

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)//添加
        {
            using (SqlConnection SQLConn = new SqlConnection(SQLStr))
            {
                string InsertStr = $"insert into student values(@no,@name,@phone,@age,@gender)";
                SqlParameter[] pars = {
                    new SqlParameter("@no",txtInNo.Text),
                    new SqlParameter("@name",txtInName.Text),
                    new SqlParameter("@phone",txtInPhone.Text),
                    new SqlParameter("@age",txtInAge.Text),
                    new SqlParameter("@gender",txtInGender.Text)
                };

                int x = SQLHelper.SQLExcuteNoQuery(InsertStr, pars);
                if (x>0)
                {
                    MessageBox.Show("yes");
                }
                else
                {
                    MessageBox.Show("no");

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
