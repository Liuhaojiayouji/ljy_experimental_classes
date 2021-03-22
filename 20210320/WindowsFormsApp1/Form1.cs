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

        private void btn1_Click(object sender, EventArgs e)
        {
            string ConnStr = "Data Source=(local);Initial Catalog=demo;User ID=sa;Password = Password01!";
            using (SqlConnection SQLConn = new SqlConnection(ConnStr))
            {
                string SQLStr = "select * from Student";
                using (SqlCommand SQLCmd = new SqlCommand(SQLStr, SQLConn))
                {
                    SQLConn.Open();
                    using (SqlDataReader Reader = SQLCmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView1.Columns.Add("ID", "编号");
                        dataGridView1.Columns.Add("Name", "姓名");
                        dataGridView1.Columns.Add("Age", "年龄");
                        dataGridView1.Columns.Add("Gender", "性别");
                        dataGridView1.Columns.Add("Score", "手机号");

                        while (Reader.Read())
                        {
                            Studnent studnent = new Studnent();
                            studnent.ID = Convert.ToInt32(Reader["no"]);
                            studnent.Name = Convert.ToString(Reader["name"]);
                            studnent.Age = Convert.ToInt32(Reader["age"]);
                            studnent.Gender = Convert.ToString(Reader["gender"]);
                            studnent.Score = Convert.ToInt32(Reader["phone"]);
                            dataGridView1.Rows.Add(studnent.ID, studnent.Name, studnent.Age, studnent.Gender, studnent.Score);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
