using BiblioApp.Models;
using BiblioApp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp.Repository.Implementations
{
    public class AdherentRepository : Repository<Adherent> , IAdherentRepository
    {
        public AdherentRepository(DbContext _context) : base(_context)
        {

        }

    }
}
