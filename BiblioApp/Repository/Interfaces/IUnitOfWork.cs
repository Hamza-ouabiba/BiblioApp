
namespace BiblioApp.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
     
        int Complete();
    }
}
