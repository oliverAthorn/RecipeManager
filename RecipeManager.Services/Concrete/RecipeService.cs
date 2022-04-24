using RecipeManager.DataAccess.Data;
using RecipeManager.DataAccess.Models;
using RecipeManager.Services.Interfaces;

namespace RecipeManager.Services.Concrete;

public class RecipeService : IRecipeService
{
    private readonly IRecipeData _recipeData;

    public RecipeService(IRecipeData recipeData)
    {
        _recipeData = recipeData;
    }
    Task IRecipeService.DeleteRecipe(int id)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<RecipeModel>> IRecipeService.GetAllRecipes()
    {
        throw new NotImplementedException();
    }

    Task<RecipeModel?> IRecipeService.GetRecipe(int id)
    {
        throw new NotImplementedException();
    }

    Task IRecipeService.InsertRecipe(RecipeModel recipe)
    {
        throw new NotImplementedException();
    }

    Task IRecipeService.UpdateRecipe(RecipeModel recipe)
    {
        throw new NotImplementedException();
    }
}

