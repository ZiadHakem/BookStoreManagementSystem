using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Services.Contracts
{
    public interface IBookService
    {     
            IEnumerable<Book> GetAllBooks();
            Book GetBookById(int id);
            void AddBook(Book book);
            void UpdateBook(Book book);
            void DeleteBook(int id);
        
    }
}
