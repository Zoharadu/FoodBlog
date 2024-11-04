namespace Common.Impl
{
    public class CommentModel
    {
        public string Name {  get; set; } = string.Empty;
        public string RecipeId { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.MinValue;
    }
}