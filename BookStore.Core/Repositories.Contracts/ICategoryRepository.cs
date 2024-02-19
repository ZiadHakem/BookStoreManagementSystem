using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Repositories.Contracts
{
    public interface ICategoryRepository
    {
        public bool DeleteCategoryRep(string categoryName);
        Category? GetCategoryMatchedByNameRep(string categoryName);
        Category? GetCategoryByNameRep(string categoryName);
        List<CategoryWithBookCountToReturnDTO>? GetCategoryWithBookCount();
    }
}
