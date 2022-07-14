using Books.Data.Models;
using Books.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Repository.Interfaces
{
    public interface IBookInterface : IGenericRepository<Book>
    {
        Task<IEnumerable<Book>> GetBooksByCategoryName(string categoryName);
    }
}
