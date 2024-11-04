using Common.Impl;

namespace Repository.Interface
{
    public interface IRecipeRepository
    {
        public void CreateRecipeRepository(string Category, string Title, string Description, List<string> Items, string Instructions, string ImageUrl, DateTime CreatedDate);
        public RecipeModel ReadRecipeRepository(string id);
        public RecipeModel UpdateRecipeRepository(string id, string Category, string Title, string Description, List<string> Items, string Instructions, string ImageUrl, DateTime CreatedDate);
        public void DeleteRecipeRepository(string id);
    }
}
