using BLL;
using Model;
using System;
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
    public partial class UpdateCustomer : Form
    {


        public UpdateCustomer()
        {
            InitializeComponent();
        }

        int CS_ID;
        public UpdateCustomer(int ID,string Name,string Gender,string Email,string phone,DateTime Birthday)
        {
            InitializeComponent();
            CS_ID = ID;
            txtName.Text = Name;
            txtGender.Text = Gender;
            txtEmail.Text = Email;
            txtPhone.Text = phone;
            dtBirthday.Value = Birthday;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Customer_Name = txtName.Text.ToString();
            customers.Customer_Gender = txtGender.Text.ToString();
            customers.Customer_Phone = txtPhone.Text.ToString();
            customers.Customer_Email = txtEmail.Text.ToString();
            customers.Customer_Birthday = dtBirthday.Value.Date;
            customers.Customer_ID = CS_ID;
            UpdateCustomerBLL update = new UpdateCustomerBLL();
            int r = update.GetUpdateCustomer(customers);
            switch (r)
            {
                case 1:
                    MessageBox.Show("更新成功");
                    break;
                case 2:
                    MessageBox.Show("更新失败");
                    break;
            }
            this.Close();


        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
