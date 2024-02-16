using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using BookStore.Repository.Enums;
using BookStore.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookStore.WinForms
{
    public partial class Orders : Form
    {
        static StoreContext dbContext = new StoreContext();
        IOrderService order = new OrderService(dbContext);

        public Orders()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<OrderStatusEnum> status = new();
            foreach (OrderStatusEnum value in Enum.GetValues(typeof(OrderStatusEnum)))
                status.Add(value);

            comboBox1.DataSource = status;

            dataGridView1.DataSource = order.ReturnOrders();
        }

        private void BtUpdateOrder_Click(object sender, EventArgs e)
        {
            var selectedStatus = (OrderStatusEnum)comboBox1.SelectedItem;
            int orderId;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                orderId = (int)selectedRow.Cells[0].Value;

                if (order.UpdateOrderStatus(orderId, selectedStatus) == CheckStatusEnum.Saved)
                {
                    dataGridView1.DataSource = order.ReturnOrders();
                    MessageBox.Show($"status updated");
                }
                else
                    MessageBox.Show($"status not updated");
            }
        }
    }
}
