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
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Couverture { get; set; }
        public float Prix { get; set; }
        public int NbPages { get; set; }
        public DateTime DatePublication { get; set; }
        public int? IdEtat { get; set; }

        public virtual Auteur IdAuteurNavigation { get; set; }
        public virtual Categorie IdCategorieNavigation { get; set; }
        public virtual Etat IdEtatNavigation { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
