using BiblioApp.Models;
using BiblioApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
