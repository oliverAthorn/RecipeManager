using RecipeManager.DataAccess.Models;

namespace RecipeManager.DataAccess.Data
{
    public interface IRecipeData
    {
        Task DeleteRecipe(int id);
        Task<IEnumerable<RecipeModel>> GetAllRecipes();
        Task<RecipeModel?> GetRecipe(int id);
        Task InsertRecipe(RecipeModel recipe);
        Task UpdateRecipe(RecipeModel recipe);
    }
}