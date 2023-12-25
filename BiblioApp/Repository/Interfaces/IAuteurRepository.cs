using BiblioApp.Models;
using System.Collections;

namespace BiblioApp.Repository.Interfaces
{
    public interface IAuteurRepository : IRepository<Auteur>
    {
        IEnumerable TopAuthor(int count);
    }
}
