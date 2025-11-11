using MySkillTest.Application.Common;
using MySkillTest.Domain.Models.Request;
using MySkillTest.Domain.Models.Response;
using OSAP.WebApi.Models;

namespace MySkillTest.Application.Abstractions.IService
{
    public interface IUserService
    {
        Task<ApiResponse<IEnumerable<UserMasterResponseModel>>>GetAllUsers();
        Task<ApiResponse<UserMasterModel>> GetUserById(Guid id);
        Task<ApiResponse<UserMasterModel>> CreateUser(UserMasterModel model);
        Task<ApiResponse<UserMasterResponseModel>> UpdateUser(UserMasterUpdateModel model);
        Task<ApiResponse<bool>> DeleteUser(Guid id);
    }
}
