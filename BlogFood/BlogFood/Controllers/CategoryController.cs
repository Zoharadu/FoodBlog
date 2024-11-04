using Common.Impl;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace BlogFood.Controllers
{
    [Route("api/CategoryController")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _CategoryService;

        public CategoryController(ICategoryService CategoryService)
        {
            _CategoryService = CategoryService;
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateCategory([FromBody] string category)
        {
            try
            {
                _CategoryService.CreateCategoryService(category);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ReadUser")]
        public IActionResult ReadUser(string category)
        {
            try
            {
                _CategoryService.ReadCategoryService(category);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPatch("Update")]
        public IActionResult Update([FromBody] string category)
        {
            try
            {
                _CategoryService.UpdateCategoryService(category);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser([FromBody] string category)
        {
            try
            {
                _CategoryService.DeleteCategoryService(category);
                return Ok("succ");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
