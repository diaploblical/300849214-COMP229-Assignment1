using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSite.Models
{
    public static class TempRepository
    {
        private static List<Recipe> recipes = new List<Recipe>();
        public static IEnumerable<Recipe> Recipes
        {
            get { return recipes; }
        }
        public static void RecipeAdd(Recipe recipe)
        {
            recipes.Add(recipe);
        }
    }   
}
