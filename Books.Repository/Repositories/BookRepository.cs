using Books.Data;
using Books.Data.Models;
using Books.Repository.Base;
using Books.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Books.Repository.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookInterface
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Book>> GetBooksByCategoryName(string categoryName)
        {
            var category = _context.Categories.FirstOrDefault(category => category.Name == categoryName);
            return await _context.Books.Where(b => b.CategoryId == category.Id).ToListAsync();
        }
    }
}
