using AutoMapper;
using BookStore.Core.DTOs;
using BookStore.Core.Entities;
using BookStore.Core.Enums;
using BookStore.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookStore.Service
{
    public static class Helper
    {
        private readonly static StoreContext dbContext;
        private readonly static Regex NameRegex;
        private readonly static Regex UserNameRegex;
        private readonly static Regex EmailRegex;
        private readonly static Regex PhoneRegex;
        private static MapperConfiguration config;
        public readonly static IMapper mapper;

        static Helper()
        {
            dbContext = new StoreContext();
            NameRegex = new Regex("^[a-zA-Z]+(?: [a-zA-Z]+)?$");
            UserNameRegex = new Regex("^[a-zA-Z0-9_-]*$");
            EmailRegex = new Regex("^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
            PhoneRegex = new Regex("^(?:010|012|015|011)[0-9]{8}$");
            config = new MapperConfiguration((cfg) =>
            {
                cfg.CreateMap<CustomerLoginParamsDTO, Customer>();
                cfg.CreateMap<Category, CategoryToReturnDTO>();
            });
            mapper = config.CreateMapper();
        }

        public static CustomerLoginMsgsDTO ShowCustomerRegisterMsgs(CustomerLoginParamsDTO customerParams)
        {
            // Method for returning customer register messages

            CustomerLoginMsgsDTO massages = new();

            // Name msg
            switch (NameCheck(customerParams.Name))
            {
                case CheckStatusEnum.Empty:
                    massages.NameMsg = $"Fill the field!!";
                    break;
                case CheckStatusEnum.Match:
                    massages.NameMsg = string.Empty;
                    break;
                case CheckStatusEnum.DoesNotMatch:
                    massages.NameMsg = $"Only alphabets and one space between with length (2 to 30)";
                    break;
            }

            // UserName msg
            switch (UserNameCheck(customerParams.UserName))
            {
                case CheckStatusEnum.Empty:
                    massages.UserNameMsg = $"Fill the field!!";
                    break;
                case CheckStatusEnum.Existed:
                    massages.UserNameMsg = $"This UserName is existed already!!";
                    break;
                case CheckStatusEnum.Match:
                    massages.UserNameMsg = string.Empty;
                    break;
                case CheckStatusEnum.DoesNotMatch:
                    massages.UserNameMsg = $"allowed(_,-,numbers, alphabets) with length (5-30)";
                    break;
            }

            // Password msg
            switch (PasswordCheck(customerParams.Password))
            {
                case CheckStatusEnum.Empty:
                    massages.PasswordMsg = $"Fill the field!!";
                    break;
                case CheckStatusEnum.Match:
                    massages.PasswordMsg = string.Empty;
                    break;
                case CheckStatusEnum.DoesNotMatch:
                    massages.PasswordMsg = $"length(6-10)";
                    break;
            }

            // Email msg
            switch (EmailCheck(customerParams.Email))
            {
                case CheckStatusEnum.Empty:
                    massages.EmailMsg = $"Fill the field!!";
                    break;
                case CheckStatusEnum.Existed:
                    massages.EmailMsg = $"This Email is existed already!!";
                    break;
                case CheckStatusEnum.Match:
                    massages.EmailMsg = string.Empty;
                    break;
                case CheckStatusEnum.DoesNotMatch:
                    massages.EmailMsg = $"mostafa.ahmed_mostafa-khalil@gmail.com";
                    break;
            }

            // Phone msg
            switch (PhoneCheck(customerParams.Phone))
            {
                case CheckStatusEnum.Empty:
                    massages.PhoneMsg = $"Fill the field!!";
                    break;
                case CheckStatusEnum.Existed:
                    massages.PhoneMsg = $"This Phone is existed already!!";
                    break;
                case CheckStatusEnum.Match:
                    massages.PhoneMsg = string.Empty;
                    break;
                case CheckStatusEnum.DoesNotMatch:
                    massages.PhoneMsg = $"Enter a valid number!!";
                    break;
            }

            return massages;

        }
        public static CheckStatusEnum NameCheck(string name)
        {
            // Method that validate the name parameter..

            // Check if the name is NULL
            if (string.IsNullOrEmpty(name))
                return CheckStatusEnum.Empty;

            // Check if the name matches pattern && with length (2 to 30)
            if (NameRegex.IsMatch(name) && name.Length <= 30 && name.Length >= 2)
                return CheckStatusEnum.Match;
            else
                return CheckStatusEnum.DoesNotMatch;
        }
        private static CheckStatusEnum UserNameCheck(string userName)
        {
            // Method that validate the userName parameter..

            // Check if the userName is NULL
            if (string.IsNullOrEmpty(userName))
                return CheckStatusEnum.Empty;

            // Check if the userName existed before
            else if (CheckIfValueExists(c => c.UserName.Trim(), userName) == CheckStatusEnum.Existed)
                return CheckStatusEnum.Existed;

            // Check if the userName matches pattern && with length (5 to 30)
            else if (UserNameRegex.IsMatch(userName) && userName.Length <= 30 && userName.Length >= 5)
                return CheckStatusEnum.Match;
            else
                return CheckStatusEnum.DoesNotMatch;
        }
        private static CheckStatusEnum PasswordCheck(string password)
        {
            // Method that validate the password parameter..

            // Check if the password is NULL
            if (string.IsNullOrEmpty(password))
                return CheckStatusEnum.Empty;

            // Check if the password length (6 to 10)
            else if (password.Length <= 10 && password.Length >= 6)
                return CheckStatusEnum.Match;
            else
                return CheckStatusEnum.DoesNotMatch;
        }
        private static CheckStatusEnum EmailCheck(string email)
        {
            // Method that validate the email parameter..

            // Check if the email is NULL
            if (string.IsNullOrEmpty(email))
                return CheckStatusEnum.Empty;

            // Check if the email existed before
            else if (CheckIfValueExists(c => c.Email, email) == CheckStatusEnum.Existed)
                return CheckStatusEnum.Existed;

            // Check if the email consists only of alphabets

            if (EmailRegex.IsMatch(email))
                return CheckStatusEnum.Match;
            else
                return CheckStatusEnum.DoesNotMatch;
        }
        private static CheckStatusEnum PhoneCheck(string phone)
        {
            // Method that validate the phone parameter..

            // Check if the phone is NULL
            if (string.IsNullOrEmpty(phone))
                return CheckStatusEnum.Empty;

            // Check if the phone existed before
            else if (CheckIfValueExists(c => c.Phone, phone) == CheckStatusEnum.Existed)
                return CheckStatusEnum.Existed;

            // Check if the phone consists only of alphabets
            if (PhoneRegex.IsMatch(phone))
                return CheckStatusEnum.Match;
            else
                return CheckStatusEnum.DoesNotMatch;
        }
        private static CheckStatusEnum CheckIfValueExists(Expression<Func<Customer, string>> propertySelector, string valueToCheck)
        {
            var parameter = Expression.Parameter(typeof(Customer), "record");

            var propertyAccess = Expression.Invoke(propertySelector, parameter);

            var valueConstant1 = Expression.Constant(valueToCheck, typeof(string));

            var equality1 = Expression.Equal(propertyAccess, valueConstant1);

            var lambda = Expression.Lambda<Func<Customer, bool>>(equality1, parameter);

            var existingRecord = dbContext.Customers.FirstOrDefault(lambda);

            if (existingRecord != null)
                return CheckStatusEnum.Existed;
            else
                return CheckStatusEnum.NotExisted;
        }
        

    }
}
