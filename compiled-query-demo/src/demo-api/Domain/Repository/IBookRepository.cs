using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using demo_api.Domain;

namespace demo_api.Domain.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<Book> GetBookByIdAsync(Guid bookId);
        Task<Book> GetBookByTitleAsync(string bookTitle);
        Task<Book> GetBookByAuthorAsync(string bookAuthor);
        Task<Book> GetBookByCategoryAsync(string bookCategory);
        Task<Book> GetBookByPriceAsync(string bookPrice);
        Task<Book> GetBookByDescriptionAsync(string bookDescription);
        Task CreateBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(Guid bookId);
    }
}