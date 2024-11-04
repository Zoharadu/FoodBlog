using Common.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace BlogFood.Controllers
{
    [Route("api/CommentController")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        public readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService=commentService;
        }

        [HttpPost("CreateComment")]
        public IActionResult CreateComment([FromBody] CommentModel comment)
        {
            try
            {
                _commentService.CreateCommentService(comment.Name, comment.RecipeId, comment.Content,comment.CreatedDate);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ReadComment")]
        public IActionResult ReadComment([FromBody] CommentModel comment)
        {
            try
            {
                _commentService.ReadCommentService(comment.Name, comment.RecipeId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("UpdateComment")]
        public IActionResult UpdateComment([FromBody] CommentModel comment)
        {
            try
            {
                _commentService.updateCommentService(comment.Name, comment.RecipeId, comment.Content);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteComment")]
        public IActionResult DeleteComment(string id)
        {
            try
            {
                _commentService.DeleteCommentService(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
