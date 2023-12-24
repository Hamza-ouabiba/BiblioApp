using System;
using System.Collections.Generic;

#nullable disable

namespace BiblioApp.Models
{
    public partial class Auteur
    {
        public Auteur()
        {
            Livres = new HashSet<Livre>();
        }

        public int IdAuteur { get; set; }
        public string NomAuteur { get; set; }
        public string PrenomAuteur { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string Nationalite { get; set; }

        public virtual ICollection<Livre> Livres { get; set; }
    }
}
