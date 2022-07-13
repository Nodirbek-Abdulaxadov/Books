using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Books.API.Data;
using Books.API.Models;

namespace Books.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBook()
        {
            if (_context.Books == null)
            {
                return NotFound();
            }

            return await _context.Books.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
          if (_context.Books == null)
          {
              return NotFound();
          }
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // GET: api/AllPrice
        [HttpGet("allprice")]
        public async Task<IActionResult> AllPrice()
        {
            var list = await _context.Books.ToListAsync();

            return Ok(list);
        }

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Books
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            if (_context.Books == null)
            {
                return Problem("Entity set 'BooksAPIContext.Book'  is null.");
            }
            else if (BookExists(book.Name))
            {
                return Problem($"{book.Name} already exist!");
            }

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if (_context.Books == null)
            {
                return NotFound();
            }
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //Generate 1000 books
        [HttpPost("generate")]
        public async Task<IActionResult> PostThousandBooks()
        {
            Book? book = null;
            for (int i = 1; i <= 8000; i++)
            {
                book = new Book()
                {
                    Name = "book - 00" + i,
                    Author = "Author" + i,
                    Price = i * 10,
                    CategoryId = 1,
                    UrlToBook = ""
                };
                _context.Books.Add(book);
                await _context.SaveChangesAsync();
            }

            return Ok();
        }

        [NonAction]
        private bool BookExists(int id)
        {
            return (_context.Books?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        [NonAction]
        private bool BookExists(string name)
        {
            return (_context.Books?.Any(e => e.Name == name)).GetValueOrDefault();
        }
    }
}
