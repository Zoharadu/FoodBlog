using Common.Impl;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace BlogFood.Controllers
{
    [Route("api/UserController")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] UserModel user)
        {
            try
            {
                _userService.CreateUserService(user.UserName, user.Password, user.Email);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ReadUser")]
        public IActionResult ReadUser(string username, string password)
        {
            try
            {
                _userService.ReadUserService(username, password);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPatch("Update")]
        public IActionResult UpdateUser([FromBody] UserModel user)
        {
            try
            {
                _userService.UpdateUserService(user.Id, user.UserName, user.Password, user.Email);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser([FromBody] UserModel user)
        {
            try
            {
                _userService.DeleteUserService(user.Id);
                return Ok("succ");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("LoginUser")]
        public IActionResult LoginUser([FromBody] UserModel user)
        {
            try
            {
                _userService.LoginUserService(user.UserName,user.Password);
                return Ok("succ");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
