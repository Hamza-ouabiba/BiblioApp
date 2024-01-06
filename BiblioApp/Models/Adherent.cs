﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BiblioApp.Models
{
    public partial class Adherent
    {
        public Adherent()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int IdAdherent { get; set; }
        public string NomAdherent { get; set; }
        public string PrenomAdherent { get; set; }
        public DateTime? DateInscription { get; set; }
        public string Email { get; set; }
        public string Genre {  get; set; }  
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
