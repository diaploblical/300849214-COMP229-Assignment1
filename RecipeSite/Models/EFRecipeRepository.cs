using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSite.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;
        public EFRecipeRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Recipe> Recipes => context.Recipes;
    }
}
