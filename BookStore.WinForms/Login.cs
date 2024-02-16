using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Service;
using BookStore.WinForms.CustomerForms;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.WinForms
{
    public partial class Login : Form
    {
        static StoreContext dbContext = new StoreContext();
        ICustomerService customer = new CustomerService(dbContext);
        IAdminService admin = new AdminService(dbContext);

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RBAdmin.Checked)
            {
                string userName = TBUserName.Text;
                string password = textBox2.Text;

                if (admin.UserLogin(userName, password) == CheckStatusEnum.Existed)
                {
                    HomeAdmin homeAdmin = new HomeAdmin();
                    homeAdmin.Show();
                }
                else
                    MessageBox.Show("Invalid UserName Or Password!!");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
