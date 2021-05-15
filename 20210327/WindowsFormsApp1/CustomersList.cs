using BLL;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomersList : Form
    {
        public CustomersList()
        {
            InitializeComponent();
        }

        private void CustomersList_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            ArrayList list = new ArrayList();
            list.Add(new DictionaryEntry(0, "未选择"));
            list.Add(new DictionaryEntry(1, "男"));
            list.Add(new DictionaryEntry(2, "女"));
            cBGender.DisplayMember = "Value";
            cBGender.ValueMember = "value";
            cBGender.DataSource = list;


        }

        private void LoadCustomers()
        {
            CustomersListBLL GetCustomerQuery = new CustomersListBLL();
            dataGridView1.DataSource = GetCustomerQuery.CustomersListData();
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            CustomersListBLL GetCustomersQuery = new CustomersListBLL();
            dataGridView1.DataSource = GetCustomersQuery.CustomersListData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.Show();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;

            if (rows.Count > 0)
            {
                DialogResult DELConfirm = MessageBox.Show("请问是否删除", "提示", MessageBoxButtons.OKCancel);
                if (DELConfirm == DialogResult.OK)
                {
                    int RowID = Convert.ToInt32(rows[0].Cells[0].Value);
                    Customers customers = new Customers();
                    customers.Customer_ID = RowID;
                    DelCustomerBLL delCustomerBLL = new DelCustomerBLL();
                    int r = delCustomerBLL.GetDelResult(customers);
                    switch (r)
                    {
                        case 1:
                            MessageBox.Show("删除成功");
                            break;
                        case 2:
                            MessageBox.Show("删除失败");
                            break;
                    }

                }
            }
            else
            {
                MessageBox.Show("无数据");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            int RowID = Convert.ToInt32(rows[0].Cells[0].Value);
            string RowCSName = Convert.ToString(rows[0].Cells[1].Value);
            string RowCSGender = Convert.ToString(rows[0].Cells[2].Value);
            string RowCSPhone = Convert.ToString(rows[0].Cells[3].Value);
            string RowCSEmail = Convert.ToString(rows[0].Cells[4].Value);
            DateTime RowCSBirthday = Convert.ToDateTime(rows[0].Cells[5].Value);
            UpdateCustomer updateCustomer = new UpdateCustomer(RowID, RowCSName, RowCSGender, RowCSEmail, RowCSPhone, RowCSBirthday);
            updateCustomer.Show();
        }

        private void btQuery_Click_1(object sender, EventArgs e)
        {

            Customers customers = new Customers();
            customers.Customer_Name = txtName.Text.ToString();
            customers.Customer_Gender = cBGender.SelectedValue.ToString();
            customers.Customer_Phone = txtPhone.Text.ToString();
            customers.Customer_Email = txtEmail.Text.ToString();

            FilterCstomersBLL FinalData = new FilterCstomersBLL();
            dataGridView1.DataSource = FinalData.GetFilterData(customers);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
