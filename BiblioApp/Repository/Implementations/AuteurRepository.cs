using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System;
using System.Collections;

namespace BiblioApp.Repository.Interfaces
{
    public class AuteurRepository : Repository<Auteur>, IAuteurRepository
    {
        public AuteurRepository(BibliothequeDbContext context):base(context)
        {

        }
        public IEnumerable TopAuthor(int count)
        {
            throw new NotImplementedException();
        }
    }
}
