using Common.Impl;
using Repository.Interface;
using Service.Interface;

namespace Service.Impl
{
    public class RecipeService : IRecipeService
    {
        public readonly IRecipeRepository _recipeRepository;
        public RecipeService(IRecipeRepository recipeRepository) 
        {
            _recipeRepository = recipeRepository;
        }
        public void CreateRecipeService(string Category, string Title, string Description, List<string> Items, string Instructions, string ImageUrl, DateTime CreatedDate)
        {
            _recipeRepository.CreateRecipeRepository(Category, Title, Description, Items, Instructions, ImageUrl, CreatedDate);
        }
        public RecipeModel ReadRecipeService(string id)
        {
            RecipeModel recipe = new RecipeModel();
            RecipeModel updatedRecipe =  _recipeRepository.ReadRecipeRepository(id);
            return recipe;
        }
        public RecipeModel UpdateRecipeService(string id, string Category, string Title, string Description, List<string> Items, string Instructions, string ImageUrl, DateTime CreatedDate)
        {
            RecipeModel recipe = new RecipeModel();
            RecipeModel updatedRecipe = _recipeRepository.UpdateRecipeRepository(id, Category, Title, Description, Items, Instructions, ImageUrl, CreatedDate);

            return updatedRecipe;
        }
        public void DeleteRecipeService(string id)
        {
            _recipeRepository.DeleteRecipeRepository(id);
        }
    }
}
