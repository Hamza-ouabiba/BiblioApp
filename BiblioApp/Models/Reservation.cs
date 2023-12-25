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

        public virtual Adherent Adherent { get; set; }
        public virtual Livre Livre { get; set; }
    }
}
