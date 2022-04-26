namespace RecipeManager.Web.Models;

public class RecipeViewModel
{
    public IEnumerable<RecipeModel> Recipes { get; set; } = new List<RecipeModel>();
    public RecipeModel Recipe { get; set; }
  
}

