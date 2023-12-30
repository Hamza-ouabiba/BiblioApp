﻿using BiblioApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp.Repository.Interfaces
{
    public interface IEtatRepository : IRepository<Etat>
    {
        public IEnumerable GetCreationEtat();
    }
}
