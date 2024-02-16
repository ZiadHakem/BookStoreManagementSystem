using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Services.Contracts
{
    public interface ICategoryService
    {
        public List<CategoryToReturnDTO> GetAllCategories();
        public CheckStatusEnum UpdateCategory(string oldName, string newName);
        public CheckStatusEnum DeleteCategory(string categoryName);
        public CheckStatusEnum CreateCategory(string categoryName);
    }
}
