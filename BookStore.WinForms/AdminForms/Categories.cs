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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.WinForms
{
    public partial class Categories : Form
    {
        static StoreContext dbContext = new StoreContext();
        ICategoryService category = new CategoryService(dbContext);
        public Categories()
        {
            InitializeComponent();
        }
        private void Categories_Load(object sender, EventArgs e)
            => DGCategories.DataSource = category.GetAllCategories();
        private void BTAddCategories_Click(object sender, EventArgs e)
        {
            string categoryName = textBox1.Text;

            switch (category.CreateCategory(categoryName))
            {
                case CheckStatusEnum.DoesNotMatch:
                    MessageBox.Show($"your input doesn't match!!");
                    break;
                case CheckStatusEnum.Existed:
                    MessageBox.Show($"there is already category with this name!!");
                    break;
                case CheckStatusEnum.Saved:
                    textBox1.Text = string.Empty;
                    DGCategories.DataSource = category.GetAllCategories();
                    MessageBox.Show($"{categoryName} saved");
                    break;
                case CheckStatusEnum.NotSaved:
                    MessageBox.Show($"{categoryName} Doesn't saved");
                    break;
            }

            DGCategories.DataSource = category.GetAllCategories();
        }
        private void BTUpdateCategories_Click(object sender, EventArgs e)
        {
            string? oldCategoryName = "";
            string? newCategoryName = textBox1.Text;

            if (DGCategories.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGCategories.SelectedRows[0];
                oldCategoryName = selectedRow.Cells[1].Value.ToString();
                switch (category.UpdateCategory(oldCategoryName, newCategoryName))
                {
                    case Core.Enums.CheckStatusEnum.DoesNotMatch:
                        MessageBox.Show($"your input doesn't match!!");
                        break;
                    case Core.Enums.CheckStatusEnum.Existed:
                        MessageBox.Show($"there is already category with this name!!");
                        break;
                    case Core.Enums.CheckStatusEnum.Updated:
                        textBox1.Text = string.Empty;
                        DGCategories.DataSource = category.GetAllCategories();
                        MessageBox.Show($"{oldCategoryName} Updated to {newCategoryName}");
                        break;
                    case Core.Enums.CheckStatusEnum.DoesNotUpdated:
                        MessageBox.Show($"Doesn't updated");
                        break;
                }

                DGCategories.DataSource = category.GetAllCategories();
                textBox1.Text = string.Empty;
            }
        }
        private void BTDelCategories_Click(object sender, EventArgs e)
        {
            string? categoryName = "";
            if (DGCategories.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DGCategories.SelectedRows[0];
                categoryName = selectedRow.Cells[1].Value.ToString();
                if (category.DeleteCategory(categoryName) == CheckStatusEnum.Notdeleted)
                    MessageBox.Show($"{categoryName} has books");
                else
                    DGCategories.DataSource = category.GetAllCategories();
            }
        }
    }
}
