using Common.Impl;
using Repository.Interface;

namespace Repository.Impl
{
    public class CommentRepository : ICommentRepository
    {
        public void CreateCommentRepository(string Name, string RecipeId, string Content, DateTime CreatedDate)
        {

        }
        public CommentModel ReadCommentRepository(string Name, string RecipeId)
        {
            CommentModel commentModel = new CommentModel();
            return commentModel;
        }
        public CommentModel updateCommentRepository(string Name, string RecipeId, string Content)
        {
            CommentModel commentModel = new CommentModel();
            return commentModel;
        }
        public void DeleteCommentRepository(string RecipeId)
        {

        }
    }
}
