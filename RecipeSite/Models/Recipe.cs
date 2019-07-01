using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSite.Models
{
    public class Recipe
    {
        [Required(ErrorMessage = "Recipe name is required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Recipe ingredients are required!")]
        public string Ingredients { get; set; }
        [Required(ErrorMessage = "Recipe description is required!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Recipe category is required!")]
        public string Category { get; set; }
    }
}
