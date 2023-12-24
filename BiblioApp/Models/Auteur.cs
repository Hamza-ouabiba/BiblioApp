﻿using System;
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
        public string Email { get; set; }
        public string Genre { get; set; }

        public virtual ICollection<Livre> Livres { get; set; }
    }
}
