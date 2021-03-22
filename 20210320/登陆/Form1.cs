using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace 登陆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEn_Click(object sender, EventArgs e)
        {
            string inUser = textUserName.Text;
            string inWord = textPassword.Text;
         
            string ConnStr = ConfigurationManager.ConnectionStrings["SQLConn"].ConnectionString;//"Data Source=(local);Initial Catalog=demo;User ID=sa;Password = Password01!";
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                string SQLStr = $"select * from Uname where name='{inUser}' and password= '{inWord}'";
                using (SqlCommand SQLCmd = new SqlCommand(SQLStr, SQLConn))
                {
                    SQLConn.Open();
                    int Resultcount = Convert.ToInt32(SQLCmd.ExecuteScalar());
                    if (Resultcount>0)
                    {
                        MessageBox.Show("登陆成功");
                    }
                    else
                    {
                        MessageBox.Show("账号或者密码错误");

                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
