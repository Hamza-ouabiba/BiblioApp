using System;
using System.Collections.Generic;

#nullable disable

namespace BiblioApp.Models
{
    public partial class Etat
    {
        public Etat()
        {
            Livres = new HashSet<Livre>();
        }

        public int IdEtat { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Livre> Livres { get; set; }
    }
}
