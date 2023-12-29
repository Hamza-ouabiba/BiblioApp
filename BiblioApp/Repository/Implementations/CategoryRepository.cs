using BiblioApp.Models;
using BiblioApp.Repository.Implementations;
using System;
using System.Collections;

namespace BiblioApp.Repository.Interfaces
{
    public class CategoryRepository : Repository<Categorie>, ICategoryRepository
    {
        public CategoryRepository(BibliothequeDbContext context):base(context)
        {

        }
    }
}
