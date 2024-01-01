using BiblioApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp.Repository.Implementations
{
    public class ReservationRepository : Repository<Reservation>
    {
        public ReservationRepository(DbContext _context) : base(_context)
        {
        }
    }
}
