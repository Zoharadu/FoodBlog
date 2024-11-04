using Common.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace BlogFood.Controllers
{
    [Route("api/RecipeController")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
       public readonly IRecipeService _recipeService;

       public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpPost("CreateRecipe")]
        public IActionResult CreateRecipe([FromBody] RecipeModel recipe)
        {
            try
            {
                _recipeService.CreateRecipeService(recipe.Category, recipe.Title, recipe.Description,recipe.Items,recipe.Instructions,recipe.ImageUrl,recipe.CreatedDate);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ReadUser")]
        public IActionResult ReadRecip(string id)
        {
            try
            {
                _recipeService.ReadRecipeService(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("Update")]
        public IActionResult UpdateRecipe([FromForm] RecipeModel recipe)
        {
            try
            {
                _recipeService.UpdateRecipeService(recipe.Id, recipe.Category, recipe.Title, recipe.Description, recipe.Items, recipe.Instructions, recipe.ImageUrl, recipe.CreatedDate);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteRecipe(string id)
        {
            try
            {
                _recipeService.DeleteRecipeService(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
    