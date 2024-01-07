﻿
using BiblioApp.Models;
using BiblioApp.Repository.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


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
        public IReservationRepository Reservation { get; private set; }

        public UnitOfWork(BibliothequeDbContext context)
        {
            _context = context;
            Auteur = new AuteurRepository(context);
            Employe = new EmployeRepository(context);
            Category = new CategoryRepository(context);
            Livre  = new LivreRespository(context);
            Etat = new EtatRepository(context);
            Adherent = new AdherentRepository(context);
            Reservation = new ReservationRepository(context);
        }

        public int Complete()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                const int uniqueConstraintViolationErrorCode = 2627; 
                if (ex.InnerException is SqlException sqlException)
                {
                    if (sqlException.Number ==  uniqueConstraintViolationErrorCode)
                    {
                        string affichageError = string.Empty;

                        if (sqlException.Message.Contains("UNIQUE_EMAIL"))
                        {
                            affichageError = "Email ,";
                        }
                        if (sqlException.Message.Contains("UNIQUE_TITLE"))
                        {
                            affichageError += "Titre livre ";
                        }
                        throw new Exception($"Duplication du champ : {affichageError}");
                    }
                }
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }



        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
