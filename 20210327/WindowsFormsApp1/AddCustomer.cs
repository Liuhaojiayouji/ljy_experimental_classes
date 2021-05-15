using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Customer_Name = txtName.Text.ToString();
            customers.Customer_Gender = txtGender.Text.ToString();
            customers.Customer_Phone = txtPhone.Text.ToString();
            customers.Customer_Email = txtEmail.Text.ToString();
            customers.Customer_Birthday = dtBirthday.Value.Date;

            AddCustomerBLL cusomer = new AddCustomerBLL();
            int r = cusomer.GetAddResult(customers);
            switch (r)
            {
                case 1:
                    MessageBox.Show("插入成功");
                    break;
                case 2:
                    MessageBox.Show("插入失败");
                    break;
            }
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
