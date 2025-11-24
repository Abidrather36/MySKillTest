using Microsoft.AspNetCore.Mvc;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Domain.Models.Request;

namespace MySkillTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService roleService;

        public RolesController(IRoleService roleService)
        {
            this.roleService = roleService;
        }
        [HttpPost("registerRole")]
        public async Task<IActionResult> PostRole(RoleRequestModel roleModel)
        {
            try
            {
                var role = await roleService.AddRoleAsync(roleModel);
                return Ok(role);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        [HttpGet("getAllRoles")]
        public async Task<IActionResult> GetRoles()
        {
            try
            {
                var roles = await roleService.GetAllRolesAsync();
                return Ok(roles);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("getRoleById/{id:guid}")]
        public async Task<IActionResult> GetRole(int id)
        {
            try
            {
                var role = await roleService.GetRoleByIdAsync(id);
                return Ok(role);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        [HttpPut("updateRole")]

        public async Task<IActionResult> PutRole(RoleUpdateModel model)
        {
            try
            {
                var roleUpdated = await roleService.UpdateRoleAsync(model);
                return Ok(roleUpdated);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("deleteRoleById/{id:guid}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            try
            {
               var deletedRole=await roleService.DeleteRoleAsync(id);
                return Ok(deletedRole);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
