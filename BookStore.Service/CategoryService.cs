using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Core.Repositories.Contracts;
using BookStore.Core.Services.Contracts;
using BookStore.Repository;
using BookStore.Repository.Data;
using BookStore.Repository.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public class CategoryService : CategoryRepository, ICategoryService
    {
        private readonly StoreContext _dbContext;

        public CategoryService(StoreContext dbContext) : base(dbContext)
            => _dbContext = dbContext;
        public CheckStatusEnum DeleteCategory(string categoryName)
        {
            if (DeleteCategoryRep(categoryName) == true)
                return CheckStatusEnum.Deleted;
            else
                return CheckStatusEnum.Notdeleted;
        }
        public List<CategoryToReturnDTO>? GetAllCategories()
        {

            var categories = GetCategoryWithBookCount();

            if (categories is not null)
            {
                var categoriesToReturn = categories
                .Select((item, index) => new CategoryToReturnDTO()
                {
                    Index = index + 1,
                    Name = item.Category.Name,
                    CountOfBooks = item.BookCount
                })
                .ToList();
                return categoriesToReturn;
            }
            return null;
        }
        public CheckStatusEnum UpdateCategory(string oldName, string newName)
        {

            CheckStatusEnum newNameStatus = Validations.NameCheck(newName);
            if (newNameStatus == CheckStatusEnum.Empty || newNameStatus == CheckStatusEnum.DoesNotMatch)
                return CheckStatusEnum.DoesNotMatch;

            var checkCategoryExisted = GetCategoryMatchedByNameRep(newName);
            if (checkCategoryExisted is not null)
                return CheckStatusEnum.Existed;

            var category = GetCategoryByNameRep(oldName);
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
            CheckStatusEnum NameStatus = Validations.NameCheck(categoryName);
            if (NameStatus == CheckStatusEnum.Empty || NameStatus == CheckStatusEnum.DoesNotMatch)
                return CheckStatusEnum.DoesNotMatch;

            var checkCategoryExisted = GetCategoryMatchedByNameRep(categoryName);
            if (checkCategoryExisted is not null)
                return CheckStatusEnum.Existed;

            Category category = new Category() { Name = categoryName };

            CheckStatusEnum CategoryStatus = Create(category);

            return CategoryStatus;
        }
    }
}
