using MySkillTest.Application.Common;
using MySkillTest.Domain.Models;
using OSAP.WebApi.Models;

namespace MySkillTest.Application.Abstractions.IService
{
    public interface IUserRoleService
    {
        Task<ApiResponse<IEnumerable<UserRoleResponseModel>>>? GetAllUserRolesAsync();
        Task<ApiResponse<UserRoleResponseModel>>? GetUserRoleByIdAsync(Guid id);
        Task<ApiResponse<UserRoleResponseModel>>? UpdateUserRoleAsync(UserRoleRequestModel userRoleModel);
        Task<ApiResponse<UserRoleResponseModel>>? AddUserRoleAsync(UserRoleRequestModel userRoleModel);
        Task<ApiResponse<UserRoleResponseModel>>? DeleteUserRoleAsync(Guid id);
    }

}
