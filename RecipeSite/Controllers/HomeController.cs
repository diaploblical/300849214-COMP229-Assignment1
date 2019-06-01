using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
        public ViewResult AddRecipe()
        {
            return View();
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
