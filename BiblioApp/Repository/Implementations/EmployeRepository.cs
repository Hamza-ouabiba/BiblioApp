using BiblioApp.Models;
using BiblioApp.Repository.Interfaces;

namespace BiblioApp.Repository.Implementations
{
    public class EmployeRepository : Repository<Employe>, IEmployeRepository
    {
        public EmployeRepository(BibliothequeDbContext context)  : base(context) { }
        public IEnumerable<Employe> TopEmployees(int count)
        {
            throw new NotImplementedException();
        }
    }
}
