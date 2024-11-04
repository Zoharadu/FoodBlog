using Common.Impl;
using Repository.Interface;
using Service.Interface;

namespace Service.Impl
{
    public class CommentService : ICommentService
    {
        public readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public void CreateCommentService(string Name, string RecipeId, string Content, DateTime CreatedDate)
        {
            _commentRepository.CreateCommentRepository(Name, RecipeId, Content, CreatedDate);
        }
        public CommentModel ReadCommentService(string Name, string RecipeId)
        {
            CommentModel commentModel = new CommentModel();
            commentModel = _commentRepository.ReadCommentRepository(Name, RecipeId);
            return commentModel;
        }
        public CommentModel updateCommentService(string Name, string RecipeId, string Content)
        {
            CommentModel commentModel = new CommentModel();
            commentModel = _commentRepository.updateCommentRepository(Name, RecipeId, Content);
            return commentModel;
        }
        public void DeleteCommentService(string RecipeId)
        {
            _commentRepository.DeleteCommentRepository(RecipeId);
        }
    }
}
