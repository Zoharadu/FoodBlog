using Common.Impl;
using Repository.Interface;

namespace Repository.Impl
{
    public class RecipeRepository : IRecipeRepository
    {
        public void CreateRecipeRepository(string Category, string Title, string Description, List<string> Items, string Instructions, string ImageUrl, DateTime CreatedDate)
        {

        }
        public RecipeModel ReadRecipeRepository(string id)
        {
            RecipeModel recipe = new RecipeModel();
            return recipe;
        }
        public RecipeModel UpdateRecipeRepository(string id, string Category, string Title, string Description, List<string> Items, string Instructions, string ImageUrl, DateTime CreatedDate)
        {
            RecipeModel recipe = new RecipeModel();
            return recipe;
        }
        public void DeleteRecipeRepository(string id)
        {

        }
    }
}
