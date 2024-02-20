using BookStore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookStore.Repository.Data
{
    public static class StoreContextSeed
    {
        public async static Task SeedAsync(StoreContext _dbContext)
        {
            if (_dbContext.Admins.Count() == 0
                && _dbContext.Customers.Count() == 0
                && _dbContext.Authors.Count() == 0
                && _dbContext.Books.Count() == 0
                && _dbContext.Categories.Count() == 0
                && _dbContext.Customers.Count() == 0
                && _dbContext.Orders.Count() == 0)
            {
                // Adding Admins..
                var adminsData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/admins.json");
                var admins = JsonSerializer.Deserialize<List<Admin>>(adminsData);

                if (admins?.Count() > 0)
                {
                    foreach (var admin in admins)
                        _dbContext.Admins.Add(admin);
                    await _dbContext.SaveChangesAsync();
                }

                // Adding Authors..
                var authorsData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/authors.json");
                var authors = JsonSerializer.Deserialize<List<Author>>(authorsData);

                if (authors?.Count() > 0)
                {
                    foreach (var author in authors)
                        _dbContext.Authors.Add(author);
                    await _dbContext.SaveChangesAsync();
                }

                // Adding Publishers..
                var publishersData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/publishers.json");
                var publishers = JsonSerializer.Deserialize<List<Publisher>>(publishersData);

                if (publishers?.Count() > 0)
                {
                    foreach (var publisher in publishers)
                        _dbContext.Publishers.Add(publisher);
                    await _dbContext.SaveChangesAsync();
                }

                // Adding Categories..
                var categoriesData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/categories.json");
                var categories = JsonSerializer.Deserialize<List<Category>>(categoriesData);

                if (categories?.Count() > 0)
                {
                    foreach (var category in categories)
                        _dbContext.Categories.Add(category);
                    await _dbContext.SaveChangesAsync();
                }

                // Adding Customers..
                var customersData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/customers.json");
                var customers = JsonSerializer.Deserialize<List<Customer>>(customersData);

                if (customers?.Count() > 0)
                {
                    foreach (var customer in customers)
                        _dbContext.Customers.Add(customer);
                    await _dbContext.SaveChangesAsync();
                }

                // Adding Books..
                var booksData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/books.json");
                var books = JsonSerializer.Deserialize<List<Book>>(booksData);

                if (books?.Count() > 0)
                {
                    foreach (var book in books)
                        _dbContext.Books.Add(book);
                    await _dbContext.SaveChangesAsync();
                }

                // Adding AuthorBooks..
                var authorBooksData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/authorBook.json");
                var authorBooks = JsonSerializer.Deserialize<List<BookAuthor>>(authorBooksData);

                if (authorBooks?.Count() > 0)
                {
                    foreach (var authorBook in authorBooks)
                        _dbContext.BookAuthors.Add(authorBook);
                    await _dbContext.SaveChangesAsync();

                }

                // Adding PublisherBooks..
                var publisherBooksData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/publisherBook.json");
                var publisherBooks = JsonSerializer.Deserialize<List<BookPublisher>>(publisherBooksData);

                if (publisherBooks?.Count() > 0)
                {
                    foreach (var publisherBook in publisherBooks)
                        _dbContext.BookPublishers.Add(publisherBook);
                    await _dbContext.SaveChangesAsync();
                }

                // Adding Orders..
                var ordersData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/orders.json");
                var orders = JsonSerializer.Deserialize<List<Order>>(ordersData);

                if (orders?.Count() > 0)
                {
                    foreach (var order in orders)
                        _dbContext.Orders.Add(order);
                    await _dbContext.SaveChangesAsync();
                }

                // Adding BookOrders..
                var bookOrdersData = File.ReadAllText("../../../../BookStore.Repository/Data/DataSeed/bookOrders.json");
                var bookOrders = JsonSerializer.Deserialize<List<BookOrder>>(bookOrdersData);

                if (bookOrders?.Count() > 0)
                {
                    foreach (var bookOrder in bookOrders)
                        _dbContext.BookOrders.Add(bookOrder);
                    await _dbContext.SaveChangesAsync();
                }

            }
        }
    }
}
