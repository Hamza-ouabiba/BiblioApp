using BiblioApp.Models;

namespace BiblioApp.Repository.Interfaces
{
    public interface IEmployeRepository : IRepository<Employe>
    {
        IEnumerable<Employe> TopEmployees(int count);
    }
}
