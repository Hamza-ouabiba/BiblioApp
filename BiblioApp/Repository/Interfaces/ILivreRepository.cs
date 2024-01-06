using BiblioApp.Models;
using System;
using System.Collections;

namespace BiblioApp.Repository.Interfaces
{
    public interface ILivreRepository : IRepository<Livre>
    {
        IEnumerable LivreParAuteur();
        bool IsBookNotEmprunte(int id);
        bool IsBookAvailable(int id);
    }
}
