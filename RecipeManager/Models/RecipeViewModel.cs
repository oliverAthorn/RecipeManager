namespace RecipeManager.Web.Models;

public class RecipeViewModel
{
    public IEnumerable<RecipeModel>? Recipes { get; set; }
    public RecipeModel? Recipe { get; set; }
  
}

