using BiblioApp.Models;
using BiblioApp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;

namespace BiblioApp.Repository.Implementations
{
    internal class LivreRespository : Repository<Livre> , ILivreRepository
    {
        public LivreRespository(DbContext _context) : base(_context)
        {
        }
        public BibliothequeDbContext bibliothequeDbContext { get => _context as BibliothequeDbContext; }

        public bool IsBookEmprunte(int id)
        {
            Livre livre = bibliothequeDbContext.Livres.Include("Etat").Where(l => l.IdLivre == id && l.Etat.Nom != "Emprunté").FirstOrDefault();
            return livre != null;
        }

        IEnumerable ILivreRepository.LivreParAuteur()
        {
            return bibliothequeDbContext.Livres.Include(l => l.Auteur)
                .GroupBy(a => a.Auteur.NomAuteur)
                .Select(l => new {Auteur = l.Key , Livres = l.Count()})
                .ToList();
        }

    }
}
