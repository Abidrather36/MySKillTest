using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Domain.Models.Request;
using OSAP.WebApi.Models;

namespace MySkillTest.WebApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet("getAllUsers")]

        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await userService.GetAllUsers();
                return Ok(users);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet("GetUserById{id:guid}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            try
            {
                var user = await userService.GetUserById(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        [HttpPost("RegisterUser")]

        public async Task<IActionResult> PostUser(UserMasterModel userModel)
        {
            try
            {
                var user = await userService.CreateUser(userModel);
               return  Ok(user);
            }
            catch (Exception ex)
            {
                return Conflict();
            }
        }
        [HttpPut("updateUser")]
        public async Task<IActionResult> PutUser(UserMasterUpdateModel model)
        {
            try
            {
                var updatedUser = await userService.UpdateUser(model);
                return Ok(updatedUser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }

        }
        [HttpDelete("deleteUserById:{id:guid}")]

        public async Task<IActionResult> DeleteUser(Guid id)
        {
            try
            {
                var deletedUser = await userService.DeleteUser(id);
                return Ok(deletedUser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
