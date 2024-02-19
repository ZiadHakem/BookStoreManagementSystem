using BookStore.WinForms.CustomerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.WinForms.AdminForms
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void BTViewAndDeleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteAndViewCustomer deleteAndViewCustomer = new DeleteAndViewCustomer();
            deleteAndViewCustomer.ShowDialog();
        }
    }
}
