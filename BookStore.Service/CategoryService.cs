using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Services.Contracts;
using BookStore.Repository;
using BookStore.Repository.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public class CategoryService : GenericRepository<Category>, ICategoryService
    {
        private readonly StoreContext _dbContext;

        public CategoryService(StoreContext dbContext) : base(dbContext)
            => _dbContext = dbContext;

        public CheckStatusEnum DeleteCategory(string categoryName)
        {
            var category = _dbContext.Categories.Where(c => c.Name == categoryName && c.Books.Count() == 0).FirstOrDefault();
            if (category != null)
            {
                _dbContext.Categories.Remove(category);
                if (_dbContext.SaveChanges() > 0)
                    return CheckStatusEnum.Deleted;
            }
            return CheckStatusEnum.Notdeleted;
        }
        public List<CategoryToReturnDTO> GetAllCategories()
        {
            var categories = _dbContext.Categories
                .Select(c => new
                {
                    Category = c,
                    BookCount = c.Books.Count
                }).ToList();

            var categoriesToReturn = categories
                .Select((item, index) => new CategoryToReturnDTO()
                {
                    Index = index+1,
                    Name = item.Category.Name,
                    CountOfBooks = item.BookCount
                })
                .ToList();

            return categoriesToReturn;
        }
        public CheckStatusEnum UpdateCategory(string oldName, string newName)
        {
           
            CheckStatusEnum newNameStatus = Helper.NameCheck(newName);
            if (newNameStatus == CheckStatusEnum.Empty || newNameStatus ==  CheckStatusEnum.DoesNotMatch)
                return CheckStatusEnum.DoesNotMatch;

            var checkCategoryExisted = _dbContext.Categories.FirstOrDefault(c => c.Name.Replace(" ", "") == newName.Replace(" ", ""));
            if (checkCategoryExisted is not null)
                return CheckStatusEnum.Existed;

            var category = _dbContext.Categories.FirstOrDefault(c => c.Name == oldName);
            if (category != null)
            {
                category.Name = newName;
                if (_dbContext.SaveChanges() > 0)
                    return CheckStatusEnum.Updated;
            }
            return CheckStatusEnum.DoesNotUpdated;
        }
        public CheckStatusEnum CreateCategory(string categoryName)
        {
            CheckStatusEnum NameStatus = Helper.NameCheck(categoryName);
            if (NameStatus == CheckStatusEnum.Empty || NameStatus == CheckStatusEnum.DoesNotMatch)
                return CheckStatusEnum.DoesNotMatch;

            var checkCategoryExisted = _dbContext.Categories.FirstOrDefault(c => c.Name.Replace(" ", "") == categoryName.Replace(" ", ""));
            if (checkCategoryExisted is not null)
                return CheckStatusEnum.Existed;

            Category category = new Category() { Name = categoryName };

            CheckStatusEnum CategoryStatus = Create(category);

            return CategoryStatus;
        }

    }
}
