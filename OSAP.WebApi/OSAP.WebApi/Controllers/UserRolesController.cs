using Microsoft.AspNetCore.Mvc;
using MySkillTest.Application.Abstractions.IService;
using OSAP.WebApi.Models;

namespace MySkillTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRoleService userRoleService;

        public UserRolesController(IUserRoleService userRoleService)
        {
            this.userRoleService = userRoleService;
        }

        [HttpPost("registerUserRole")]
        public async Task<IActionResult> PostUserRole(UserRoleRequestModel model)
        {
            try
            {
                var userRoleAdded = await userRoleService.AddUserRoleAsync(model);
                return Ok(userRoleAdded);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        [HttpGet("getAllUserRoles")]
        public async Task<IActionResult> GetUserRoles()
        {
            try
            {
                var userRoles = await userRoleService.GetAllUserRolesAsync();
                return Ok(userRoles);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
         
        }

  
        [HttpGet("getUserRoleById/{id:guid}")]
        public async Task<IActionResult> GetUserRoleById(int id)
        {
            try
            {
                var userRole = await userRoleService.GetUserRoleByIdAsync(id);
                return Ok(userRole);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpPut("updateUserRole")]
        public async Task<IActionResult> PutUserRole( UserRoleRequestModel model)
        {
            try
            {
               var updated = await userRoleService.UpdateUserRoleAsync(model);
                return Ok(updated);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }


        [HttpDelete("deleteUserRolebyId/{id:guid}")]
        public async Task<IActionResult> DeleteUserRole(int id)
        {
            try
            {
               var userRoleDeleted=await userRoleService.DeleteUserRoleAsync(id);
               return  Ok(userRoleDeleted);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
