using System;
using System.Collections.Generic;

#nullable disable

namespace BiblioApp.Models
{
    public partial class Employe
    {
        public int IdEmploye { get; set; }
        public string Nom { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
