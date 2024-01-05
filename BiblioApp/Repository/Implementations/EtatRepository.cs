using BiblioApp.Models;
using BiblioApp.Repository.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp.Repository.Implementations
{
    public class EtatRepository : Repository<Etat> , IEtatRepository
    {
        public EtatRepository(BibliothequeDbContext bibliotheque) : base(bibliotheque) { }
        public BibliothequeDbContext bibliothequeDbContext { get => _context as BibliothequeDbContext; }

        public IEnumerable GetCreationEtat()
        {
            return bibliothequeDbContext.Etats
                .Where(e => e.Nom != "Emprunté")
                .Select(e => e)
                .ToList();
        }
        public Etat GetEtatByName(string name)
        {
            return bibliothequeDbContext.Etats.FirstOrDefault(e => e.Nom == name);
        }

    }
}
