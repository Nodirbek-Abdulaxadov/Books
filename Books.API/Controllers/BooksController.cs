using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Books.Data;
using Books.Data.Models;
using Books.Repository.Interfaces;
using Books.Repository;

namespace Books.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BooksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBook()
        {
            return Ok(await _unitOfWork.Books.GetAll());
        }
    }
}
