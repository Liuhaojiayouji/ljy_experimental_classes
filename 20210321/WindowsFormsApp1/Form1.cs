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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string SQLStr = "Data Source = (local); Initial Catalog=demo;User ID=sa; Password= Password01!";
        DataTable dt = new DataTable();
        private void btQuary_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection SQLConn = new SqlConnection(SQLStr))
            {

             
                string SQLCmd = "select * from student";
                SqlDataAdapter Adapter= new SqlDataAdapter(SQLCmd,SQLConn);
                SQLConn.Open();
                Adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection SQLConn =new SqlConnection(SQLStr))
            {
                string SQLCmd = "select * from student";
                SqlDataAdapter Adapter = new SqlDataAdapter(SQLCmd, SQLConn);
                SQLConn.Open();
                SqlCommandBuilder SQLB = new SqlCommandBuilder(Adapter);
                Adapter.Update(dt);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
