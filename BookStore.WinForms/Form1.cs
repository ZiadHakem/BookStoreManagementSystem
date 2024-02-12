using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Service;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace BookStore.WinForms
{
    public partial class Form1 : Form
    {
        static StoreContext dbContext = new StoreContext();
        IAdminService admin = new AdminService(dbContext);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = ConfigurationManager.AppSettings["BookStore"];
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            var testAdmin = await admin.ChekIfUserExist(userName, password);

            if (testAdmin is null)
                Text = "Wrong!!";
            else if (userName.Equals(testAdmin.UserName, StringComparison.Ordinal) &&
                password.Equals(testAdmin.Password, StringComparison.Ordinal))
                Text = $"{ConfigurationManager.AppSettings["BookStore"]} - {testAdmin.Name}";
            else
                Text = "Wrong!!";
        }
    }
}
