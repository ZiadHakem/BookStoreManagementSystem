using BookStore.Core.Entities;
using BookStore.Core.Repositories.Contracts;
using BookStore.Core.Services.Contracts;
using BookStore.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly StoreContext _dbContext;

        public CustomerRepository(StoreContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Customer? CheckIfCustomerExistRepo(string userName, string password)
        {
            var customer = _dbContext.Customers.FirstOrDefault(a => a.UserName == userName && a.Password == password);
            return customer;
        }

        public List<Customer>? CheckIfUserExistRepo(string userName, string password)
        {
            var customers = _dbContext.Customers.Where(c => c.UserName == userName && c.Password == password).ToList();
            if (customers is null)
                return null;
            else
                return customers;
        }

        public List<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public void DeleteCustomer(int customerId)
        {
            var customerToDelete = _dbContext.Customers.Find(customerId);
            if (customerToDelete != null)
            {
                _dbContext.Customers.Remove(customerToDelete);
                _dbContext.SaveChanges();
            }
        }

        Customer? ICustomerRepository.GetCustomerById(int customerId)
        {
            return _dbContext.Customers.FirstOrDefault(c => c.Id == customerId);
        }
    }
}
