using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Application.Common;
using MySkillTest.Domain.Entities;
using MySkillTest.Domain.Models.Request;
using MySkillTest.Domain.Models.Response;

namespace MySkillTest.Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;

        public RoleService( IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }
        public async Task<ApiResponse<RoleResponseModel>> AddRoleAsync(RoleRequestModel model)
        {
            if (model == null)
            {
                return ApiResponse<RoleResponseModel>.ErrorResponse(
                    "Model is null",
                    HttpStatusCodes.BadRequest
                );
            }

            var roleAlreadyExists = await roleRepository.RoleExistsAsync(model.ClientId, model.RoleName);
            if (roleAlreadyExists)
            {
                return ApiResponse<RoleResponseModel>.ErrorResponse(
                    ApiMessages.RoleMessages.RoleAlreadyExists,
                    HttpStatusCodes.BadRequest
                );
            }
            var role = new Role
            {
                ClientId = model.ClientId,
                RoleName = model.RoleName,
                Description = model.Description,
                LoweredRoleName = model.RoleName.ToLower() ,
                CreatedDate = DateTimeOffset.Now,   
            };

            var res = await roleRepository.AddRoleAsync(role);
            if (res > 0)
            {
                return ApiResponse<RoleResponseModel>.SuccessResponse(
                    new RoleResponseModel
                    {
                        ClientId = role.ClientId,
                        LoweredRoleName = role.LoweredRoleName,
                        RoleName = role.RoleName,
                        Description = role.Description,
                        RoleId = role.RoleId
                    },
                    ApiMessages.RoleMessages.RoleAddedSuccessfully,
                    HttpStatusCodes.Accepted
                );
            }

            return ApiResponse<RoleResponseModel>.ErrorResponse(
                ApiMessages.TechnicalError,
                HttpStatusCodes.BadRequest
            );
        }


        public Task<ApiResponse<RoleResponseModel>> DeleteRoleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<IEnumerable<RoleResponseModel>>> GetAllRolesAsync()
        {
            try
            {
                var roles = await roleRepository.GetAllRolesAsync();
                if (roles is null)
                {
                    return ApiResponse<IEnumerable<RoleResponseModel>>.ErrorResponse(
                                        "No roles or null ",
                                        HttpStatusCodes.BadRequest
                                    );
                }
                var res = roles.Select(x => new RoleResponseModel
                {
                    RoleId = x.RoleId,
                    LoweredRoleName = x.LoweredRoleName,
                    RoleName = x.RoleName,
                    Description = x.Description,
                    ClientId = x.ClientId,
                    CreatedBy = x.CreatedBy,
                    CreatedDate = x.CreatedDate,
                });
                return ApiResponse<IEnumerable<RoleResponseModel>>.SuccessResponse(res, $"{res.Count()} roles found succesfully", HttpStatusCodes.OK);
            }
            catch (Exception ex)
            {
                return ApiResponse<IEnumerable<RoleResponseModel>>.ErrorResponse(ex.Message, HttpStatusCodes.BadRequest);
            }
        }

        public async Task<ApiResponse<RoleResponseModel>> GetRoleByIdAsync(int id)
        {
            var role = await roleRepository.GetByIdAsync(id);

            if (role == null)
            {
                return ApiResponse<RoleResponseModel>.ErrorResponse(
                    ApiMessages.RoleMessages.RoleNotFound,
                    HttpStatusCodes.NotFound
                );
            }

            var response = new RoleResponseModel
            {
                RoleId = role.RoleId,
                ClientId = role.ClientId,
                RoleName = role.RoleName,
                Description = role.Description,
                LoweredRoleName = role.LoweredRoleName
            };

            return ApiResponse<RoleResponseModel>.SuccessResponse(
                response,
                ApiMessages.RoleMessages.RoleFound,
                HttpStatusCodes.OK
            );
        }


        public Task<ApiResponse<RoleResponseModel>> UpdateRoleAsync(RoleUpdateModel roleModel)
        {
            throw new NotImplementedException();
        }
    }
}
