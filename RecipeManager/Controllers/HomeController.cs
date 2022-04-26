using Microsoft.AspNetCore.Mvc;
using RecipeManager.Models;
using RecipeManager.Services.Interfaces;
using RecipeManager.Web.Models;
using System.Diagnostics;

namespace RecipeManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRecipeService _recipeService;

        public HomeController(ILogger<HomeController> logger, 
            IRecipeService recipeService)
        {
            _logger = logger;
            _recipeService = recipeService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new RecipeViewModel();
            var recipes = await _recipeService.GetAllRecipes();
            model.Recipes = recipes;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RecipeViewModel insertRecipe)
        {
            RecipeModel recipe = new RecipeModel();
            recipe.Name = insertRecipe.Recipe.Name;
            recipe.Description = insertRecipe.Recipe.Description;

            await _recipeService.InsertRecipe(recipe);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}