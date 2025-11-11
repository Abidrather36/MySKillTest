using MySkillTest.Application.Common;
using MySkillTest.Domain.Models.Request;
using MySkillTest.Domain.Models.Response;
using OSAP.WebApi.Models;

namespace MySkillTest.Application.Abstractions.IService
{
    public interface IRoleService
    {
        Task<ApiResponse<IEnumerable<RoleResponseModel>>> GetAllRolesAsync();
        Task<ApiResponse<RoleResponseModel>> GetRoleByIdAsync(Guid id);
        Task<ApiResponse<RoleResponseModel>> AddRoleAsync(RoleRequestModel model);
        Task<ApiResponse<RoleResponseModel>> UpdateRoleAsync(RoleUpdateModel model);
        Task<ApiResponse<RoleResponseModel>> DeleteRoleAsync(Guid id);
    }

}
