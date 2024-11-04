using Common.Impl;
using System.Xml.Linq;

namespace Service.Interface
{
    public interface ICommentService
    {
        public void CreateCommentService(string Name, string RecipeId, string Content, DateTime CreatedDate);
        public CommentModel ReadCommentService(string Name, string RecipeId);
        public CommentModel updateCommentService(string Name, string RecipeId, string Content);
        public void DeleteCommentService(string RecipeId);
    }
}
