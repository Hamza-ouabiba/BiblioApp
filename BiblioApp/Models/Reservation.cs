using System;
using System.Collections.Generic;

#nullable disable

namespace BiblioApp.Models
{
    public partial class Reservation
    {
        public int IdReservation { get; set; }
        public int IdLivre { get; set; }
        public int IdAdherent { get; set; }
        public DateTime? DateFin { get; set; }
        public DateTime? DateDebut { get; set; }
        public bool? Status { get; set; }
        public virtual Adherent Adherent { get; set; }
        public virtual Livre Livre { get; set; }
    }
}
