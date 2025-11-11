using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Application.Common;
using MySkillTest.Domain.Entities;
using MySkillTest.Domain.Models;
using OSAP.WebApi.Models;

namespace MySkillTest.Application.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepository userRoleRepository;

        public UserRoleService(IUserRoleRepository userRoleRepository)
        {
            this.userRoleRepository = userRoleRepository;
        }

        public async Task<ApiResponse<UserRoleResponseModel>>? AddUserRoleAsync(UserRoleRequestModel userRoleModel)
        {
            try
            {
                //if (userRoleModel is null)
                //{
                //    return ApiResponse<UserRoleResponseModel>.ErrorResponse("model is null or empty", HttpStatusCodes.BadRequest);
                //}
                //if (!userRoleModel.UserId.HasValue)
                //    return ApiResponse<UserRoleResponseModel>.ErrorResponse("RoleId are required.", HttpStatusCodes.BadRequest);
                //var existingRolesAndUserId = await userRoleRepository.FindByAsync(r => r.UserId == userRoleModel.UserId && r.UserRoleId == userRoleModel.UserRoleId);
                //if (existingRolesAndUserId.Any())
                //    return ApiResponse<UserRoleResponseModel>.ErrorResponse("This user already has the specified role assigned.", HttpStatusCodes.Conflict); ;

                UserRole UserRole = new UserRole
                {
                    UserRoleId = Guid.NewGuid(),

                    UserId = userRoleModel.UserId,
                    RoleId = userRoleModel.RoleId,
                    ClientId = userRoleModel.ClientId,
                    CreatedBy = userRoleModel.CreatedBy ?? Guid.Empty,
                    CreatedDate = userRoleModel.CreatedDate ?? DateTimeOffset.UtcNow
                };
                var result = await userRoleRepository.AddUserRole(UserRole);
                if (result > 0)
                {
                    var response = new UserRoleResponseModel
                    {
                        UserRoleId = UserRole.UserId,
                        UserId = UserRole.UserId,
                        RoleId = UserRole.RoleId,
                        CreatedBy = UserRole.CreatedBy,
                        CreatedDate = UserRole.CreatedDate,
                        ClientId = UserRole.ClientId,
                    };
                    return ApiResponse<UserRoleResponseModel>.SuccessResponse(response, ApiMessages.UserRole.UserRoleAddedSuccessfully, HttpStatusCodes.Created);
                }
                return ApiResponse<UserRoleResponseModel>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
            }
            catch (Exception ex)
            {
                return ApiResponse<UserRoleResponseModel>.ErrorResponse($"{ApiMessages.TechnicalError} {ex.Message}", HttpStatusCodes.BadRequest);
            }
        }

        public async Task<ApiResponse<UserRoleResponseModel>> DeleteUserRoleAsync(Guid id)
        {
            var userRole = await userRoleRepository.GetByIdAsync(id);
            if (userRole == null)
            {
                return ApiResponse<UserRoleResponseModel>.ErrorResponse(
                    ApiMessages.UserRole.UserRoleNotFound,
                    HttpStatusCodes.NotFound
                );
            }

            userRole.IsActive = false;
            userRole.ModifiedBy = default; // Set to current user if available

            var deletedOrUpdated = await userRoleRepository.UpdateUserRole(userRole);
            if (deletedOrUpdated > 0)
            {
                var responseModel = new UserRoleResponseModel
                {
                    UserRoleId = userRole.UserRoleId,
                    UserId = userRole.UserId,
                    RoleId = userRole.RoleId,
                    ClientId = userRole.ClientId,
                    CreatedBy = userRole.CreatedBy,
                    CreatedDate = userRole.CreatedDate
                };

                return ApiResponse<UserRoleResponseModel>.SuccessResponse(
                    responseModel,
                    ApiMessages.UserRole.UserRoleDeletedSuccessfully,
                    HttpStatusCodes.OK
                );
            }

            return ApiResponse<UserRoleResponseModel>.ErrorResponse(
                ApiMessages.TechnicalError,
                HttpStatusCodes.InternalServerError
            );
        }


        public async Task<ApiResponse<IEnumerable<UserRoleResponseModel>>>? GetAllUserRolesAsync()
        {
            try
            {
                var userRoles = await userRoleRepository.GetAllUserRoles();
                if (userRoles is null)
                {
                    return ApiResponse<IEnumerable<UserRoleResponseModel>>.ErrorResponse("UserRoles are null or Nothing to show", HttpStatusCodes.BadRequest);
                }
                var res = userRoles.Select(x => new UserRoleResponseModel
                {

                    UserId = x.UserId,
                    ClientId = x.ClientId,
                    UserRoleId = x.UserRoleId,
                    RoleId = x.RoleId
                });
                return ApiResponse<IEnumerable<UserRoleResponseModel>>.SuccessResponse(res, $"{res.Count()} User Roles Found", HttpStatusCodes.OK);
            }
            catch (Exception ex)
            {
                return ApiResponse<IEnumerable<UserRoleResponseModel>>.ErrorResponse($"{ApiMessages.TechnicalError} {ex.Message}", HttpStatusCodes.BadRequest);
            }
        }

        public async Task<ApiResponse<UserRoleResponseModel>>? GetUserRoleByIdAsync(Guid id)
        {
            try
            {
                var userRole = await userRoleRepository.GetByIdAsync(id);
                if (userRole is null)
                {
                    return ApiResponse<UserRoleResponseModel>.ErrorResponse(ApiMessages.UserRole.UserRoleNotFound, HttpStatusCodes.BadRequest);
                }
                var res = new UserRoleResponseModel
                {
                    ClientId = userRole.ClientId,
                    UserId = userRole.UserId,
                    UserRoleId = userRole.UserRoleId,
                    RoleId = userRole.RoleId,
                    CreatedDate = userRole.CreatedDate
                };
                return ApiResponse<UserRoleResponseModel>.SuccessResponse(res, ApiMessages.UserRole.UserRoleFound, HttpStatusCodes.OK);
            }
            catch (Exception ex)
            {
                return ApiResponse<UserRoleResponseModel>.ErrorResponse($"{ApiMessages.TechnicalError} {ex.Message}", HttpStatusCodes.BadRequest);
            }
        }

        public Task<ApiResponse<UserRoleResponseModel>>? UpdateUserRoleAsync(UserRoleRequestModel userRoleModel)
        {
            throw new NotImplementedException();
        }
    }
}
