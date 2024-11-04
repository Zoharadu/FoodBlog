using Common.Impl;

namespace Service.Interface
{
    public interface IRecipeService
    {
        public void CreateRecipeService(string Category, string Title, string Description, List<string> Items, string Instructions, string ImageUrl, DateTime CreatedDate);
        public RecipeModel ReadRecipeService(string id);
        public RecipeModel UpdateRecipeService(string id, string Category, string Title, string Description, List<string> Items, string Instructions, string ImageUrl, DateTime CreatedDate);
        public void DeleteRecipeService(string id);    
    }
}
