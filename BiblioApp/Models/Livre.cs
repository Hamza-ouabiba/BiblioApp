using System;
using System.Collections.Generic;

#nullable disable

namespace BiblioApp.Models
{
    public partial class Livre
    {
        public Livre()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int IdLivre { get; set; }
        public int IdCategorie { get; set; }
        public int IdAuteur { get; set; }

        public virtual Auteur IdAuteurNavigation { get; set; }
        public virtual Categorie IdCategorieNavigation { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
