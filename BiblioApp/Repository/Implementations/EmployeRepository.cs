using BiblioApp.Models;
using BiblioApp.Repository.Interfaces;

namespace BiblioApp.Repository.Implementations
{
    public class EmployeRepository : Repository<Employe>, IEmployeRepository
    {
        public EmployeRepository(BibliothequeDbContext context)  : base(context) { }
        public BibliothequeDbContext bibliothequeDbContext { get => _context as BibliothequeDbContext; }

        public Employe CurrentEmployee(string username, string password)
        {
            return bibliothequeDbContext.Employes
             .FirstOrDefault(e => e.Nom == username && e.Password == password);
        }

        public IEnumerable<Employe> TopEmployees(int count)
        {
            throw new NotImplementedException();
        }
        
    }
}
