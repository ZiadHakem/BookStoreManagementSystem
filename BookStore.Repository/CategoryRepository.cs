using AutoMapper;
using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Repositories.Contracts;
using BookStore.Repository.Data;
using BookStore.Repository.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly StoreContext _dbContext;

        public CategoryRepository(StoreContext dbContext) : base(dbContext)
            => _dbContext = dbContext;

        public bool DeleteCategoryRep(string categoryName)
        {
            var category = _dbContext.Categories.Where(c => c.Name == categoryName && c.Books.Count() == 0).FirstOrDefault();
            if (category != null)
                if(Delete(category) == true)
                    return true;
            return false;
        }
        
        public Category? GetCategoryMatchedByNameRep(string categoryName)
            => _dbContext.Categories.FirstOrDefault(c => c.Name.Replace(" ", "") == categoryName.Replace(" ", ""));

        public Category? GetCategoryByNameRep(string categoryName)
            => _dbContext.Categories.FirstOrDefault(c => c.Name == categoryName);

        public List<CategoryWithBookCountToReturnDTO>? GetCategoryWithBookCount()
        {
            var categories = _dbContext.Categories.Select(c => new CategoryWithBookCountToReturnDTO
                                {
                                    Category = c,
                                    BookCount = c.Books.Count
                                }).ToList();
            return categories;
        }
    }
}
