using Common.Impl;

namespace Repository.Interface
{
    public interface ICommentRepository
    {
        public void CreateCommentRepository(string Name, string RecipeId, string Content, DateTime CreatedDate);
        public CommentModel ReadCommentRepository(string Name, string RecipeId);
        public CommentModel updateCommentRepository(string Name, string RecipeId, string Content);
        public void DeleteCommentRepository(string RecipeId);
    }
}
