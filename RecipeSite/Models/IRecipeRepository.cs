using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSite.Models
{
    interface IRecipeRepository
    {
        IQueryable<Recipe> Recipes { get; }
    }
}
