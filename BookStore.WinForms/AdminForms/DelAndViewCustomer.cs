using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Service;

namespace BookStore.WinForms
{
    public partial class DeleteAndViewCustomer : Form
    {
        public DeleteAndViewCustomer()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Red;
        }

        static StoreContext dbContext = new StoreContext();
        ICustomerService customer = new CustomerService(dbContext);
        private void LoadCustomerData()
        {

            var customers = customer.GetAllCustomersTo();

            dataGridView1.DataSource = customers;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteAndViewCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void BtDelCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0&& TBDelCustomer.Text.Length==0)
            {
                MessageBox.Show("Please select a customer to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int customerId;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                 customerId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            }
            else
            {
                if (!int.TryParse(TBDelCustomer.Text, out customerId))
                {
               
         
                    MessageBox.Show("Please enter a valid number.");
                    return;
                }
            }

           
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
           
                customer.DeleteCustomerTo(customerId); 

                LoadCustomerData();
            }
        
    }
    }
}
