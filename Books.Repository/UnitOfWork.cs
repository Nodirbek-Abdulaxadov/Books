using Books.Data;
using Books.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        
        public UnitOfWork(ApplicationDbContext context,
                          IBookInterface bookInterface)
        {
            this.context = context;
            Books = bookInterface;
        }
        public IBookInterface Books { get; }

        public void Complete()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
