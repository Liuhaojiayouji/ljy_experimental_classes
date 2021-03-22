using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnQuary_Click(object sender, EventArgs e)
        {
            string SQLCmd = "Select * from student";
          dataGridView1.DataSource=  SQLHelper.Adapter(SQLCmd);
        }
    }
}
