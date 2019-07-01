using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeSite.Models;

namespace RecipeSite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        public ViewResult RecipeList()
        {
            return View(TempRepository.Recipes);
        }
        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                TempRepository.RecipeAdd(recipe);
                return View();
            }
            else
            {
                return View();
            }
        }
        public ViewResult ViewRecipe()
        {
            return View();
        }
        public ViewResult ReviewRecipe()
        {
            return View();
        }
    }
}
