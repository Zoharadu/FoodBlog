namespace Common.Impl
{
    public class CategoryModel
    {
        public Dictionary<string, List<RecipeModel>> Categories { get; set; } = new Dictionary<string, List<RecipeModel>>
        {
            { "Fleshy", new List<RecipeModel>() },
            { "SaltedMilk", new List<RecipeModel>() },
            { "SweetMilky", new List<RecipeModel>() },
            { "SweetFur", new List<RecipeModel>() },
            { "Salads", new List<RecipeModel>() }
        };
    }
}
