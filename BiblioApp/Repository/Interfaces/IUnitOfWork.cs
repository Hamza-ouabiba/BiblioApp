
namespace BiblioApp.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeRepository Employe { get;  }
        IAuteurRepository Auteur { get; }
        int Complete();
    }
}
