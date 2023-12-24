using System;
using System.Collections.Generic;

#nullable disable

namespace BiblioApp.Models
{
    public partial class Categorie
    {
        public Categorie()
        {
            Livres = new HashSet<Livre>();
        }

        public int IdCategorie { get; set; }
        public string NomCategorie { get; set; }

        public virtual ICollection<Livre> Livres { get; set; }
    }
}
