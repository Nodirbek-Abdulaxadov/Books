using Books.Repository.Interfaces;

namespace Books.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IBookInterface Books { get; }
        void Complete();
    }
}
