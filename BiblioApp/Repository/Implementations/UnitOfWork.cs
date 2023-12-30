﻿
using BiblioApp.Models;
using BiblioApp.Repository.Interfaces;

namespace BiblioApp.Repository.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BibliothequeDbContext _context;
        public IEmployeRepository Employe { get; private set; }
        public IAuteurRepository Auteur { get; private set; }
        public ILivreRepository Livre { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public IEtatRepository Etat { get; private set; }
        public IAdherentRepository Adherent { get; private set; }
        public UnitOfWork(BibliothequeDbContext context)
        {
            _context = context;
            Auteur = new AuteurRepository(context);
            Employe = new EmployeRepository(context);
            Category = new CategoryRepository(context);
            Livre  = new LivreRespository(context);
            Etat = new EtatRepository(context);
            Adherent = new AdherentRepository(context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
