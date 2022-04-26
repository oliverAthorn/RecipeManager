using RecipeManager.DataAccess.Data;
using RecipeManager.DataAccess.Models;
using RecipeManager.Services.Interfaces;

namespace RecipeManager.Services.Concrete;

public class RecipeService : IRecipeService
{
    private readonly IRecipeRepository _recipeData;

    public RecipeService(IRecipeRepository recipeData)
    {
        _recipeData = recipeData;
    }
    public Task DeleteRecipe(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<RecipeModel>> GetAllRecipes()
    {
        return await _recipeData.GetAllRecipes();
    }

    public Task<RecipeModel?> GetRecipe(int id)
    {
        throw new NotImplementedException();
    }

    public Task InsertRecipe(RecipeModel recipe)
    {
        return _recipeData.InsertRecipe(recipe);
    }

    public Task UpdateRecipe(RecipeModel recipe)
    {
        throw new NotImplementedException();
    }
}

