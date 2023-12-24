using System;
using System.Collections.Generic;

#nullable disable

namespace BiblioApp.Models
{
    public partial class Reservation
    {
        public int IdLivre { get; set; }
        public int IdAdherent { get; set; }
        public DateTime? Periode { get; set; }

        public virtual Adherent IdAdherentNavigation { get; set; }
        public virtual Livre IdLivreNavigation { get; set; }
    }
}
