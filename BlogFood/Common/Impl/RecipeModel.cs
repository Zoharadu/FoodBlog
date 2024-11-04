namespace Common.Impl
{
    public class RecipeModel
    {
        public string Id { get; set; } = string.Empty;
        public string Category {  get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Items { get; set; } = new List<string>();
        public string Instructions {  get; set; } = string.Empty;
        public string ImageUrl {  get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
