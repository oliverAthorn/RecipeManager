using RecipeManager.DataAccess.DbAccess;
using RecipeManager.DataAccess.Models;

namespace RecipeManager.DataAccess.Data;

public class RecipeData : IRecipeData
{
    private readonly ISqlDataAccess _db;

    public RecipeData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<RecipeModel>> GetAllRecipes() =>
        _db.LoadData<RecipeModel, dynamic>("dbo.spRecipe_GetAll", new { });

    public async Task<RecipeModel?> GetRecipe(int id)
    {
        var results = await _db.LoadData<RecipeModel, dynamic>(
            "dbo.spRecipe_Get",
            new { Id = id });

        return results.FirstOrDefault();
    }

    public Task InsertRecipe(RecipeModel recipe) =>
        _db.SaveData("dbo.spRecipe_Insert", new { recipe.Name, recipe.Description });

    public Task UpdateRecipe(RecipeModel recipe) =>
        _db.SaveData("dbo.spRecipe_Update", recipe);

    public Task DeleteRecipe(int id) =>
        _db.SaveData("dbo.spRecipe_Delete", new { Id = id });
}