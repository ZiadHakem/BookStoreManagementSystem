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
        CheckStatusEnum DeleteCategory(string categoryName);
        List<CategoryToReturnDTO>? GetAllCategories();
        CheckStatusEnum UpdateCategory(string oldName, string newName);
        CheckStatusEnum CreateCategory(string categoryName);
    }
}
