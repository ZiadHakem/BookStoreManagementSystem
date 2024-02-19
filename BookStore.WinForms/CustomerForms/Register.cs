using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookStore.WinForms.CustomerForms
{
    public partial class Register : Form
    {
        static StoreContext dbContext = new StoreContext();
        private readonly int _customerId;
        ICustomerService customer = new CustomerService(dbContext);
        public Register(int CustomerId)
        {
            InitializeComponent();
            _customerId = CustomerId;
        }

        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerLoginParamsDTO customerLoginParams = new();
            CustomerLoginMsgsDTO customerLoginMsgs = new();

            customerLoginParams.UserName = TBUserName.Text;
            customerLoginParams.Password = TBPassword.Text;
            customerLoginParams.Name = TBName.Text;
            customerLoginParams.Email = TBEmail.Text;
            customerLoginParams.Phone = TBPhone.Text;
            customerLoginParams.Address = TBAddrees.Text;

            customerLoginMsgs = customer.CustomerRegister(customerLoginParams);

            lbNameMsg.Text = customerLoginMsgs.NameMsg;
            lbUserNameMsg.Text = customerLoginMsgs.UserNameMsg;
            lbPasswordMsg.Text = customerLoginMsgs.PasswordMsg;
            lbEmailMsg.Text = customerLoginMsgs.EmailMsg;
            lbPhoneMsg.Text = customerLoginMsgs.PhoneMsg;

            if (customerLoginMsgs.IsSavedMsg == CheckStatusEnum.Saved)
                MessageBox.Show("Customer is saved");
            else
                MessageBox.Show("Customer isn't saved");
        }
    }
}
