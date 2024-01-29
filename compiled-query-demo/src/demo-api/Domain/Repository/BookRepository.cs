using demo_api.Infrastructure;

namespace demo_api.Domain.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DemoDbContext _context;

        public BookRepository(DemoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await Task.FromResult<IEnumerable<Book>>(_context.Books.ToList());
        }

        public async Task<Book> GetBookByIdAsync(Guid bookId)
        {
            return await Task.FromResult<Book>(_context.Books.SingleOrDefault(x => x.Id == bookId));
        }

        public async Task<Book> GetBookByTitleAsync(string bookTitle)
        {
            return await Task.FromResult<Book>(_context.Books.SingleOrDefault(x => x.Title == bookTitle));
        }

        public async Task<Book> GetBookByAuthorAsync(string bookAuthor)
        {
            return await Task.FromResult<Book>(_context.Books.SingleOrDefault(x => x.Author == bookAuthor));
        }

        public async Task<Book> GetBookByCategoryAsync(string bookCategory)
        {
            return await Task.FromResult<Book>(_context.Books.SingleOrDefault(x => x.Category == bookCategory));
        }

        public async Task<Book> GetBookByPriceAsync(string bookPrice)
        {
            return await Task.FromResult<Book>(_context.Books.SingleOrDefault(x => x.Price == bookPrice));
        }

        public async Task<Book> GetBookByDescriptionAsync(string bookDescription)
        {
            return await Task.FromResult<Book>(_context.Books.SingleOrDefault(x => x.Description == bookDescription));
        }

        public async Task CreateBookAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(Guid bookId)
        {
            var book = await GetBookByIdAsync(bookId);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}